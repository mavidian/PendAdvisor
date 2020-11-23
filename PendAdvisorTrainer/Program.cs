using Microsoft.ML;
using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Linq;

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

         Console.WriteLine("Predictions and their scores (high to low)");
         int i = 0;
         predictor.ScoresByAction(prediction).Select(p => new { Idx = i++, Pred = p })
                                             .OrderByDescending(a => a.Pred.Score).ToList()
                                             .ForEach(a => Console.WriteLine($"{a.Idx}.{a.Pred.Label,8} - {a.Pred.Score:N8}"));
         Console.WriteLine();
         Console.WriteLine($"So, the predicted action is {prediction.Action}.");
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

   static class OutputHelpers
   {
      /// <summary>
      /// Associate the Score column values with the corresponding prediction labels.
      /// </summary>
      /// <param name="predictor">Predicting engine (has the indes to prediction mapping defined during MapValueToKey conversion).</param>
      /// <param name="output">Output predicted by the predictor (has just the scores array - no prediction values).</param>
      /// <returns>A set of tuples (with Labels and corresponding Scores) in order of their indexes in the Score array.</returns>
      internal static IEnumerable<(string Label, float Score)> ScoresByAction(this PredictionEngine<Input, Output> predictor, Output output)
      {  //inspired by https://blog.hompus.nl/2020/09/14/get-all-prediction-scores-from-your-ml-net-model/
         var labelBuffer = new VBuffer<ReadOnlyMemory<char>>();
         predictor.OutputSchema["Score"].Annotations.GetValue("SlotNames", ref labelBuffer);
         var labels = labelBuffer.DenseValues().Select(l => l.ToString());

         return Enumerable.Zip(labels, output.Scores);
      }
   }
}
