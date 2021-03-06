﻿using Microsoft.ML;
using Microsoft.ML.Data;
using Microsoft.ML.Trainers;
using PendAdvisorModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using static Microsoft.ML.TrainCatalogBase;

namespace PendAdvisorTrainer
{
   public class Program
   {
      private static readonly char sep = Path.DirectorySeparatorChar;
      private static readonly string _dataPath = $"..{sep}..{sep}..{sep}Data{sep}TestClaims.csv";
      ////private static readonly string _dataPath = $"..{sep}..{sep}..{sep}Data{sep}claimsPartialTraining1.csv";
      ////private static readonly string _dataPath = $"..{sep}..{sep}..{sep}Data{sep}claimsFullTraining1.csv";
      private static readonly bool _skipCrossValidation = true;

      private static MLContext _mlContext = new MLContext(seed: 1);

      static void Main(string[] args)
      {
         // Load the data
         var allData = _mlContext.Data.LoadFromTextFile<ModelInput>(_dataPath, hasHeader: true, separatorChar: ',');

         // Split the data into a training set (80%) and a test set (20%)
         var trainTestData = _mlContext.Data.TrainTestSplit(allData, testFraction: 0.2, seed: 0);
         var trainData = trainTestData.TrainSet;
         var testData = trainTestData.TestSet;

         //Build training pipeline
         (IEstimator<ITransformer> trainingPipeline, string algorithmDesc) = BuildTrainingPipeline();

         //Train the model
         Console.WriteLine($"{DateTime.Now} Training the model...");
         Console.WriteLine($"Training algorithm used: {algorithmDesc}");
         ITransformer mlModel = TrainModel(trainingPipeline, trainData);

         // Evaluate quality of the model
         Console.WriteLine();
         Console.WriteLine($"{DateTime.Now} Evaluating the model...");
         (var metrics, var crossValidationMetrics) = EvaluateModel(mlModel, testData, trainingPipeline, allData);

         Console.WriteLine($"Macro accuracy = {metrics.MacroAccuracy:P2}");
         Console.WriteLine($"Micro accuracy = {metrics.MicroAccuracy:P2}");
         Console.WriteLine(metrics.ConfusionMatrix.GetFormattedConfusionTable());

         if (crossValidationMetrics == null) Console.WriteLine("Cross-validation skipped.");
         else
         {
            Console.WriteLine($"Mean cross-validated macro accuracy = {crossValidationMetrics.Average(s => s.Metrics.MacroAccuracy):P2}");
            Console.WriteLine($"Mean cross-validated micro accuracy = {crossValidationMetrics.Average(s => s.Metrics.MicroAccuracy):P2}");
         }

         // Use the model to make a sample prediction
         Console.WriteLine();
         Console.WriteLine($"{DateTime.Now} Using the model to make prediction...");

         var input = new ModelInput
         {
            Diagnosis1 = "E10",
            Diagnosis2 = "I11",
            POS = "21",
            ProcedureCode = "34907",
            Units = 1,
            Price = 100f,
            PendReason = "PAUT"
         };

         var predictor = _mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(mlModel);

         var prediction = predictor.Predict(input);

         var labelMap = PendPredictor.GetLabelMap(predictor);  //translates 0-based index to the actual value in the Label column.

         Console.WriteLine("Predictions and their scores (high to low):");
         prediction.Scores.Zip(Enumerable.Range(0,int.MaxValue))
                          .OrderByDescending(t => t.First).ToList() //First = Score, Second = index
                          .ForEach(t => Console.WriteLine($"{t.Second}.{labelMap[t.Second],8} - {t.First:N8}"));

         Console.WriteLine();
         Console.WriteLine($"So, the predicted action is {prediction.Action}.");

         // Save the trained model to a .ZIP file
         Console.WriteLine();
         Console.WriteLine($"{DateTime.Now} Saving the trained model into {PendPredictor.PathToSaveModel} file...");
         SaveModel(mlModel, allData.Schema, PendPredictor.PathToSaveModel);
         Console.WriteLine($"{DateTime.Now} Saving the trained model into {PendPredictor.PathToSaveModel2} file...");
         SaveModel(mlModel, allData.Schema, PendPredictor.PathToSaveModel2);
         Console.WriteLine("Rebuild the API and Tester projects in order for the new model to be in effect!");

         Console.WriteLine();
         Console.WriteLine($"{DateTime.Now} ALL DONE!");

         if (Debugger.IsAttached)
         {
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey();
         }
      }


