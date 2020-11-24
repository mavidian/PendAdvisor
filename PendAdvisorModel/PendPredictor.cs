using Microsoft.ML;
using System;
using System.IO;

namespace PendAdvisorModel
{
   public static class PendPredictor
   {
      public static string PathToModelLocation { get; } = Path.GetFullPath("MLModel.zip");

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
