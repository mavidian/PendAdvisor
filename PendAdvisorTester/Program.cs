using PendAdvisorModel;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace PendAdvisorTester
{
   class Program
   {
      private static readonly char sep = Path.DirectorySeparatorChar;
      private static readonly string _fileName = "claimsTest1";
   
      static void Main(string[] args)
      {
         var inputFile = $"..{sep}..{sep}..{sep}Data{sep}{_fileName}.csv";
         var outputFile = $"{_fileName}_withActions.csv";

         Console.WriteLine($"{DateTime.Now} Testing the ML model by calling the Web API for a set of test claims...");
         Console.WriteLine($"Input file containing test claims: {Path.GetFullPath(inputFile)}");
         Console.WriteLine($"Output file with added predicted actions: {Path.GetFullPath(outputFile)}");


         using (var reader = File.OpenText(inputFile))
         using (var writer = File.CreateText(outputFile))
         {
            string currLine;
            bool currLineIsHeader = true;
            // currentLine will be null when the StreamReader reaches the end of file
            while ((currLine = reader.ReadLine()) != null)
            {
               if (currLineIsHeader)
               {
                  const string expectedHeader = "MemberID,ClaimID,DateReceived,providerNPI,Diagnosis1,Diagnosis2,POS,ProcedureCode,Units,Price,PendReason,Action,Status";
                  Debug.Assert(currLine == expectedHeader);
                  writer.WriteLine(currLine + ",ActionScore,ReleaseScore,DenyScore,ReprocessScore,MedReviewScore"); // the actual prediction will be placed in Action column (11)
                  currLineIsHeader = false;
                  continue;
               }

               var elems = currLine.Split(',').ToList();
               Debug.Assert(elems.Count == 13);
               var modelInput = new ModelInput()
               {
                  Diagnosis1 = elems[4],
                  Diagnosis2 = elems[5],
                  POS = elems[6],
                  ProcedureCode = elems[7],
                  Units = int.Parse(elems[8]),
                  Price = float.Parse(elems[9]),
                  PendReason = elems[10]
               };
               var predictedOutput = PendPredictor.PredictEx(modelInput);
               elems[11] = predictedOutput.Action;
               elems.Add(GetScoreForAction(predictedOutput, predictedOutput.Action));
               elems.Add(GetScoreForAction(predictedOutput, "Release"));
               elems.Add(GetScoreForAction(predictedOutput, "Deny"));
               elems.Add(GetScoreForAction(predictedOutput, "Reprocess"));
               elems.Add(GetScoreForAction(predictedOutput, "MedReview"));
               writer.WriteLine(string.Join(',', elems.ToArray()));
            }
         }


         Console.WriteLine();
         Console.WriteLine($"{DateTime.Now} ALL DONE!");

         if (Debugger.IsAttached)
         {
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey();
         }
      }


      private static string GetScoreForAction(ModelOutputEx modelOutput, string predictedAction)
      {
         return modelOutput.ActionsAndScores.First(t => t.Action == predictedAction).Score.ToString("n1"); // 1 decimal place
      }
   }
}
