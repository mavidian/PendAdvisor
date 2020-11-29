namespace PendAdvisor.API.DTOs
{
   /// <summary>
   /// Type of HTTP POST response body
   /// </summary>
   public class ClaimData
   {
      public string ClaimID { get; set; }
      public string MemberID { get; set; }
      public string DateReceived { get; set; }
      public int providerNPI { get; set; }
      public string Diagnosis1 { get; set; }
      public string Diagnosis2 { get; set; }
      public string POS { get; set; }
      public string ProcedureCode { get; set; }
      public float Units { get; set; }
      public float Price { get; set; }
      public string PendReason { get; set; }
   }
}
