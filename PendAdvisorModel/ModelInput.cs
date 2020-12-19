using Microsoft.ML.Data;

namespace PendAdvisorModel
{
   public class ModelInput
   {
      // LoadColumn is the 0-based index of the column in input data.
      // ColumnName is the name of the column in the ML model (in absense of it, ColumnName = name of the property).

      [LoadColumn(0)]
      public string MemberID { get; set; }

      [LoadColumn(1)]
      public string ClaimID { get; set; }

      [LoadColumn(2)]
      public string DateReceived { get; set; }

      [LoadColumn(3)]
      public string providerNPI { get; set; }

      [LoadColumn(4)]
      public string Diagnosis1 { get; set; }

      [LoadColumn(5)]
      public string Diagnosis2 { get; set; }

      [LoadColumn(6)]
      public string POS { get; set; }

      [LoadColumn(7)]
      public string ProcedureCode { get; set; }

      [LoadColumn(8)]
      public float Units { get; set; }

      [LoadColumn(9)]
      public float Price { get; set; }

      [LoadColumn(10)]
      public string PendReason { get; set; }

      [LoadColumn(11), ColumnName("StringLabel")]
      public string Action { get; set; }
   }
}
