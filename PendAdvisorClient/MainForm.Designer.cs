
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
         System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 26.2D);
         System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 24D);
         System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 21.8D);
         this.pnlNavigation = new System.Windows.Forms.Panel();
         this.btnApply = new System.Windows.Forms.Button();
         this.btnStart = new System.Windows.Forms.Button();
         this.btnAdvise = new System.Windows.Forms.Button();
         this.btnClose = new System.Windows.Forms.Button();
         this.picCaduceus = new System.Windows.Forms.PictureBox();
         this.pnlMain = new System.Windows.Forms.Panel();
         this.flowpnlClaimData = new System.Windows.Forms.FlowLayoutPanel();
         this.lblMemberID = new System.Windows.Forms.Label();
         this.txtMemberID = new System.Windows.Forms.TextBox();
         this.lblClaimID = new System.Windows.Forms.Label();
         this.txtClaimID = new System.Windows.Forms.TextBox();
         this.lblDateReceived = new System.Windows.Forms.Label();
         this.txtDateReceived = new System.Windows.Forms.TextBox();
         this.lblProviderNPI = new System.Windows.Forms.Label();
         this.txtProviderNPI = new System.Windows.Forms.TextBox();
         this.lblDiagnosis1 = new System.Windows.Forms.Label();
         this.txtDiagnosis1 = new System.Windows.Forms.TextBox();
         this.lblDiagnosis2 = new System.Windows.Forms.Label();
         this.txtDiagnosis2 = new System.Windows.Forms.TextBox();
         this.lblPOS = new System.Windows.Forms.Label();
         this.txtPOS = new System.Windows.Forms.TextBox();
         this.lblProcedureCode = new System.Windows.Forms.Label();
         this.txtProcedureCode = new System.Windows.Forms.TextBox();
         this.lblUnits = new System.Windows.Forms.Label();
         this.txtUnits = new System.Windows.Forms.TextBox();
         this.lblPrice = new System.Windows.Forms.Label();
         this.txtPrice = new System.Windows.Forms.TextBox();
         this.lblPendReason = new System.Windows.Forms.Label();
         this.txtPendReason = new System.Windows.Forms.TextBox();
         this.picMLBrain = new System.Windows.Forms.PictureBox();
         this.lblRecommendation = new System.Windows.Forms.Label();
         this.txtThreshold = new System.Windows.Forms.TextBox();
         this.lblThreshold = new System.Windows.Forms.Label();
         this.chartAdviceScores = new System.Windows.Forms.DataVisualization.Charting.Chart();
         this.pnlTitle = new System.Windows.Forms.Panel();
         this.lblTitle = new System.Windows.Forms.Label();
         this.pnlNavigation.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.picCaduceus)).BeginInit();
         this.pnlMain.SuspendLayout();
         this.flowpnlClaimData.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.picMLBrain)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.chartAdviceScores)).BeginInit();
         this.pnlTitle.SuspendLayout();
         this.SuspendLayout();
         // 
         // pnlNavigation
         // 
         this.pnlNavigation.BackColor = System.Drawing.Color.WhiteSmoke;
         this.pnlNavigation.Controls.Add(this.btnApply);
         this.pnlNavigation.Controls.Add(this.btnStart);
         this.pnlNavigation.Controls.Add(this.btnAdvise);
         this.pnlNavigation.Controls.Add(this.btnClose);
         this.pnlNavigation.Controls.Add(this.picCaduceus);
         this.pnlNavigation.Dock = System.Windows.Forms.DockStyle.Left;
         this.pnlNavigation.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.pnlNavigation.Location = new System.Drawing.Point(0, 0);
         this.pnlNavigation.Name = "pnlNavigation";
         this.pnlNavigation.Size = new System.Drawing.Size(133, 465);
         this.pnlNavigation.TabIndex = 0;
         // 
         // btnApply
         // 
         this.btnApply.Enabled = false;
         this.btnApply.FlatAppearance.BorderSize = 0;
         this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnApply.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
         this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
         // 
         // btnStart
         // 
         this.btnStart.FlatAppearance.BorderSize = 0;
         this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnStart.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(73)))), ((int)(((byte)(120)))));
         this.btnStart.Image = global::PendAdvisorClient.Properties.Resources.pencil_alt_36x36;
         this.btnStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
         this.btnStart.Location = new System.Drawing.Point(10, 179);
         this.btnStart.Name = "btnStart";
         this.btnStart.Size = new System.Drawing.Size(113, 52);
         this.btnStart.TabIndex = 3;
         this.btnStart.Text = "Start";
         this.btnStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         this.btnStart.UseVisualStyleBackColor = true;
         this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
         // 
         // btnAdvise
         // 
         this.btnAdvise.FlatAppearance.BorderSize = 0;
         this.btnAdvise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnAdvise.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnAdvise.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(73)))), ((int)(((byte)(120)))));
         this.btnAdvise.Image = global::PendAdvisorClient.Properties.Resources.map_signs_36x36;
         this.btnAdvise.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
         this.btnAdvise.Location = new System.Drawing.Point(10, 249);
         this.btnAdvise.Name = "btnAdvise";
         this.btnAdvise.Size = new System.Drawing.Size(113, 52);
         this.btnAdvise.TabIndex = 2;
         this.btnAdvise.Text = "Advise";
         this.btnAdvise.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         this.btnAdvise.UseVisualStyleBackColor = true;
         this.btnAdvise.Click += new System.EventHandler(this.btnAdvise_Click);
         // 
         // btnClose
         // 
         this.btnClose.FlatAppearance.BorderSize = 0;
         this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnClose.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
         this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(204)))));
         this.pnlMain.Controls.Add(this.flowpnlClaimData);
         this.pnlMain.Controls.Add(this.picMLBrain);
         this.pnlMain.Controls.Add(this.lblRecommendation);
         this.pnlMain.Controls.Add(this.txtThreshold);
         this.pnlMain.Controls.Add(this.lblThreshold);
         this.pnlMain.Controls.Add(this.chartAdviceScores);
         this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
         this.pnlMain.Location = new System.Drawing.Point(133, 0);
         this.pnlMain.Name = "pnlMain";
         this.pnlMain.Size = new System.Drawing.Size(640, 465);
         this.pnlMain.TabIndex = 1;
         // 
         // flowpnlClaimData
         // 
         this.flowpnlClaimData.AllowDrop = true;
         this.flowpnlClaimData.Controls.Add(this.lblMemberID);
         this.flowpnlClaimData.Controls.Add(this.txtMemberID);
         this.flowpnlClaimData.Controls.Add(this.lblClaimID);
         this.flowpnlClaimData.Controls.Add(this.txtClaimID);
         this.flowpnlClaimData.Controls.Add(this.lblDateReceived);
         this.flowpnlClaimData.Controls.Add(this.txtDateReceived);
         this.flowpnlClaimData.Controls.Add(this.lblProviderNPI);
         this.flowpnlClaimData.Controls.Add(this.txtProviderNPI);
         this.flowpnlClaimData.Controls.Add(this.lblDiagnosis1);
         this.flowpnlClaimData.Controls.Add(this.txtDiagnosis1);
         this.flowpnlClaimData.Controls.Add(this.lblDiagnosis2);
         this.flowpnlClaimData.Controls.Add(this.txtDiagnosis2);
         this.flowpnlClaimData.Controls.Add(this.lblPOS);
         this.flowpnlClaimData.Controls.Add(this.txtPOS);
         this.flowpnlClaimData.Controls.Add(this.lblProcedureCode);
         this.flowpnlClaimData.Controls.Add(this.txtProcedureCode);
         this.flowpnlClaimData.Controls.Add(this.lblUnits);
         this.flowpnlClaimData.Controls.Add(this.txtUnits);
         this.flowpnlClaimData.Controls.Add(this.lblPrice);
         this.flowpnlClaimData.Controls.Add(this.txtPrice);
         this.flowpnlClaimData.Controls.Add(this.lblPendReason);
         this.flowpnlClaimData.Controls.Add(this.txtPendReason);
         this.flowpnlClaimData.Location = new System.Drawing.Point(27, 85);
         this.flowpnlClaimData.Name = "flowpnlClaimData";
         this.flowpnlClaimData.Size = new System.Drawing.Size(235, 376);
         this.flowpnlClaimData.TabIndex = 27;
         this.flowpnlClaimData.DragDrop += new System.Windows.Forms.DragEventHandler(this.flowpnlClaimData_DragDrop);
         this.flowpnlClaimData.DragEnter += new System.Windows.Forms.DragEventHandler(this.flowpnlClaimData_DragEnter);
         // 
         // lblMemberID
         // 
         this.lblMemberID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblMemberID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(81)))), ((int)(((byte)(75)))));
         this.lblMemberID.Location = new System.Drawing.Point(3, 0);
         this.lblMemberID.Margin = new System.Windows.Forms.Padding(3, 0, 3, 8);
         this.lblMemberID.Name = "lblMemberID";
         this.lblMemberID.Size = new System.Drawing.Size(110, 26);
         this.lblMemberID.TabIndex = 6;
         this.lblMemberID.Text = "MemberID";
         this.lblMemberID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         // 
         // txtMemberID
         // 
         this.txtMemberID.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.txtMemberID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtMemberID.Location = new System.Drawing.Point(119, 3);
         this.txtMemberID.Name = "txtMemberID";
         this.txtMemberID.Size = new System.Drawing.Size(84, 17);
         this.txtMemberID.TabIndex = 7;
         // 
         // lblClaimID
         // 
         this.lblClaimID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblClaimID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(81)))), ((int)(((byte)(75)))));
         this.lblClaimID.Location = new System.Drawing.Point(3, 34);
         this.lblClaimID.Margin = new System.Windows.Forms.Padding(3, 0, 3, 8);
         this.lblClaimID.Name = "lblClaimID";
         this.lblClaimID.Size = new System.Drawing.Size(110, 26);
         this.lblClaimID.TabIndex = 8;
         this.lblClaimID.Text = "ClaimID";
         this.lblClaimID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         // 
         // txtClaimID
         // 
         this.txtClaimID.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.txtClaimID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtClaimID.Location = new System.Drawing.Point(119, 37);
         this.txtClaimID.Name = "txtClaimID";
         this.txtClaimID.Size = new System.Drawing.Size(104, 17);
         this.txtClaimID.TabIndex = 9;
         // 
         // lblDateReceived
         // 
         this.lblDateReceived.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblDateReceived.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(81)))), ((int)(((byte)(75)))));
         this.lblDateReceived.Location = new System.Drawing.Point(3, 68);
         this.lblDateReceived.Margin = new System.Windows.Forms.Padding(3, 0, 3, 8);
         this.lblDateReceived.Name = "lblDateReceived";
         this.lblDateReceived.Size = new System.Drawing.Size(110, 26);
         this.lblDateReceived.TabIndex = 10;
         this.lblDateReceived.Text = "DateReceived";
         this.lblDateReceived.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         // 
         // txtDateReceived
         // 
         this.txtDateReceived.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.txtDateReceived.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtDateReceived.Location = new System.Drawing.Point(119, 71);
         this.txtDateReceived.Name = "txtDateReceived";
         this.txtDateReceived.Size = new System.Drawing.Size(70, 17);
         this.txtDateReceived.TabIndex = 11;
         // 
         // lblProviderNPI
         // 
         this.lblProviderNPI.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblProviderNPI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(81)))), ((int)(((byte)(75)))));
         this.lblProviderNPI.Location = new System.Drawing.Point(3, 102);
         this.lblProviderNPI.Margin = new System.Windows.Forms.Padding(3, 0, 3, 8);
         this.lblProviderNPI.Name = "lblProviderNPI";
         this.lblProviderNPI.Size = new System.Drawing.Size(110, 26);
         this.lblProviderNPI.TabIndex = 12;
         this.lblProviderNPI.Text = "providerNPI";
         this.lblProviderNPI.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         // 
         // txtProviderNPI
         // 
         this.txtProviderNPI.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.txtProviderNPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtProviderNPI.Location = new System.Drawing.Point(119, 105);
         this.txtProviderNPI.Name = "txtProviderNPI";
         this.txtProviderNPI.Size = new System.Drawing.Size(88, 17);
         this.txtProviderNPI.TabIndex = 13;
         // 
         // lblDiagnosis1
         // 
         this.lblDiagnosis1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblDiagnosis1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(81)))), ((int)(((byte)(75)))));
         this.lblDiagnosis1.Location = new System.Drawing.Point(3, 136);
         this.lblDiagnosis1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 8);
         this.lblDiagnosis1.Name = "lblDiagnosis1";
         this.lblDiagnosis1.Size = new System.Drawing.Size(110, 26);
         this.lblDiagnosis1.TabIndex = 14;
         this.lblDiagnosis1.Text = "Diagnosis1";
         this.lblDiagnosis1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         // 
         // txtDiagnosis1
         // 
         this.txtDiagnosis1.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.txtDiagnosis1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtDiagnosis1.Location = new System.Drawing.Point(119, 139);
         this.txtDiagnosis1.Name = "txtDiagnosis1";
         this.txtDiagnosis1.Size = new System.Drawing.Size(33, 17);
         this.txtDiagnosis1.TabIndex = 15;
         // 
         // lblDiagnosis2
         // 
         this.lblDiagnosis2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblDiagnosis2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(81)))), ((int)(((byte)(75)))));
         this.lblDiagnosis2.Location = new System.Drawing.Point(3, 170);
         this.lblDiagnosis2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 8);
         this.lblDiagnosis2.Name = "lblDiagnosis2";
         this.lblDiagnosis2.Size = new System.Drawing.Size(110, 26);
         this.lblDiagnosis2.TabIndex = 16;
         this.lblDiagnosis2.Text = "Diagnosis2";
         this.lblDiagnosis2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         // 
         // txtDiagnosis2
         // 
         this.txtDiagnosis2.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.txtDiagnosis2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtDiagnosis2.Location = new System.Drawing.Point(119, 173);
         this.txtDiagnosis2.Name = "txtDiagnosis2";
         this.txtDiagnosis2.Size = new System.Drawing.Size(33, 17);
         this.txtDiagnosis2.TabIndex = 17;
         // 
         // lblPOS
         // 
         this.lblPOS.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblPOS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(81)))), ((int)(((byte)(75)))));
         this.lblPOS.Location = new System.Drawing.Point(3, 204);
         this.lblPOS.Margin = new System.Windows.Forms.Padding(3, 0, 3, 8);
         this.lblPOS.Name = "lblPOS";
         this.lblPOS.Size = new System.Drawing.Size(110, 26);
         this.lblPOS.TabIndex = 18;
         this.lblPOS.Text = "POS";
         this.lblPOS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         // 
         // txtPOS
         // 
         this.txtPOS.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.txtPOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtPOS.Location = new System.Drawing.Point(119, 207);
         this.txtPOS.Name = "txtPOS";
         this.txtPOS.Size = new System.Drawing.Size(22, 17);
         this.txtPOS.TabIndex = 19;
         // 
         // lblProcedureCode
         // 
         this.lblProcedureCode.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblProcedureCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(81)))), ((int)(((byte)(75)))));
         this.lblProcedureCode.Location = new System.Drawing.Point(3, 238);
         this.lblProcedureCode.Margin = new System.Windows.Forms.Padding(3, 0, 3, 8);
         this.lblProcedureCode.Name = "lblProcedureCode";
         this.lblProcedureCode.Size = new System.Drawing.Size(110, 26);
         this.lblProcedureCode.TabIndex = 20;
         this.lblProcedureCode.Text = "ProcedureCode";
         this.lblProcedureCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         // 
         // txtProcedureCode
         // 
         this.txtProcedureCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.txtProcedureCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtProcedureCode.Location = new System.Drawing.Point(119, 241);
         this.txtProcedureCode.Name = "txtProcedureCode";
         this.txtProcedureCode.Size = new System.Drawing.Size(48, 17);
         this.txtProcedureCode.TabIndex = 21;
         // 
         // lblUnits
         // 
         this.lblUnits.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblUnits.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(81)))), ((int)(((byte)(75)))));
         this.lblUnits.Location = new System.Drawing.Point(3, 272);
         this.lblUnits.Margin = new System.Windows.Forms.Padding(3, 0, 3, 8);
         this.lblUnits.Name = "lblUnits";
         this.lblUnits.Size = new System.Drawing.Size(110, 26);
         this.lblUnits.TabIndex = 22;
         this.lblUnits.Text = "Units";
         this.lblUnits.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         // 
         // txtUnits
         // 
         this.txtUnits.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.txtUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtUnits.Location = new System.Drawing.Point(119, 275);
         this.txtUnits.Name = "txtUnits";
         this.txtUnits.Size = new System.Drawing.Size(22, 17);
         this.txtUnits.TabIndex = 23;
         // 
         // lblPrice
         // 
         this.lblPrice.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(81)))), ((int)(((byte)(75)))));
         this.lblPrice.Location = new System.Drawing.Point(3, 306);
         this.lblPrice.Margin = new System.Windows.Forms.Padding(3, 0, 3, 8);
         this.lblPrice.Name = "lblPrice";
         this.lblPrice.Size = new System.Drawing.Size(110, 26);
         this.lblPrice.TabIndex = 24;
         this.lblPrice.Text = "Price";
         this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         // 
         // txtPrice
         // 
         this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtPrice.Location = new System.Drawing.Point(119, 309);
         this.txtPrice.Name = "txtPrice";
         this.txtPrice.Size = new System.Drawing.Size(46, 17);
         this.txtPrice.TabIndex = 25;
         // 
         // lblPendReason
         // 
         this.lblPendReason.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblPendReason.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(81)))), ((int)(((byte)(75)))));
         this.lblPendReason.Location = new System.Drawing.Point(3, 340);
         this.lblPendReason.Margin = new System.Windows.Forms.Padding(3, 0, 3, 8);
         this.lblPendReason.Name = "lblPendReason";
         this.lblPendReason.Size = new System.Drawing.Size(110, 26);
         this.lblPendReason.TabIndex = 26;
         this.lblPendReason.Text = "PendReason";
         this.lblPendReason.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         // 
         // txtPendReason
         // 
         this.txtPendReason.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.txtPendReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtPendReason.Location = new System.Drawing.Point(119, 343);
         this.txtPendReason.Name = "txtPendReason";
         this.txtPendReason.Size = new System.Drawing.Size(46, 17);
         this.txtPendReason.TabIndex = 27;
         // 
         // picMLBrain
         // 
         this.picMLBrain.Image = global::PendAdvisorClient.Properties.Resources.ML_brain_lite_green;
         this.picMLBrain.Location = new System.Drawing.Point(410, 187);
         this.picMLBrain.Name = "picMLBrain";
         this.picMLBrain.Size = new System.Drawing.Size(127, 107);
         this.picMLBrain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.picMLBrain.TabIndex = 4;
         this.picMLBrain.TabStop = false;
         // 
         // lblRecommendation
         // 
         this.lblRecommendation.AutoSize = true;
         this.lblRecommendation.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblRecommendation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(81)))), ((int)(((byte)(75)))));
         this.lblRecommendation.Location = new System.Drawing.Point(281, 389);
         this.lblRecommendation.MaximumSize = new System.Drawing.Size(340, 0);
         this.lblRecommendation.Name = "lblRecommendation";
         this.lblRecommendation.Size = new System.Drawing.Size(339, 44);
         this.lblRecommendation.TabIndex = 3;
         this.lblRecommendation.Text = "Recommended action is ... with ...% confidence.";
         // 
         // txtThreshold
         // 
         this.txtThreshold.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.txtThreshold.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtThreshold.Location = new System.Drawing.Point(559, 88);
         this.txtThreshold.Name = "txtThreshold";
         this.txtThreshold.Size = new System.Drawing.Size(24, 17);
         this.txtThreshold.TabIndex = 2;
         this.txtThreshold.TextChanged += new System.EventHandler(this.txtThreshold_TextChanged);
         // 
         // lblThreshold
         // 
         this.lblThreshold.AutoSize = true;
         this.lblThreshold.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblThreshold.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(81)))), ((int)(((byte)(75)))));
         this.lblThreshold.Location = new System.Drawing.Point(481, 88);
         this.lblThreshold.Name = "lblThreshold";
         this.lblThreshold.Size = new System.Drawing.Size(72, 15);
         this.lblThreshold.TabIndex = 1;
         this.lblThreshold.Text = "Threshold";
         // 
         // chartAdviceScores
         // 
         this.chartAdviceScores.BackColor = System.Drawing.Color.Transparent;
         chartArea1.AxisX.IsLabelAutoFit = false;
         chartArea1.AxisX.IsMarginVisible = false;
         chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(81)))), ((int)(((byte)(75)))));
         chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(81)))), ((int)(((byte)(75)))));
         chartArea1.AxisX.MajorGrid.Enabled = false;
         chartArea1.AxisX.ScaleBreakStyle.Enabled = true;
         chartArea1.AxisX.Title = "Advice";
         chartArea1.AxisX.TitleFont = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         chartArea1.AxisX.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(81)))), ((int)(((byte)(75)))));
         chartArea1.AxisY.Interval = 25D;
         chartArea1.AxisY.IsLabelAutoFit = false;
         chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
         chartArea1.AxisY.TitleFont = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         chartArea1.AxisY.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(81)))), ((int)(((byte)(75)))));
         chartArea1.BackColor = System.Drawing.Color.Transparent;
         chartArea1.Name = "ChartArea1";
         this.chartAdviceScores.ChartAreas.Add(chartArea1);
         this.chartAdviceScores.Location = new System.Drawing.Point(248, 111);
         this.chartAdviceScores.Name = "chartAdviceScores";
         series1.ChartArea = "ChartArea1";
         series1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         series1.IsValueShownAsLabel = true;
         series1.Name = "Series1";
         dataPoint1.AxisLabel = "Release";
         dataPoint1.Color = System.Drawing.Color.Green;
         dataPoint1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         dataPoint1.IsValueShownAsLabel = true;
         dataPoint1.Label = "";
         dataPoint1.LabelForeColor = System.Drawing.Color.DarkGreen;
         dataPoint1.LabelFormat = "#0.0";
         dataPoint2.AxisLabel = "Deny";
         dataPoint2.Color = System.Drawing.Color.Firebrick;
         dataPoint2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         dataPoint2.Label = "";
         dataPoint2.LabelForeColor = System.Drawing.Color.DarkRed;
         dataPoint2.LabelFormat = "#0.0";
         dataPoint3.AxisLabel = "Reprocess";
         dataPoint3.Color = System.Drawing.Color.Orange;
         dataPoint3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         dataPoint3.Label = "";
         dataPoint3.LabelForeColor = System.Drawing.Color.Peru;
         dataPoint3.LabelFormat = "#0.0";
         dataPoint4.AxisLabel = "MedReview";
         dataPoint4.Color = System.Drawing.Color.RoyalBlue;
         dataPoint4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         dataPoint4.Label = "";
         dataPoint4.LabelForeColor = System.Drawing.Color.MediumBlue;
         dataPoint4.LabelFormat = "#0.0";
         series1.Points.Add(dataPoint1);
         series1.Points.Add(dataPoint2);
         series1.Points.Add(dataPoint3);
         series1.Points.Add(dataPoint4);
         series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
         series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Single;
         this.chartAdviceScores.Series.Add(series1);
         this.chartAdviceScores.Size = new System.Drawing.Size(390, 266);
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
         this.pnlTitle.Size = new System.Drawing.Size(640, 70);
         this.pnlTitle.TabIndex = 2;
         // 
         // lblTitle
         // 
         this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
         this.lblTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(204)))));
         this.lblTitle.Location = new System.Drawing.Point(0, 0);
         this.lblTitle.Name = "lblTitle";
         this.lblTitle.Size = new System.Drawing.Size(640, 70);
         this.lblTitle.TabIndex = 0;
         this.lblTitle.Text = "Claims Pend Advisor";
         this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTitle_MouseDown);
         // 
         // MainForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.SystemColors.Window;
         this.ClientSize = new System.Drawing.Size(773, 465);
         this.ControlBox = false;
         this.Controls.Add(this.pnlTitle);
         this.Controls.Add(this.pnlMain);
         this.Controls.Add(this.pnlNavigation);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
         this.Name = "MainForm";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.pnlNavigation.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.picCaduceus)).EndInit();
         this.pnlMain.ResumeLayout(false);
         this.pnlMain.PerformLayout();
         this.flowpnlClaimData.ResumeLayout(false);
         this.flowpnlClaimData.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.picMLBrain)).EndInit();
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
      private System.Windows.Forms.Button btnAdvise;
      private System.Windows.Forms.Button btnApply;
      private System.Windows.Forms.Button btnStart;
      private System.Windows.Forms.DataVisualization.Charting.Chart chartAdviceScores;
      private System.Windows.Forms.Label lblThreshold;
      private System.Windows.Forms.TextBox txtThreshold;
      private System.Windows.Forms.Label lblRecommendation;
      private System.Windows.Forms.PictureBox picMLBrain;
      private System.Windows.Forms.FlowLayoutPanel flowpnlClaimData;
      private System.Windows.Forms.Label lblMemberID;
      private System.Windows.Forms.TextBox txtMemberID;
      private System.Windows.Forms.Label lblClaimID;
      private System.Windows.Forms.TextBox txtClaimID;
      private System.Windows.Forms.Label lblDateReceived;
      private System.Windows.Forms.TextBox txtDateReceived;
      private System.Windows.Forms.Label lblProviderNPI;
      private System.Windows.Forms.TextBox txtProviderNPI;
      private System.Windows.Forms.Label lblDiagnosis1;
      private System.Windows.Forms.TextBox txtDiagnosis1;
      private System.Windows.Forms.Label lblDiagnosis2;
      private System.Windows.Forms.TextBox txtDiagnosis2;
      private System.Windows.Forms.Label lblPOS;
      private System.Windows.Forms.TextBox txtPOS;
      private System.Windows.Forms.Label lblProcedureCode;
      private System.Windows.Forms.TextBox txtProcedureCode;
      private System.Windows.Forms.Label lblUnits;
      private System.Windows.Forms.TextBox txtUnits;
      private System.Windows.Forms.Label lblPrice;
      private System.Windows.Forms.TextBox txtPrice;
      private System.Windows.Forms.Label lblPendReason;
      private System.Windows.Forms.TextBox txtPendReason;
   }
}

