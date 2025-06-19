using System.Data.SQLite;
using System.IO;
using Unicom_TIC_Management_System__UMS_.Models;

namespace Unicom_TIC_Management_System__UMS_.Models
{
    public class _UserRepository
    {
        private readonly string connectionString;

        public _UserRepository()
        {
            string dbPath = Path.Combine(System.Windows.Forms.Application.StartupPath, "unicomtic.db");
            connectionString = $"Data Source={dbPath};Version=3;";
        }

        public bool AddUserIfNotExists(string username, string password, string role)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                // Check if user already exists
                string checkQuery = "SELECT COUNT(*) FROM Users WHERE Username = @Username";
                using (var cmd = new SQLiteCommand(checkQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    long count = (long)cmd.ExecuteScalar();
                    if (count > 0) return false; // Already exists
                }

                // Insert new user
                string insertQuery = "INSERT INTO Users (Username, Password, Role) VALUES (@Username, @Password, @Role)";
                using (var cmd = new SQLiteCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@Role", role);
                    cmd.ExecuteNonQuery();
                }

                return true;
            }
        }

        public User GetUser(string username, string password)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Users WHERE Username = @Username AND Password = @Password";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new User
                            {
                                Username = reader["Username"].ToString(),
                                Password = reader["Password"].ToString(),
                                Role = reader["Role"].ToString()
                            };
                        }
                    }
                }
            }
            return null;
        }

        // Check if user exists
        public bool UsernameExists(string username)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    return (long)cmd.ExecuteScalar() > 0;
                }
            }
        }

        //  Update password
        public bool UpdatePassword(string username, string newPassword)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE Users SET Password = @Password WHERE Username = @Username";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Password", newPassword);
                    cmd.Parameters.AddWithValue("@Username", username);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
    }
}
