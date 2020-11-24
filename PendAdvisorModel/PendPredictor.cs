using Microsoft.ML;
using System;
using System.IO;

namespace PendAdvisorModel
{
   public static class PendPredictor
   {
      public static string PathToModelLocation { get; } = Path.GetFullPath("MLModel.zip");
      
      private static Lazy<PredictionEngine<ModelInput, ModelOutput>> PredictionEngine = new Lazy<PredictionEngine<ModelInput, ModelOutput>>(CreatePredictionEngine);

      private static PredictionEngine<ModelInput, ModelOutput> CreatePredictionEngine()
      {
         throw new NotImplementedException();
      }

   }
}
