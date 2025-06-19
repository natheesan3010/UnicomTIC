using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unicom_TIC_Management_System__UMS_.Models;
using Unicom_TIC_Management_System__UMS_.Repositories;

namespace Unicom_TIC_Management_System__UMS_.Controllers
{
    public class ResetPasswordController
    {
        private readonly _UserRepository userRepository = new _UserRepository();

        public bool ResetPassword(string username, string newPassword, string confirmPassword)
        {
            // Validation
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(newPassword))
            {
                MessageHelper.ShowError("Please fill in all fields.");
                return false;
            }

            if (newPassword != confirmPassword)
            {
                MessageHelper.ShowError("New password and confirm password do not match.");
                return false;
            }

            if (!userRepository.UsernameExists(username))
            {
                MessageHelper.ShowError("Username not found.");
                return false;
            }

            bool success = userRepository.UpdatePassword(username, newPassword);
            if (success)
            {
                MessageHelper.ShowSuccess("Password has been reset successfully.");
                return true;
            }
            else
            {
                MessageHelper.ShowInfo("Something went wrong while resetting the password.");
                return false;
            }
        }
    }
}
