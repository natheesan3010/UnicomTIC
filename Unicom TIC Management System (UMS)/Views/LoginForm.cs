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

            MainForm MainForm = new MainForm();
            MainForm.Show();

        }
    }
}
