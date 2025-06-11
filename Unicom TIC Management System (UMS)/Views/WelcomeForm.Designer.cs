using System.Drawing;
using System.Windows.Forms;

namespace Unicom_TIC_Management_System__UMS_.Views
{
    partial class WelcomeForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.PictureBox pictureBox1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();

            // 
            // lblWelcome
            // 
            this.lblWelcome.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.Navy;
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWelcome.Text = "Welcome to Unicom TIC ";
            this.lblWelcome.Height = 50;

            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            // Resource image loading
            if (Properties.Resources.welcome != null)
            {
                this.pictureBox1.Image = Properties.Resources.welcome;
            }
            else
            {
                MessageBox.Show("Image not found in resources");
            }

            // 
            // WelcomeForm
            // 
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblWelcome);
            this.Name = "WelcomeForm";
            this.Size = new System.Drawing.Size(600, 400);
            this.Text = "Welcome";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
