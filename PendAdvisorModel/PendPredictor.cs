using Microsoft.ML;
using System;
using System.IO;
using System.Reflection;
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


      private static Lazy<PredictionEngine<ModelInput, ModelOutput>> PredictionEngine = new Lazy<PredictionEngine<ModelInput, ModelOutput>>(CreatePredictionEngine);

      private static PredictionEngine<ModelInput, ModelOutput> CreatePredictionEngine()
      {
         MLContext mlContext = new MLContext();
         ITransformer mlModel = mlContext.Model.Load(PathToModelLocation, out _);
         return mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(mlModel);
      }

   }
}