      /// <summary>
      /// Build the pipeline for model training
      /// </summary>
      /// <returns>Tuple consisting of the pipeline and description of the trainer (algorithm).</returns>
      private static (IEstimator<ITransformer> TrainingPipeline, string AlgorithmDesc) BuildTrainingPipeline()
      {
         string binaryTrainerName = string.Empty;
         //var binaryTrainer = _mlContext.BinaryClassification.Trainers.SdcaLogisticRegression(); //binary classification trainer needed in case of OVA
         //binaryTrainerName = binaryTrainer.GetType().Name;
         //var trainer = _mlContext.MulticlassClassification.Trainers.OneVersusAll(binaryTrainer);
         var trainer = _mlContext.MulticlassClassification.Trainers.SdcaMaximumEntropy();
         var pipeline = _mlContext.Transforms.Conversion.MapValueToKey(outputColumnName: "Label", inputColumnName: "StringLabel")
             .Append(_mlContext.Transforms.Categorical.OneHotEncoding(outputColumnName: "Diagnosis1Encoded", inputColumnName: "Diagnosis1"))
             .Append(_mlContext.Transforms.Categorical.OneHotEncoding(outputColumnName: "Diagnosis2Encoded", inputColumnName: "Diagnosis2"))
             .Append(_mlContext.Transforms.Categorical.OneHotEncoding(outputColumnName: "PosEncoded", inputColumnName: "POS"))
             .Append(_mlContext.Transforms.Categorical.OneHotEncoding(outputColumnName: "ProcedureCodeEncoded", inputColumnName: "ProcedureCode"))
             .Append(_mlContext.Transforms.Categorical.OneHotEncoding(outputColumnName: "PendReasonEncoded", inputColumnName: "PendReason"))
             .Append(_mlContext.Transforms.Concatenate("Features", "Diagnosis1Encoded", "Diagnosis2Encoded", "PosEncoded", "ProcedureCodeEncoded", "Units", "Price", "PendReasonEncoded"))
             .AppendCacheCheckpoint(_mlContext) //improve performance at the cost of memory use (good only for small/medium size data)
             .Append(trainer)
             .Append(_mlContext.Transforms.Conversion.MapKeyToValue(outputColumnName: "PredictedLabel"));

         var trainerType = trainer.GetType();
         var algorithmDesc = trainerType == typeof(OneVersusAllTrainer) ? $"{trainerType.Name} with {binaryTrainerName}" : trainerType.Name;
         return (pipeline, algorithmDesc);
      }


      /// <summary>
      /// Train the model.
      /// </summary>
      /// <param name="trainingPipeline">Pipeline for model training.</param>
      /// <param name="trainData">Training data view.</param>
      /// <returns>The trained model.</returns>
      public static ITransformer TrainModel( IEstimator<ITransformer> trainingPipeline, IDataView trainData)
      {
         return trainingPipeline.Fit(trainData);
      }


      /// <summary>
      /// Evaluate the model quality.
      /// </summary>
      /// <param name="mlModel"></param>
      /// <param name="testData">Data view to evaluate the model.</param>
      /// <param name="trainingPipeline">Pipeline for model training.</param>
      /// <param name="allData">Data view to be used by cross validation.</param>
      /// <returns>A tuple containing evaluation metrics and metrics from cross validation (2nd element is null in case cross validation is skipped).</returns>
      private static (MulticlassClassificationMetrics Metrics,
                      IEnumerable<CrossValidationResult<MulticlassClassificationMetrics>> CrossValidationMetrics) EvaluateModel(
                           ITransformer mlModel, IDataView testData, IEstimator<ITransformer> trainingPipeline, IDataView allData)
      {
         var predictions = mlModel.Transform(testData);
         var metrics = _mlContext.MulticlassClassification.Evaluate(predictions);
         IEnumerable<CrossValidationResult<MulticlassClassificationMetrics>> crossValidationMetrics = null;
         if (!_skipCrossValidation)
         {
            //Evaluate the model using cross-validation
            crossValidationMetrics = _mlContext.MulticlassClassification.CrossValidate(allData, trainingPipeline, numberOfFolds: 5);
         }
         return (metrics, crossValidationMetrics);
      }


      /// <summary>
      /// 
      /// </summary>
      /// <param name="mlModel"></param>
      /// <param name="modelInputSchema"></param>
      /// <param name="modelPath"></param>
      private static void SaveModel(ITransformer mlModel, DataViewSchema modelInputSchema, string modelPath)
      {
         Directory.CreateDirectory(Path.GetDirectoryName(modelPath)); //make sure location to save the model exists
         _mlContext.Model.Save(mlModel, modelInputSchema, modelPath);
      }

   }
}
