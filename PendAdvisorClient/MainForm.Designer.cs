
namespace PendAdvisorClient
{
   partial class MainForm
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
         System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
         System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 28D);
         System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 24D);
         System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 26D);
         System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 22D);
         this.pnlNavigation = new System.Windows.Forms.Panel();
         this.btnApply = new System.Windows.Forms.Button();
         this.btnClaim = new System.Windows.Forms.Button();
         this.btnAdvice = new System.Windows.Forms.Button();
         this.btnClose = new System.Windows.Forms.Button();
         this.picCaduceus = new System.Windows.Forms.PictureBox();
         this.pnlMain = new System.Windows.Forms.Panel();
         this.lblRecommendation = new System.Windows.Forms.Label();
         this.txtThreshold = new System.Windows.Forms.TextBox();
         this.lblThreshold = new System.Windows.Forms.Label();
         this.chartAdviceScores = new System.Windows.Forms.DataVisualization.Charting.Chart();
         this.pnlTitle = new System.Windows.Forms.Panel();
         this.lblTitle = new System.Windows.Forms.Label();
         this.pnlNavigation.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.picCaduceus)).BeginInit();
         this.pnlMain.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.chartAdviceScores)).BeginInit();
         this.pnlTitle.SuspendLayout();
         this.SuspendLayout();
         // 
         // pnlNavigation
         // 
         this.pnlNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(195)))), ((int)(((byte)(220)))));
         this.pnlNavigation.Controls.Add(this.btnApply);
         this.pnlNavigation.Controls.Add(this.btnClaim);
         this.pnlNavigation.Controls.Add(this.btnAdvice);
         this.pnlNavigation.Controls.Add(this.btnClose);
         this.pnlNavigation.Controls.Add(this.picCaduceus);
         this.pnlNavigation.Dock = System.Windows.Forms.DockStyle.Left;
         this.pnlNavigation.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.pnlNavigation.Location = new System.Drawing.Point(0, 0);
         this.pnlNavigation.Name = "pnlNavigation";
         this.pnlNavigation.Size = new System.Drawing.Size(133, 464);
         this.pnlNavigation.TabIndex = 0;
         // 
         // btnApply
         // 
         this.btnApply.Enabled = false;
         this.btnApply.FlatAppearance.BorderSize = 0;
         this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnApply.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnApply.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(73)))), ((int)(((byte)(120)))));
         this.btnApply.Image = global::PendAdvisorClient.Properties.Resources.thumbs_up_36x36;
         this.btnApply.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
         this.btnApply.Location = new System.Drawing.Point(10, 319);
         this.btnApply.Name = "btnApply";
         this.btnApply.Size = new System.Drawing.Size(113, 52);
         this.btnApply.TabIndex = 4;
         this.btnApply.Text = "Apply";
         this.btnApply.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         this.btnApply.UseVisualStyleBackColor = true;
         // 
         // btnClaim
         // 
         this.btnClaim.FlatAppearance.BorderSize = 0;
         this.btnClaim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnClaim.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnClaim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(73)))), ((int)(((byte)(120)))));
         this.btnClaim.Image = global::PendAdvisorClient.Properties.Resources.pencil_alt_36x36;
         this.btnClaim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
         this.btnClaim.Location = new System.Drawing.Point(10, 179);
         this.btnClaim.Name = "btnClaim";
         this.btnClaim.Size = new System.Drawing.Size(113, 52);
         this.btnClaim.TabIndex = 3;
         this.btnClaim.Text = "Claim";
         this.btnClaim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         this.btnClaim.UseVisualStyleBackColor = true;
         // 
         // btnAdvice
         // 
         this.btnAdvice.FlatAppearance.BorderSize = 0;
         this.btnAdvice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnAdvice.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnAdvice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(73)))), ((int)(((byte)(120)))));
         this.btnAdvice.Image = global::PendAdvisorClient.Properties.Resources.map_signs_36x36;
         this.btnAdvice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
         this.btnAdvice.Location = new System.Drawing.Point(10, 249);
         this.btnAdvice.Name = "btnAdvice";
         this.btnAdvice.Size = new System.Drawing.Size(113, 52);
         this.btnAdvice.TabIndex = 2;
         this.btnAdvice.Text = "Advice";
         this.btnAdvice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         this.btnAdvice.UseVisualStyleBackColor = true;
         this.btnAdvice.Click += new System.EventHandler(this.btnAdvice_Click);
         // 
         // btnClose
         // 
         this.btnClose.FlatAppearance.BorderSize = 0;
         this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnClose.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(73)))), ((int)(((byte)(120)))));
         this.btnClose.Image = global::PendAdvisorClient.Properties.Resources.share_blue_36x36;
         this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
         this.btnClose.Location = new System.Drawing.Point(10, 389);
         this.btnClose.Name = "btnClose";
         this.btnClose.Size = new System.Drawing.Size(113, 52);
         this.btnClose.TabIndex = 1;
         this.btnClose.Text = "Close";
         this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         this.btnClose.UseVisualStyleBackColor = true;
         this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
         // 
         // picCaduceus
         // 
         this.picCaduceus.Image = global::PendAdvisorClient.Properties.Resources.caduceus_blue;
         this.picCaduceus.Location = new System.Drawing.Point(25, 37);
         this.picCaduceus.Name = "picCaduceus";
         this.picCaduceus.Size = new System.Drawing.Size(81, 114);
         this.picCaduceus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.picCaduceus.TabIndex = 0;
         this.picCaduceus.TabStop = false;
         // 
         // pnlMain
         // 
         this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(216)))), ((int)(((byte)(213)))));
         this.pnlMain.Controls.Add(this.lblRecommendation);
         this.pnlMain.Controls.Add(this.txtThreshold);
         this.pnlMain.Controls.Add(this.lblThreshold);
         this.pnlMain.Controls.Add(this.chartAdviceScores);
         this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
         this.pnlMain.Location = new System.Drawing.Point(133, 0);
         this.pnlMain.Name = "pnlMain";
         this.pnlMain.Size = new System.Drawing.Size(667, 464);
         this.pnlMain.TabIndex = 1;
         // 
         // lblRecommendation
         // 
         this.lblRecommendation.AutoSize = true;
         this.lblRecommendation.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblRecommendation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(81)))), ((int)(((byte)(75)))));
         this.lblRecommendation.Location = new System.Drawing.Point(328, 387);
         this.lblRecommendation.MaximumSize = new System.Drawing.Size(330, 0);
         this.lblRecommendation.Name = "lblRecommendation";
         this.lblRecommendation.Size = new System.Drawing.Size(327, 66);
         this.lblRecommendation.TabIndex = 3;
         this.lblRecommendation.Text = "Recommended action is ... with ...% confidence.";
         // 
         // txtThreshold
         // 
         this.txtThreshold.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.txtThreshold.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtThreshold.Location = new System.Drawing.Point(607, 95);
         this.txtThreshold.Name = "txtThreshold";
         this.txtThreshold.Size = new System.Drawing.Size(33, 17);
         this.txtThreshold.TabIndex = 2;
         this.txtThreshold.TextChanged += new System.EventHandler(this.txtThreshold_TextChanged);
         // 
         // lblThreshold
         // 
         this.lblThreshold.AutoSize = true;
         this.lblThreshold.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblThreshold.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(81)))), ((int)(((byte)(75)))));
         this.lblThreshold.Location = new System.Drawing.Point(527, 91);
         this.lblThreshold.Name = "lblThreshold";
         this.lblThreshold.Size = new System.Drawing.Size(74, 23);
         this.lblThreshold.TabIndex = 1;
         this.lblThreshold.Text = "Threshold";
         // 
         // chartAdviceScores
         // 
         this.chartAdviceScores.BackColor = System.Drawing.Color.Transparent;
         chartArea1.AxisX.IsLabelAutoFit = false;
         chartArea1.AxisX.IsMarginVisible = false;
         chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(81)))), ((int)(((byte)(75)))));
         chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(81)))), ((int)(((byte)(75)))));
         chartArea1.AxisX.MajorGrid.Enabled = false;
         chartArea1.AxisX.ScaleBreakStyle.Enabled = true;
         chartArea1.AxisX.Title = "Advice";
         chartArea1.AxisX.TitleFont = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         chartArea1.AxisX.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(81)))), ((int)(((byte)(75)))));
         chartArea1.AxisY.Interval = 25D;
         chartArea1.AxisY.IsLabelAutoFit = false;
         chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(81)))), ((int)(((byte)(75)))));
         chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(81)))), ((int)(((byte)(75)))));
         chartArea1.AxisY.MajorGrid.Enabled = false;
         chartArea1.AxisY.Maximum = 100D;
         chartArea1.AxisY.Minimum = 0D;
         chartArea1.AxisY.MinorGrid.Enabled = true;
         chartArea1.AxisY.MinorGrid.Interval = 100D;
         chartArea1.AxisY.MinorGrid.IntervalOffset = 50D;
         chartArea1.AxisY.MinorGrid.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
         chartArea1.AxisY.MinorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
         chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(81)))), ((int)(((byte)(75)))));
         chartArea1.AxisY.Title = "Score";
         chartArea1.AxisY.TitleFont = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         chartArea1.AxisY.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(81)))), ((int)(((byte)(75)))));
         chartArea1.BackColor = System.Drawing.Color.Transparent;
         chartArea1.Name = "ChartArea1";
         this.chartAdviceScores.ChartAreas.Add(chartArea1);
         this.chartAdviceScores.Location = new System.Drawing.Point(296, 118);
         this.chartAdviceScores.Name = "chartAdviceScores";
         series1.ChartArea = "ChartArea1";
         series1.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         series1.IsValueShownAsLabel = true;
         series1.Name = "Series1";
         dataPoint1.AxisLabel = "Release";
         dataPoint1.Color = System.Drawing.Color.Green;
         dataPoint1.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         dataPoint1.IsValueShownAsLabel = true;
         dataPoint1.Label = "";
         dataPoint1.LabelForeColor = System.Drawing.Color.DarkGreen;
         dataPoint1.LabelFormat = "";
         dataPoint2.AxisLabel = "Deny";
         dataPoint2.Color = System.Drawing.Color.Firebrick;
         dataPoint2.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         dataPoint2.Label = "";
         dataPoint2.LabelForeColor = System.Drawing.Color.DarkRed;
         dataPoint3.AxisLabel = "Reprocess";
         dataPoint3.Color = System.Drawing.Color.Orange;
         dataPoint3.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         dataPoint3.Label = "";
         dataPoint3.LabelForeColor = System.Drawing.Color.Peru;
         dataPoint4.AxisLabel = "MedReview";
         dataPoint4.Color = System.Drawing.Color.RoyalBlue;
         dataPoint4.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         dataPoint4.Label = "";
         dataPoint4.LabelForeColor = System.Drawing.Color.MediumBlue;
         series1.Points.Add(dataPoint1);
         series1.Points.Add(dataPoint2);
         series1.Points.Add(dataPoint3);
         series1.Points.Add(dataPoint4);
         series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
         series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Single;
         this.chartAdviceScores.Series.Add(series1);
         this.chartAdviceScores.Size = new System.Drawing.Size(368, 266);
         this.chartAdviceScores.TabIndex = 0;
         this.chartAdviceScores.Text = "chart1";
         // 
         // pnlTitle
         // 
         this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(136)))), ((int)(((byte)(130)))));
         this.pnlTitle.Controls.Add(this.lblTitle);
         this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
         this.pnlTitle.Location = new System.Drawing.Point(133, 0);
         this.pnlTitle.Name = "pnlTitle";
         this.pnlTitle.Size = new System.Drawing.Size(667, 70);
         this.pnlTitle.TabIndex = 2;
         // 
         // lblTitle
         // 
         this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
         this.lblTitle.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblTitle.ForeColor = System.Drawing.Color.White;
         this.lblTitle.Location = new System.Drawing.Point(0, 0);
         this.lblTitle.Name = "lblTitle";
         this.lblTitle.Size = new System.Drawing.Size(667, 70);
         this.lblTitle.TabIndex = 0;
         this.lblTitle.Text = "PendAdvisor Client";
         this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTitle_MouseDown);
         // 
         // MainForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.Fuchsia;
         this.ClientSize = new System.Drawing.Size(800, 464);
         this.ControlBox = false;
         this.Controls.Add(this.pnlTitle);
         this.Controls.Add(this.pnlMain);
         this.Controls.Add(this.pnlNavigation);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.Name = "MainForm";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.pnlNavigation.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.picCaduceus)).EndInit();
         this.pnlMain.ResumeLayout(false);
         this.pnlMain.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.chartAdviceScores)).EndInit();
         this.pnlTitle.ResumeLayout(false);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Panel pnlNavigation;
      private System.Windows.Forms.Panel pnlMain;
      private System.Windows.Forms.Panel pnlTitle;
      private System.Windows.Forms.Label lblTitle;
      private System.Windows.Forms.PictureBox picCaduceus;
      private System.Windows.Forms.Button btnClose;
      private System.Windows.Forms.Button btnAdvice;
      private System.Windows.Forms.Button btnApply;
      private System.Windows.Forms.Button btnClaim;
      private System.Windows.Forms.DataVisualization.Charting.Chart chartAdviceScores;
      private System.Windows.Forms.Label lblThreshold;
      private System.Windows.Forms.TextBox txtThreshold;
      private System.Windows.Forms.Label lblRecommendation;
   }
}

