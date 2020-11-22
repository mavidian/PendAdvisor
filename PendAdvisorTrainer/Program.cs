using Microsoft.ML;
using Microsoft.ML.Data;
using System;
using System.Linq;
using static Microsoft.ML.Transforms.ValueToKeyMappingEstimator;

namespace PendAdvisorTrainer
{
   class Program
   {
      static readonly string _dataPath = "..\\..\\..\\Data\\MockClaims.csv";

      static void Main(string[] args)
      {
         var context = new MLContext(seed: 0);

         // Load the data
         var data = context.Data.LoadFromTextFile<Input>(_dataPath, hasHeader: true, separatorChar: ',');

         // Split the data into a training set and a test set
         var trainTestData = context.Data.TrainTestSplit(data, testFraction: 0.2, seed: 0);
         var trainData = trainTestData.TrainSet;
         var testData = trainTestData.TestSet;

         // Build and train the model
         var pipeline = context.Transforms.Conversion.MapValueToKey("Label", inputColumnName: "StringLabel")
             .Append(context.Transforms.Categorical.OneHotEncoding(inputColumnName: "Pos", outputColumnName: "PosEncoded"))
             .Append(context.Transforms.Categorical.OneHotEncoding(inputColumnName: "Reas", outputColumnName: "ReasEncoded"))
             .Append(context.Transforms.Concatenate("Features", "ProcCd", "PosEncoded", "ReasEncoded", "TotChg"))
             .Append(context.MulticlassClassification.Trainers.SdcaMaximumEntropy())
             .Append(context.Transforms.Conversion.MapKeyToValue("PredictedLabel"));

         Console.WriteLine($"{DateTime.Now} Training the model...");
         var model = pipeline.Fit(trainData);

         // Evaluate the model
         Console.WriteLine();
         Console.WriteLine($"{DateTime.Now} Evaluating the model...");
         var predictions = model.Transform(testData);
         var metrics = context.MulticlassClassification.Evaluate(predictions);

         Console.WriteLine($"Macro accuracy = {metrics.MacroAccuracy:P2}");
         Console.WriteLine($"Micro accuracy = {metrics.MicroAccuracy:P2}");
         Console.WriteLine(metrics.ConfusionMatrix.GetFormattedConfusionTable());

         //Evaluate the model using cross-validation
         Console.WriteLine();
         Console.WriteLine($"{DateTime.Now} Cross-validating the model...");
         var scores = context.MulticlassClassification.CrossValidate(data, pipeline, numberOfFolds: 5);
         var mean = scores.Average(s => s.Metrics.MacroAccuracy);

         Console.WriteLine($"Mean cross-validated macro accuracy: {mean:P2}");

         // Use the model to make a prediction
         Console.WriteLine();
         Console.WriteLine($"{DateTime.Now} Using the model to make prediction...");
         var predictor = context.Model.CreatePredictionEngine<Input, Output>(model);

         var input = new Input
         {
            ProcCd = 214,
            Pos = "11",
            Reas = "PAUT",
            TotChg = 100f
         };

         var prediction = predictor.Predict(input);

         int i = 0;
         foreach (var score in prediction.Scores)
         {
            Console.WriteLine($"{i++} - {score:N8}");
         }

         Console.WriteLine();
         Console.WriteLine($"Predicted action is {prediction.Action}.");
         Console.WriteLine();
         Console.WriteLine($"{DateTime.Now} ALL DONE!");

#if DEBUG
         Console.Write("Press any key to continue . . . ");
         Console.ReadKey();
#endif
      }
   }


   class Input
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


   class Output
   {
      [ColumnName("Score")]
      public float[] Scores;

      [ColumnName("PredictedLabel")]
      public string Action;
   }
}
