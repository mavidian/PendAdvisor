using FluentAssertions;
using System.Linq;
using Xunit;

namespace PendAdvisorModel.Tests
{
   public class PendPredictor_tests
   {
      [Fact]
      public void Predict_SampleInput_CorrectOutput()
      {
         //arrange
         var sampleInput = new ModelInput()
         {
            ProcCd = 8534,
            Dx = "73312",
            Pos = "11",
            Reas = "PDUP",
            TotChg = 100,
         };

         //act
         var predictedOutput = PendPredictor.Predict(sampleInput);

         //assert
         predictedOutput.Action.Should().BeOneOf("RePend", "Release", "Deny", "MedRev");
         predictedOutput.Scores.Count().Should().Be(4);
         predictedOutput.Scores.ToList().ForEach(s => s.Should().BeGreaterThan(0f).And.BeLessThan(1f));
      }
   }
}

