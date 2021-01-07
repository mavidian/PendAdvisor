namespace PendAdvisorClient
{
   /// <summary>
   /// Type of http POST response body
   /// </summary>
   public class AdviceData
   {
      public string ClaimID { get; set; }
      public string AdvisedAction { get; set; }
      public float AdviceScore { get; set; }
      public ActionAndScore[] ActionsAndScores { get; set; }
   }

   public struct ActionAndScore
   {
      public string Action { get; set; }
      public float Score { get; set; }
   }
}
