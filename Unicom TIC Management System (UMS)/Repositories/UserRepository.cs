using System;
using System.Collections.Generic;
using System.Data.SQLite;
using Unicom_TIC_Management_System__UMS_.Models;

public class UserRepository
{
    private string _connectionString = "Data Source=your.db";

    public User GetUser(string username, string password)
    {
        using (var conn = new SQLiteConnection(_connectionString))
        {
            conn.Open();
            string query = "SELECT * FROM Users WHERE Username = @username AND Password = @password";
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
}

