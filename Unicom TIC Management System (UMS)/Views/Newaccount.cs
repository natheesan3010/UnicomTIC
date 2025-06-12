using System;
using System.Data.SQLite;
using System.Windows.Forms;
using Unicom_TIC_Management_System__UMS_.Models;

namespace Unicom_TIC_Management_System__UMS_.Views
{
    // NOTE: partial ==> joins with Newaccount.Designer.cs
    public partial class Newaccount : Form
    {
        private readonly SQLiteConnection _conn =
            new SQLiteConnection("Data Source=unicomtic.db;Version=3;");

        public Newaccount()
        {
            InitializeComponent();

            // ---- ComboBox set-up ONCE ----
            cboRole.Items.AddRange(new[] { "admin", "teacher", "student" });
            cboRole.SelectedIndex = 0;
            cboRole.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        // ------------------------ Back button ------------------------
        private void btnBack_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Hide();
        }

        // --------------------- Register button -----------------------
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string role = cboRole.SelectedItem.ToString();

            var repo = new _UserRepository();
            bool result = repo.AddUserIfNotExists(username, password, role);

            if (result)
            {
                MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new LoginForm().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Newaccount.cs – Logic file
        private void cboRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Event no longer needed; kept only to satisfy Designer hook.
        }
    }
}