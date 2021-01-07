
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
         this.lblAction = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // lblAction
         // 
         this.lblAction.AutoSize = true;
         this.lblAction.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblAction.ForeColor = System.Drawing.SystemColors.ControlText;
         this.lblAction.Location = new System.Drawing.Point(64, 93);
         this.lblAction.MaximumSize = new System.Drawing.Size(300, 0);
         this.lblAction.Name = "lblAction";
         this.lblAction.Size = new System.Drawing.Size(288, 128);
         this.lblAction.TabIndex = 0;
         this.lblAction.Text = "x x x x x x x x x x x x x x x x x x x x x x x x x x x x x x x x x x x x x x x x x" +
    "  ";
         this.lblAction.UseMnemonic = false;
         // 
         // ApplyPopupForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackgroundImage = global::PendAdvisorClient.Properties.Resources.cloud_empty;
         this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
         this.ClientSize = new System.Drawing.Size(404, 304);
         this.Controls.Add(this.lblAction);
         this.DoubleBuffered = true;
         this.ForeColor = System.Drawing.Color.Red;
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
         this.Name = "ApplyPopupForm";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "... action being performed ...";
         this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(204)))));
         this.Load += new System.EventHandler(this.ApplyPopupForm_Load);
         this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ApplyPopupForm_MouseClick);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label lblAction;
   }
}