using System;
using System.Data.SQLite;
using System.Windows.Forms;
using Unicom_TIC_Management_System__UMS_.Models;

namespace Unicom_TIC_Management_System__UMS_.Views
{
    public partial class LoginForm : Form
    {
        private string connectionString = "Data Source=unicomtic.db;Version=3;";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            var repo = new UserRepository();
            var user = repo.GetUser(txtUsername.Text, txtPassword.Text);

            if (user != null)
            {
                switch (user.Role)
                {
                    case "Admin":
                        new MainForm().Show();
                        break;
                    case "Teacher":
                        new TeacherForm().Show();
                        break;
                    case "Student":
                        new StudentForm().Show();
                        break;
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid login credentials");
            }
        }
    }
}

