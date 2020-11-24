using Microsoft.ML.Data;

namespace PendAdvisorModel
{
   public class ModelInput
   {
      // LoadColumn is the 0-based index of the column in input data.
      // ColumnName is the name of the column in the ML model (in absense of it, ColumnName = name of the property).

      [LoadColumn(0)]
      public string ClmId { get; set; }

      [LoadColumn(1)]
      public string Mbr { get; set; }

      [LoadColumn(2)]
      public float Npi { get; set; }

      [LoadColumn(3)]
      public string State { get; set; }

      [LoadColumn(4)]
      public float Zip { get; set; }

      [LoadColumn(5)]
      public string Date { get; set; }

      [LoadColumn(6)]
      public float ProcCd { get; set; }

      [LoadColumn(7)]
      public string Dx { get; set; }

      [LoadColumn(8)]
      public string Pos { get; set; }

      [LoadColumn(9)]
      public string Reas { get; set; }

      [LoadColumn(10)]
      public float TotChg { get; set; }

      [LoadColumn(11), ColumnName("StringLabel")]
      public string Action { get; set; }
   }
}
