using System.Data.SQLite;
using System;
using Unicom_TIC_Management_System__UMS_.Models;

public class UserRepository
{
    private string _connectionString = "Data Source=unicomtic.db;Version=3;";

    public User GetUser(string username, string password)
    {
        using (var conn = new SQLiteConnection(_connectionString))
        {
            conn.Open();
            string query = "SELECT * FROM Users WHERE Username = @username AND Password = @password";
            using (var cmd = new SQLiteCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new User
                        {
                            UserID = Convert.ToInt32(reader["UserID"]),
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

    public void AddUserIfNotExists(string username, string password, string role)
    {
        using (var conn = new SQLiteConnection(_connectionString))
        {
            conn.Open();
            string checkQuery = "SELECT COUNT(*) FROM Users WHERE Username = @username";
            using (var checkCmd = new SQLiteCommand(checkQuery, conn))
            {
                checkCmd.Parameters.AddWithValue("@username", username);
                long count = (long)checkCmd.ExecuteScalar();

                if (count == 0)
                {
                    string insertQuery = "INSERT INTO Users (Username, Password, Role) VALUES (@username, @password, @role)";
                    using (var insertCmd = new SQLiteCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.AddWithValue("@username", username);
                        insertCmd.Parameters.AddWithValue("@password", password);
                        insertCmd.Parameters.AddWithValue("@role", role);
                        insertCmd.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
