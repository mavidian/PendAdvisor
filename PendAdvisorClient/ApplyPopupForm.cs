using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PendAdvisorClient
{
   public partial class ApplyPopupForm : Form
   {
      public ApplyPopupForm()
      {
         InitializeComponent();
      }


      private async void ApplyPopupForm_Load(object sender, EventArgs e)
      {
         lblAction.ForeColor = this.ForeColor;
         lblAction.Text = this.Text;
         this.Opacity = 0;
         await FadeIn();
         await Task.Delay(1000);
         await FadeOutAndClose();
      }


      private async void ApplyPopupForm_MouseClick(object sender, MouseEventArgs e)
      {
         await FadeOutAndClose();
      }


      private async Task FadeIn()
      {
         while (this.Opacity < 1)
         {
            await Task.Delay(2);
            this.Opacity += (1d - this.Opacity) / 16d + .001d;
         }
      }


      private async Task FadeOutAndClose()
      {
         while (this.Opacity > 0)
         {
            await Task.Delay(16);
            this.Opacity -= (1d - this.Opacity)/16d + .001d;
         }
         this.Close();
      }

   }
}
