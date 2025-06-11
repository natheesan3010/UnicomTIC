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
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // ✅ Step 1: Optional – insert a sample user (only first time)
            var repo = new UserRepository();
            repo.AddUserIfNotExists("admin", "admin123", "Admin");
            repo.AddUserIfNotExists("teacher1", "teach123", "Teacher");
            repo.AddUserIfNotExists("student1", "stud123", "Student");

            // ✅ Step 2: Check login
            var user = repo.GetUser(username, password);

            if (user != null)
            {
                switch (user.Role)
                {
                    case "Admin":
                        new MainForm().Show();
                        break;
                    case "Teacher":
                        new TeacherDashBoard().Show();
                        break;
                    case "Student":
                        new StudentDashBoard().Show();
                        break;
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid login credentials", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
    }
}

