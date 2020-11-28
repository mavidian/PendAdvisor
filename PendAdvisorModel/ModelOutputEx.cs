using System.Linq;

namespace PendAdvisorModel
{
   /// <summary>
   /// Friendly version of ModelOutput.
   /// It associates Scores with the actual predicted Action (Label) value.
   /// </summary>
   public class ModelOutputEx : ModelOutput
   {
      /// <summary>
      /// Ordered set of tuples with Action and Score (highest Score first).
      /// </summary>
      public (string Action, float Score)[] ActionsAndScores { get; set; }

   }
}
