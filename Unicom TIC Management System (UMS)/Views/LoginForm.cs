using System;
using System.Windows.Forms;
using Unicom_TIC_Management_System__UMS_.Controllers;

namespace Unicom_TIC_Management_System__UMS_.Views
{
    public partial class LoginForm : Form
    {
        private LoginFormController controller;

        public LoginForm()
        {
            InitializeComponent();
            controller = new LoginFormController(this);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            controller.HandleLogin(username, password);
        }

        

        // These are helper methods to allow the controller to manipulate the form
        public void ShowError(string message)
        {
            MessageBox.Show(message, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void RedirectToRoleForm(string role)
        {
            Form nextForm = null;
            switch (role)
            {
                case "admin":
                    nextForm = new MainForm();
                    break;
                case "teacher":
                    nextForm = new TeacherDashBoard();
                    break;
                case "student":
                    nextForm = new StudentDashBoard();
                    break;
            }

            if (nextForm != null)
            {
                nextForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Unknown role: " + role);
            }
        }

    }
}

