using System;
using System.Collections.Generic;
using System.Diagnostics;
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
         ////Scores = new double[] { 96D, 2D, 1D, 1D};
         Scores = null;
      }


      /// <summary>
      /// Write only property containing 4 score values for Release, Deny, Reprocess & MedReview respectively.
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
            }
            else
            {
               valuesToAssign = value;
               var topIndex = valuesToAssign.ToList().IndexOf(valuesToAssign.Max());
               lblRecommendation.Text = $"Recommended action is {new List<string>{ "Release", "Deny", "Reprocess", "MedReview" }[topIndex]} with {valuesToAssign[topIndex]:#0.0}% confidence.";
            }
            var pointsToSet = chartAdviceScores.Series[0].Points;
            for (var i = 0; i < 4; i++) pointsToSet[i].SetValueY(valuesToAssign[i]);
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

      private void btnAdvice_Click(object sender, EventArgs e)
      {
         btnClose.Enabled = !btnClose.Enabled;
      }

      private void txtThreshold_TextChanged(object sender, EventArgs e)
      {
         if (double.TryParse((txtThreshold.Text), out var threshold))
         {
            this.chartAdviceScores.ChartAreas[0].AxisY.MinorGrid.IntervalOffset = threshold;
         }
      }

   }
}
