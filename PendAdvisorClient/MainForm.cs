using Newtonsoft.Json;
using PendAdvisorModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PendAdvisorClient
{
   public partial class MainForm : Form
   {
      //Support moving borderless form
      public const int WM_NCLBUTTONDOWN = 0xA1;
      public const int HT_CAPTION = 0x2;
      [DllImportAttribute("user32.dll")]
      public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
      [DllImportAttribute("user32.dll")]
      public static extern bool ReleaseCapture();

      public MainForm()
      {
         InitializeComponent();

         txtThreshold.Text = "90";
         Scores = new double[] { 96D, 2D, 1D, 1D };
         Scores = new double[] { 20D, 25D, 10D, 35D };
         ////Scores = null;
      }


      /// <summary>
      /// Write-only property containing 4 score values for Release, Deny, Reprocess & MedReview respectively.
      /// Setting this property populated the grid.
      /// Can be set to null, whcih means reset.
      /// </summary>
      private double[] Scores
      {
         set
         {
            // 0-Release, 1-Deny, 2-Reprocess, 3-MedReview
            double[] valuesToAssign;
            Debug.Assert(value == null || value.Count() == 4);
            Debug.Assert(value == null || value.Sum() - 100D < .001);
            if (value == null)
            {
               valuesToAssign = new double[] { 0D, 0D, 0D, 0D };
               chartAdviceScores.Series[0].Points[0].SetValueY(0D);
               lblRecommendation.Text = string.Empty;
               picMLBrain.Visible = true;

            }
            else
            {
               valuesToAssign = value;
               var topIndex = valuesToAssign.ToList().IndexOf(valuesToAssign.Max());
               lblRecommendation.Text = $"Recommended action is {new List<string>{ "Release", "Deny", "Reprocess", "MedReview" }[topIndex]} with {valuesToAssign[topIndex]:#0.0}% confidence.";
               picMLBrain.Visible = false;
            }
            var pointsToSet = chartAdviceScores.Series[0].Points;
            for (var i = 0; i < 4; i++) pointsToSet[i].SetValueY(valuesToAssign[i]);
         }
      }


      /// <summary>
      /// Expose form controls holding claim data as model input (to be serialized as JSON).
      /// Get retries model input from the form; set populates for with model input data (null to reset contents).
      /// </summary>
      private ModelInput ClaimData
      {
         get
         {
            return new ModelInput
            {
               MemberID = txtMemberID.Text,
               ClaimID = txtClaimID.Text,
               DateReceived = txtDateReceived.Text,
               providerNPI = txtProviderNPI.Text,
               Diagnosis1 = txtDiagnosis1.Text,
               Diagnosis2 = txtDiagnosis2.Text,
               POS = txtPOS.Text,
               ProcedureCode = txtProcedureCode.Text,
               Units = float.Parse(txtUnits.Text),
               Price = float.Parse(txtPrice.Text),
               PendReason = txtPendReason.Text
            };
         }
         set
         {
            txtMemberID.Text = value?.MemberID;
            txtClaimID.Text = value?.ClaimID;
            txtDateReceived.Text = value?.DateReceived;
            txtProviderNPI.Text = value?.providerNPI;
            txtDiagnosis1.Text = value?.Diagnosis1;
            txtDiagnosis2.Text = value?.Diagnosis2;
            txtPOS.Text = value?.POS;
            txtProcedureCode.Text = value?.ProcedureCode;
            txtUnits.Text = value?.Units.ToString();
            txtPrice.Text = value?.Price.ToString();
            txtPendReason.Text = value?.PendReason;
         }
      }


      private void lblTitle_MouseDown(object sender, MouseEventArgs e)
      {
         //Move borderless form
         ReleaseCapture();
         SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
      }

      private void btnClose_Click(object sender, EventArgs e)
      {
         this.Close();
      }

      private async void btnAdvice_Click(object sender, EventArgs e)
      {
         var adviceJson = await MlService.ObtainPendAdviceAsync(JsonConvert.SerializeObject(ClaimData));
         if (adviceJson == null)
         {
            MessageBox.Show("Sorry, PendAdvisor service call failed!", "PendAdvisor Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
         }
         var advice = JsonConvert.DeserializeObject<ModelOutput>(adviceJson);
         ////Scores = new double[]
         ////         {
         ////            advice.ActionsAndScores.First(t => t.Action == "Release").Score,
         ////            advice.ActionsAndScores.First(t => t.Action == "Deny").Score,
         ////            advice.ActionsAndScores.First(t => t.Action == "Reprocess").Score,
         ////            advice.ActionsAndScores.First(t => t.Action == "MedReview").Score
         ////         };
         
         ////Scores = new double[]
         //// {
         ////            advice.Scores[0],
         ////            advice.Scores[1],
         ////            advice.Scores[2],
         ////            advice.Scores[3]
         //// };

         Scores = advice.Scores.Select(s => (double)s).ToArray();

     ///    btnClose.Enabled = advice.ActionsAndScores[0].Score > float.Parse(txtThreshold.Text);
      }

      private void txtThreshold_TextChanged(object sender, EventArgs e)
      {
         if (double.TryParse((txtThreshold.Text), out var threshold))
         {
            this.chartAdviceScores.ChartAreas[0].AxisY.MinorGrid.IntervalOffset = threshold;
         }
      }

      private void flowpnlClaimData_DragEnter(object sender, DragEventArgs e)
      {
         if (e.Data.GetDataPresent(DataFormats.FileDrop))
         {
            e.Effect = DragDropEffects.Copy;
            _dropFormatIsFile = true;
         }
         else if (e.Data.GetDataPresent(DataFormats.Text))
         {
            e.Effect = DragDropEffects.Copy;
            _dropFormatIsFile = false;
         }
         else
                  e.Effect = DragDropEffects.None;
      }

      private bool _dropFormatIsFile;

      private void flowpnlClaimData_DragDrop(object sender, DragEventArgs e)
      {
         string jsonClaimData;
         if (_dropFormatIsFile)
         {
            var x = e.Data.GetData(DataFormats.FileDrop);
            using (var reader = File.OpenText(((string[])e.Data.GetData(DataFormats.FileDrop))[0]))
            {
               jsonClaimData = reader.ReadToEnd();
            }
         }
         else //text dropped directly 
            jsonClaimData = e.Data.GetData(DataFormats.Text).ToString();

         ClaimData = JsonConvert.DeserializeObject<ModelInput>(jsonClaimData);
      }

      private void btnClaim_Click(object sender, EventArgs e)
      {
         ClaimData = null;
      }

      private void btnApply_Click(object sender, EventArgs e)
      {
         throw new NotImplementedException();
      }
   }
}
