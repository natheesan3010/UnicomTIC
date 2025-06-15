using System.Data.SQLite;
using System.Windows.Forms;
using Unicom_TIC_Management_System__UMS_.Models;
using Unicom_TIC_Management_System__UMS_.Views;

namespace Unicom_TIC_Management_System__UMS_.Controllers
{
    public class LoginFormController
    {
        private readonly LoginForm loginForm;
        private readonly _UserRepository repo;

        public LoginFormController(LoginForm form)
        {
            loginForm = form;
            repo = new _UserRepository();

            // Optional: insert sample users (first-time run)
            repo.AddUserIfNotExists("admin", "admin123", "admin");
            repo.AddUserIfNotExists("teacher1", "teacher123", "teacher");
            repo.AddUserIfNotExists("student1", "student123", "student");
        }

        public void HandleLogin(string username, string password)
        {
            var user = repo.GetUser(username, password);

            if (user != null)
            {
                MessageBox.Show($"Login Success\nUsername: {user.Username}\nRole: {user.Role}");
                loginForm.RedirectToRoleForm(user.Role);
            }
            else
            {
                MessageBox.Show("User not found or password incorrect!", "Login Failed");
                loginForm.ShowError("Invalid login credentials");
            }
        }
    }
}
