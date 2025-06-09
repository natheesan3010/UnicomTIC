using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using Unicom_TIC_Management_System__UMS_.Models;

namespace Unicom_TIC_Management_System__UMS_.Controllers
{
    public class CourseController
    {
        private string connectionString = "Data Source=unicomtic.db;Version=3;";

        public bool AddCourse(string courseName)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("INSERT INTO Courses (Name) VALUES (@Name)", conn);
                cmd.Parameters.AddWithValue("@Name", courseName);
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
        }


        public void UpdateCourse(int id, string name)
        {
            using (var con = new SQLiteConnection(connectionString))
            {
                con.Open();
                string query = "UPDATE Courses SET Name = @name WHERE Id = @id";
                using (var cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteCourse(int id)
        {
            using (var con = new SQLiteConnection(connectionString))
            {
                con.Open();
                string query = "DELETE FROM Courses WHERE Id = @id";
                using (var cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetAllCourses()
        {
            var dt = new DataTable();
            using (var con = new SQLiteConnection(connectionString))
            {
                con.Open();
                string query = "SELECT * FROM Courses";
                using (var cmd = new SQLiteCommand(query, con))
                using (var adapter = new SQLiteDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }
            }
            return dt;
        }
    }
}
