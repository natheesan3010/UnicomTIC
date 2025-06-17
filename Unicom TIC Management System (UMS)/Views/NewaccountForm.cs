using System;
using System.Windows.Forms;
using Unicom_TIC_Management_System__UMS_.Controllers;
using Unicom_TIC_Management_System__UMS_.Models;
using Unicom_TIC_Management_System__UMS_.Repositories;

namespace Unicom_TIC_Management_System__UMS_.Views
{
    public partial class NewaccountForm : Form
    {
        private readonly _UserController _controller = new _UserController();

        public NewaccountForm()
        {
            InitializeComponent();
            cboRole.Items.AddRange(new[] { "admin", "teacher", "student" });
            cboRole.SelectedIndex = 0;
            cboRole.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Newaccount_Load(object sender, EventArgs e) { }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new MainForm().Show();
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var user = new User
            {
                Username = txtUsername.Text.Trim(),
                Password = txtPassword.Text.Trim(),
                Role = cboRole.SelectedItem.ToString()
            };

            if (string.IsNullOrWhiteSpace(user.Username) || string.IsNullOrWhiteSpace(user.Password))
            {
                MessageHelper.ShowInfo("Enter The Username and Password.");
                return;
            }

            bool result = _controller.AddUserIfNotExists(user);

            if (result)
            {
                MessageHelper.ShowSuccess("Registed Successful!", "Success");
                new NewaccountForm().Show();
                this.Hide();
            }
            else
            {
                MessageHelper.ShowError("This Username Already Used!", "Invalid");
            }
        }

        private void cboRole_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}
