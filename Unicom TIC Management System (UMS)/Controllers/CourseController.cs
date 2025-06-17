using System.Data;
using System.Data.SQLite;
using Unicom_TIC_Management_System__UMS_.Models;
using Unicom_TIC_Management_System__UMS_.Repositories;  // DbCon namespace

namespace Unicom_TIC_Management_System__UMS_.Controllers
{
    public class CourseController
    {
        public bool AddCourse(string courseName)
        {
            using (var conn = DbCon.GetConnection())
            {
                var cmd = new SQLiteCommand("INSERT INTO Courses (CourseName) VALUES (@courseName)", conn);
                cmd.Parameters.AddWithValue("@courseName", courseName);
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
        }

        public void UpdateCourse(int id, string name)
        {
            using (var conn = DbCon.GetConnection())
            {
                string query = "UPDATE Courses SET CourseName = @name WHERE CourseID = @id";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteCourse(int id)
        {
            using (var conn = DbCon.GetConnection())
            {
                string query = "DELETE FROM Courses WHERE CourseID = @id";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetAllCourses()
        {
            var dt = new DataTable();
            using (var conn = DbCon.GetConnection())
            {
                string query = "SELECT CourseID, CourseName FROM Courses";
                using (var cmd = new SQLiteCommand(query, conn))
                using (var adapter = new SQLiteDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }
            }
            return dt;
        }
    }
}
