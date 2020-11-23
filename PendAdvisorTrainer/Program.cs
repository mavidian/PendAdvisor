using Microsoft.ML;
using Microsoft.ML.Data;
using Microsoft.ML.Trainers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PendAdvisorTrainer
{
   class Program
   {
      static readonly string _dataPath = "..\\..\\..\\Data\\MockClaims.csv";
      static readonly bool _skipCrossValidation = true;

      static void Main(string[] args)
      {
         var mlContext = new MLContext(seed: 0);

         // Load the data
         var data = mlContext.Data.LoadFromTextFile<ModelInput>(_dataPath, hasHeader: true, separatorChar: ',');

         // Split the data into a training set (80%) and a test set (20%)
         var trainTestData = mlContext.Data.TrainTestSplit(data, testFraction: 0.2, seed: 0);
         var trainData = trainTestData.TrainSet;
         var testData = trainTestData.TestSet;

         // Build and train the model
         var binaryTrainer = mlContext.BinaryClassification.Trainers.SdcaLogisticRegression(); //binary classification trainer needed in case of OVA
         //var trainer = context.MulticlassClassification.Trainers.OneVersusAll(binaryTrainer);
         var trainer = mlContext.MulticlassClassification.Trainers.SdcaMaximumEntropy();
         var pipeline = mlContext.Transforms.Conversion.MapValueToKey(outputColumnName: "Label", inputColumnName: "StringLabel")
             .Append(mlContext.Transforms.Categorical.OneHotEncoding(outputColumnName: "PosEncoded", inputColumnName: "Pos"))
             .Append(mlContext.Transforms.Categorical.OneHotEncoding(outputColumnName: "ReasEncoded", inputColumnName: "Reas"))
             .Append(mlContext.Transforms.Concatenate("Features", "ProcCd", "PosEncoded", "ReasEncoded", "TotChg"))
             .AppendCacheCheckpoint(mlContext) //improve performance, but only for small/medium size data
             .Append(trainer)
             .Append(mlContext.Transforms.Conversion.MapKeyToValue(outputColumnName: "PredictedLabel"));

         Console.WriteLine($"{DateTime.Now} Training the model...");
         var trainerType = trainer.GetType();
         var binaryTrainerInfo = trainerType == typeof(OneVersusAllTrainer) ? $" with {binaryTrainer.GetType().Name}" : string.Empty;
         Console.WriteLine($"Training algorithm used: {trainerType.Name}{binaryTrainerInfo}");
         var model = pipeline.Fit(trainData);

         //..model trained, create predicting engine early as it's needed to get the labelMap
         var predictor = mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(model);
         var labelMap = GetLabelMap(predictor);  //translates 0-based index to the actual value in the Label column.

         // Evaluate the model
         Console.WriteLine();
         Console.WriteLine($"{DateTime.Now} Evaluating the model...");
         var predictions = model.Transform(testData);
         var metrics = mlContext.MulticlassClassification.Evaluate(predictions);

         Console.WriteLine($"Macro accuracy = {metrics.MacroAccuracy:P2}");
         Console.WriteLine($"Micro accuracy = {metrics.MicroAccuracy:P2}");
         //Console.WriteLine($"Logarithmic Loss   = {metrics.LogLoss:N8}");
         //Console.WriteLine($"Log-Loss Reduction = {metrics.LogLossReduction:N8}");
         //Console.WriteLine();
         //Console.WriteLine("Log-Loss values per class (Action):");
         //metrics.PerClassLogLoss.Zip(Enumerable.Range(0,int.MaxValue)).ToList().
         //                        ForEach(t => Console.WriteLine($"{t.Second}.{labelMap[t.Second],8} - {t.First:N8}")); //First = log-loss, Second = index
         Console.WriteLine(metrics.ConfusionMatrix.GetFormattedConfusionTable());

         if (!_skipCrossValidation)
         {
            //Evaluate the model using cross-validation
            Console.WriteLine($"{DateTime.Now} Cross-validating the model...");
            var scores = mlContext.MulticlassClassification.CrossValidate(data, pipeline, numberOfFolds: 5);

            Console.WriteLine($"Mean cross-validated macro accuracy = {scores.Average(s => s.Metrics.MacroAccuracy):P2}");
            Console.WriteLine($"Mean cross-validated micro accuracy = {scores.Average(s => s.Metrics.MicroAccuracy):P2}");
            //Console.WriteLine($"Mean cross-validated log-loss      : {scores.Average(s => s.Metrics.LogLoss):N8}");
            //Console.WriteLine($"Mean cross-validated log-loss red. : {scores.Average(s => s.Metrics.LogLossReduction):N8}");
         }

         // Use the model to make a prediction
         Console.WriteLine();
         Console.WriteLine($"{DateTime.Now} Using the model to make prediction...");

         var input = new ModelInput
         {
            ProcCd = 214f,
            Pos = "11",
            Reas = "PAUT",
            TotChg = 100f
         };

         var prediction = predictor.Predict(input);

         Console.WriteLine("Predictions and their scores (high to low):");
         prediction.Scores.Zip(Enumerable.Range(0,int.MaxValue))
                          .OrderByDescending(t => t.First).ToList() //First = Score, Second = index
                          .ForEach(t => Console.WriteLine($"{t.Second}.{labelMap[t.Second],8} - {t.First:N8}"));

         Console.WriteLine();
         Console.WriteLine($"So, the predicted action is {prediction.Action}.");
         Console.WriteLine();
         Console.WriteLine($"{DateTime.Now} ALL DONE!");

#if DEBUG
         Console.Write("Press any key to continue . . . ");
         Console.ReadKey();
#endif
      }

   
      /// <summary>
      /// Return a cross-reference between a 0-based index to the actual value in the Label column.
      /// </summary>
      /// <param name="predictor">Predicting engine (has the index to prediction mapping defined during MapValueToKey conversion).</param>
      /// <returns></returns>
      private static Dictionary<int, string> GetLabelMap(PredictionEngine<ModelInput, ModelOutput> predictor)
      {  //inspired by https://blog.hompus.nl/2020/09/14/get-all-prediction-scores-from-your-ml-net-model/
         var labelBuffer = new VBuffer<ReadOnlyMemory<char>>();
         predictor.OutputSchema["Score"].Annotations.GetValue("SlotNames", ref labelBuffer);
         var labels = labelBuffer.DenseValues().Select(l => l.ToString());

         int i = 0;
         return labels.ToDictionary(_ => i++, l => l);
      }

   }


   class ModelInput
   {
      [LoadColumn(6)]
      public float ProcCd;

      ////[LoadColumn(7)]
      ////public string Dx;

      [LoadColumn(8)]
      public string Pos;

      [LoadColumn(9)]
      public string Reas;

      [LoadColumn(10)]
      public float TotChg;

      [LoadColumn(11), ColumnName("StringLabel")]
      public string Action;
   }


   class ModelOutput
   {
      [ColumnName("Score")]
      public float[] Scores;

      [ColumnName("PredictedLabel")]
      public string Action;
   }

}
