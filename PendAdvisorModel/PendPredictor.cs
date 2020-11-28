using Microsoft.ML;
using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;

namespace PendAdvisorModel
{
   public static class PendPredictor
   {
      // The model (MLModel.zip file) needs to reside in an arbitrary location accessible from multiple projects.
      // Here, we're placing it in a subfolder of this source file at the compile time.
      //TODO: refactor for truly arbitrary location.
      private static char sep = Path.DirectorySeparatorChar;
      public static string PathToModelLocation { get; } = Path.GetDirectoryName(SourcePathAtCompile()) + $"{sep}MlModel{sep}MLModel.zip";

      private static string SourcePathAtCompile([CallerFilePath] string thisFilePath = null) { return thisFilePath; }

      public static ModelOutput Predict(ModelInput input)
      {
         return PredictionEngine.Value.Predict(input);
      }


      /// <summary>
      /// Cross-reference between a 0-based index to the array with Label values and the actual value in the Label column.
      /// (does not get assigned until prediction engine is created, e.g. by calling Predict method).
      /// </summary>
      public static Dictionary<int, string> LabelMap { get; private set; }

      public static ModelOutputEx PredictEx(ModelInput input)
      {
         var modelEx = (ModelOutputEx)Predict(input);

         // ActionsAndScores is a set of tuples (Action and Score) sorted by Score (highest first).
         modelEx.ActionsAndScores =
            modelEx.Scores.Zip(Enumerable.Range(0, int.MaxValue), (f, s) => (First: f, Second: s))  // First = Score, Second = index
                        .OrderByDescending(t => t.First)
                        .Select(t => (Action: GetLabelMap(PredictionEngine.Value)[t.Second], Score: t.First))
                        .ToArray();
         return modelEx;
      }


      private static Lazy<PredictionEngine<ModelInput, ModelOutput>> PredictionEngine = new Lazy<PredictionEngine<ModelInput, ModelOutput>>(CreatePredictionEngine);

      private static PredictionEngine<ModelInput, ModelOutput> CreatePredictionEngine()
      {
         MLContext mlContext = new MLContext();
         ITransformer mlModel = mlContext.Model.Load(PathToModelLocation, out _);
         var predictor = mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(mlModel);
         LabelMap = GetLabelMap(predictor);  //translates 0-based index to the actual value in the Label column.
         return predictor;
      }


      /// <summary>
      /// Calculate cross-reference between a 0-based index to the array with Label values and the actual value in the Label column.
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
}
