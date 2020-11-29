namespace PendAdvisor.API.DTOs
{
   /// <summary>
   /// Type of HTTP POST response body
   /// </summary>
   public class AdviceData
   {
      public string ClaimID { get; set; }
      public string AdvisedAction { get; set; }
      public float AdviceScore { get; set; }
      public object[] ActionsAndScores { get; set; }  // mapper will assign anonymous type consisting of Action and Score
   }
}
