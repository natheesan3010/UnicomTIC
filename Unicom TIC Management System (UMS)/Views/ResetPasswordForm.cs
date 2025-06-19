using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unicom_TIC_Management_System__UMS_.Controllers;

namespace Unicom_TIC_Management_System__UMS_.Views
{
    public partial class ResetPasswordForm : Form
    {
        public ResetPasswordForm()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetPasswordController controller = new ResetPasswordController();

            bool result = controller.ResetPassword(
                txtUsername.Text.Trim(),
                txtNewPassword.Text,
                txtConfirmPassword.Text
            );

            if (result)
            {
                this.Close(); // Close form if successful
            }
        }
    }
}
