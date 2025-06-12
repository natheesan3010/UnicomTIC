using System;
using System.Data.SQLite;
using System.IO;
using Unicom_TIC_Management_System__UMS_.Models;

namespace Unicom_TIC_Management_System__UMS_.Controllers
{
    public class _UserController
    {
        private SQLiteConnection _conn;

        public _UserController()
        {
            string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "unicomtic.db");
            _conn = new SQLiteConnection($"Data Source={dbPath};Version=3;");
            _conn.Open();
        }

        public void CloseConnection()
        {
            _conn?.Close();
        }

        public bool AddUserIfNotExists(User user)
        {
            const string checkSql = "SELECT COUNT(*) FROM Users WHERE Username = @Username";
            using (var checkCmd = new SQLiteCommand(checkSql, _conn))
            {
                checkCmd.Parameters.AddWithValue("@Username", user.Username);
                long count = (long)checkCmd.ExecuteScalar();
                if (count > 0)
                {
                    return false; // Username exists
                }
            }

            const string insertSql = "INSERT INTO Users (Username, Password, Role) VALUES (@Username, @Password, @Role)";
            using (var insertCmd = new SQLiteCommand(insertSql, _conn))
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
