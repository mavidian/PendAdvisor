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
      // such as PendAdvisor.API.exe. MLModel.zip is copied to that location (from MLModel subfolder) during the build (Copy if newer) of the PendAdvisor.API project.
      // Note that MLModel.zip is created (and posted to the MLModel subfolder of the PendAdvisor.API project) when PendAdvisorTrainer application is executed. 
      // Therefore, PendAdvisor.API project MUST BE REBUILT every time a new ML model is trained, i.e. after running PendAdvisorTrainer.exe (or the old ML model will remain in effect).
      private static char sep = Path.DirectorySeparatorChar;
      private static string _pathToLoadModel = $"{AppContext.BaseDirectory}MLModel{sep}MLModel.zip"; //used by the ML model consumer, e.g. the API
      public static string PathToSaveModel = Path.GetFullPath(Path.GetDirectoryName(SourcePathAtCompile()) + $"{sep}..{sep}PendAdvisor.API{sep}MLModel{sep}MLModel.zip");
      public static string PathToSaveModel2 = Path.GetFullPath(Path.GetDirectoryName(SourcePathAtCompile()) + $"{sep}..{sep}PendAdvisorTester{sep}MLModel{sep}MLModel.zip");
      // 12/29/2020: additional consumer of this PendPredictor class has been added - PendAdvisorTester project, which necessitates the MLModel.zip to also be available in a subfolder
      // of the PendAdvisorTester.exe (like described above for the PendAdvisor.API).
      // TODO: read the MLModel.zip file from a single location instead of a subfolder of current executable.

      private static string SourcePathAtCompile([CallerFilePath] string thisFilePath = null) { return thisFilePath; }  // a subfolder of this source file at the compile time.


      /// <summary>
      /// Return the output (a predition and set of scores) from the prediction engine.
      /// </summary>
      /// <param name="input"></param>
      /// <returns></returns>
      public static ModelOutput Predict(ModelInput input)
      {
         return PredictionEngine.Value.Predict(input);
      }


      /// <summary>
      /// Return model prediction in a friendly format, i.e. predicted values and scores side-by-side. 
      /// </summary>
      /// <param name="input"></param>
      /// <returns></returns>
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
