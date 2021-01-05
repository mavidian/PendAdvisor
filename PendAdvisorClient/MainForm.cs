using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
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
   }
}
