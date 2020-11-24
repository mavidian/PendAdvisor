using Microsoft.ML.Data;

namespace PendAdvisorModel
{
   public class ModelOutput
   {
      // ColumnName is the name of the column in the ML model (in absense of it, ColumnName = name of the property).

      [ColumnName("PredictedLabel")]
      public string Action { get; set; }
      [ColumnName("Score")]
      public float[] Scores { get; set; }
   }
}
