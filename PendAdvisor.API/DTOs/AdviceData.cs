namespace PendAdvisor.API.DTOs
{
   public class AdviceData
   {
      public string ClaimID { get; set; }
      public string AdvisedAction { get; set; }
      public float AdviceScore { get; set; }
      public (string Action, float Score)[] ActionsAndScores { get; set; }
   }
}
