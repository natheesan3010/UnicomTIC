using System.Data.SQLite;
using Unicom_TIC_Management_System__UMS_.Models;
using Unicom_TIC_Management_System__UMS_.Repositories; // Make sure this namespace is correct for DbCon

namespace Unicom_TIC_Management_System__UMS_.Controllers
{
    public class _UserController
    {
        public bool AddUserIfNotExists(User user)
        {
            using (var conn = DbCon.GetConnection())
            {
                // Check if username already exists
                const string checkSql = "SELECT COUNT(*) FROM Users WHERE Username = @Username";
                using (var checkCmd = new SQLiteCommand(checkSql, conn))
                {
                    checkCmd.Parameters.AddWithValue("@Username", user.Username);
                    long count = (long)checkCmd.ExecuteScalar();
                    if (count > 0)
                    {
                        return false; // Username exists
                    }
                }

                // Insert new user
                const string insertSql = "INSERT INTO Users (Username, Password, Role) VALUES (@Username, @Password, @Role)";
                using (var insertCmd = new SQLiteCommand(insertSql, conn))
                {
                    insertCmd.Parameters.AddWithValue("@Username", user.Username);
                    insertCmd.Parameters.AddWithValue("@Password", user.Password);
                    insertCmd.Parameters.AddWithValue("@Role", user.Role);
                    insertCmd.ExecuteNonQuery();
                }

                return true;
            }
        }
    }
}
