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
            Diagnosis1 = "E10",
            Diagnosis2 = "I11",
            POS = "21",
            ProcedureCode = "34907",
            Units = 1,
            Price = 100f,
            PendReason = "PAUT"
         };

         //act
         var predictedOutput = PendPredictor.Predict(sampleInput);

         //assert
         predictedOutput.Action.Should().BeOneOf("RePend", "Release", "Deny", "MedReview");
         predictedOutput.Scores.Count().Should().Be(4);
         predictedOutput.Scores.ToList().ForEach(s => s.Should().BeGreaterThan(0f).And.BeLessThan(1f));
      }


      [Fact]
      public void PredictEx_SampleInput_CorrectOutput()
      {
         //arrange
         var sampleInput = new ModelInput()
         {
            Diagnosis1 = "E10",
            Diagnosis2 = "I11",
            POS = "21",
            ProcedureCode = "34907",
            Units = 1,
            Price = 100f,
            PendReason = "PAUT"
         };

         //act
         var predictedOutput = PendPredictor.PredictEx(sampleInput);

         //assert
         predictedOutput.ActionsAndScores.Count().Should().Be(4);
         predictedOutput.ActionsAndScores.Select(t => t.Score).Should().BeInDescendingOrder();
         predictedOutput.ActionsAndScores.Select(t => t.Action).Should().BeEquivalentTo("RePend", "Release", "Deny", "MedReview");
      }
   }
}

