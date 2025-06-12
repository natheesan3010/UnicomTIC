using System.Data.SQLite;
using System;
using Unicom_TIC_Management_System__UMS_.Models;

public class _UserRepository
{
    
    private string _connectionString = "Data Source=unicomtic.db;Version=3;";

    public User GetUser(string username, string password)
    {
        using (var conn = new SQLiteConnection("Data Source=unicomtic.db;Version=3;"))
        {
            conn.Open();
            string query = "SELECT * FROM users WHERE LOWER(username) = @username AND password = @password";
            using (var cmd = new SQLiteCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@username", username.ToLower());
                cmd.Parameters.AddWithValue("@password", password);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new User
                        {
                            Username = reader["username"].ToString(),
                            Password = reader["password"].ToString(),
                            Role = reader["role"].ToString()
                        };
                    }
                }
            }
        }
        return null;
    }



    public bool AddUserIfNotExists(string username, string password, string role)
    {
        using (var conn = new SQLiteConnection("Data Source=unicomtic.db;Version=3;"))
        {
            conn.Open();

            string checkQuery = "SELECT COUNT(*) FROM users WHERE username = @username";
            using (var cmd = new SQLiteCommand(checkQuery, conn))
            {
                cmd.Parameters.AddWithValue("@username", username);
                long count = (long)cmd.ExecuteScalar();
                if (count > 0)
                    return false;
            }

            string insertQuery = "INSERT INTO users (username, password, role) VALUES (@username, @password, @role)";
            using (var cmd = new SQLiteCommand(insertQuery, conn))
            {
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@role", role);
                cmd.ExecuteNonQuery();
            }

            return true;
        }
    }

}
