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
      // The model (MLModel.zip file) is needed during both training (PendAdvisorTrainer project) and consuming the model (PendAdvisor.API project).
      // Because the ML model can be consumed in many scenarios (such as Docker), the MLModel.zip file is loaded from the location of current executable,
      // such as PendAdvisor.API.exe. MLModel.zip is copied to this location during the build (Copy if newer) of the API project.
      // Therefore, PendAdvisor.API project MUST BE REBUILT every time a new ML model is trained (or the old ML model will be in effect)
      private static char sep = Path.DirectorySeparatorChar;
      private static string _pathToLoadModel = $"{AppContext.BaseDirectory}MlModel{sep}MLModel.zip"; //used by the ML model consumer, e.g. the API
      public static string PathToSaveModel = Path.GetFullPath(Path.GetDirectoryName(SourcePathAtCompile()) + $"{sep}..{sep}PendAdvisor.API{sep}MlModel{sep}MLModel.zip");  // used by the ML model trainer
      private static string SourcePathAtCompile([CallerFilePath] string thisFilePath = null) { return thisFilePath; }  // a subfolder of this source file at the compile time.

      public static ModelOutput Predict(ModelInput input)
      {
         return PredictionEngine.Value.Predict(input);
      }


      public static ModelOutputEx PredictEx(ModelInput input)
      {
         var model = Predict(input);

         var modelEx = new ModelOutputEx();
         modelEx.Action = model.Action;
         modelEx.Scores = model.Scores;

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
         ITransformer mlModel = mlContext.Model.Load(_pathToLoadModel, out _);
         var predictor = mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(mlModel);
         return predictor;
      }


      /// <summary>
      /// Calculate cross-reference between a 0-based index (to the array with Label values) and the actual value in the Label column.
      /// </summary>
      /// <param name="predictor">Predicting engine (has the index to prediction mapping defined during MapValueToKey conversion).</param>
      /// <returns></returns>
      public static Dictionary<int, string> GetLabelMap(PredictionEngine<ModelInput, ModelOutput> predictor)
      {  //inspired by https://blog.hompus.nl/2020/09/14/get-all-prediction-scores-from-your-ml-net-model/
         var labelBuffer = new VBuffer<ReadOnlyMemory<char>>();
         predictor.OutputSchema["Score"].Annotations.GetValue("SlotNames", ref labelBuffer);
         var labels = labelBuffer.DenseValues().Select(l => l.ToString());

         int i = 0;
         return labels.ToDictionary(_ => i++, l => l);
      }

   }
}
