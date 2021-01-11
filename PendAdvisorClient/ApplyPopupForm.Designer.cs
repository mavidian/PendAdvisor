
namespace PendAdvisorClient
{
   partial class ApplyPopupForm
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
         this.picBackground = new System.Windows.Forms.PictureBox();
         this.lblAction = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)(this.picBackground)).BeginInit();
         this.SuspendLayout();
         // 
         // picBackground
         // 
         this.picBackground.Dock = System.Windows.Forms.DockStyle.Fill;
         this.picBackground.Image = global::PendAdvisorClient.Properties.Resources.cloud_animating_gear;
         this.picBackground.Location = new System.Drawing.Point(0, 0);
         this.picBackground.Name = "picBackground";
         this.picBackground.Size = new System.Drawing.Size(400, 331);
         this.picBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.picBackground.TabIndex = 1;
         this.picBackground.TabStop = false;
         // 
         // lblAction
         // 
         this.lblAction.AutoSize = true;
         this.lblAction.BackColor = System.Drawing.Color.Transparent;
         this.lblAction.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblAction.ForeColor = System.Drawing.SystemColors.ControlText;
         this.lblAction.Location = new System.Drawing.Point(44, 113);
         this.lblAction.MaximumSize = new System.Drawing.Size(320, 0);
         this.lblAction.Name = "lblAction";
         this.lblAction.Size = new System.Drawing.Size(316, 96);
         this.lblAction.TabIndex = 2;
         this.lblAction.Text = "x x x x x x x x x x x x x x x x x x x x x x x x x x x x x x x x x x x x x x x x x" +
    " x  ";
         this.lblAction.UseMnemonic = false;
         // 
         // ApplyPopupForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
         this.ClientSize = new System.Drawing.Size(400, 331);
         this.Controls.Add(this.lblAction);
         this.Controls.Add(this.picBackground);
         this.DoubleBuffered = true;
         this.ForeColor = System.Drawing.Color.Red;
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
         this.Name = "ApplyPopupForm";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "... action being performed ...";
         this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(204)))));
         this.Load += new System.EventHandler(this.ApplyPopupForm_Load);
         this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ApplyPopupForm_MouseClick);
         ((System.ComponentModel.ISupportInitialize)(this.picBackground)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion
      private System.Windows.Forms.PictureBox picBackground;
      private System.Windows.Forms.Label lblAction;
   }
}