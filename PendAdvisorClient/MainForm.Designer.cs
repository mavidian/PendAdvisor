
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
         this.pnlNavigation = new System.Windows.Forms.Panel();
         this.pnlMain = new System.Windows.Forms.Panel();
         this.pnlTitle = new System.Windows.Forms.Panel();
         this.lblTitle = new System.Windows.Forms.Label();
         this.btnApply = new System.Windows.Forms.Button();
         this.btnClaim = new System.Windows.Forms.Button();
         this.btnAdvice = new System.Windows.Forms.Button();
         this.btnClose = new System.Windows.Forms.Button();
         this.picCaduceus = new System.Windows.Forms.PictureBox();
         this.pnlNavigation.SuspendLayout();
         this.pnlTitle.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.picCaduceus)).BeginInit();
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
         // pnlMain
         // 
         this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(216)))), ((int)(((byte)(213)))));
         this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
         this.pnlMain.Location = new System.Drawing.Point(133, 0);
         this.pnlMain.Name = "pnlMain";
         this.pnlMain.Size = new System.Drawing.Size(667, 464);
         this.pnlMain.TabIndex = 1;
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
         this.pnlTitle.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.picCaduceus)).EndInit();
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
   }
}

