using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using Unicom_TIC_Management_System__UMS_.Models;

namespace Unicom_TIC_Management_System__UMS_.Controllers
{
    public class SubjectController
    {
        private string connectionString = "Data Source=unicomtic.db;Version=3;";



        public void AddSubject(Subject subject)
        {
            using (var con = new SQLiteConnection(connectionString))
            {
                con.Open();
                var cmd = new SQLiteCommand("INSERT INTO Subjects (SubjectName, CourseID) VALUES (@name, @courseId)", con);
                cmd.Parameters.AddWithValue("@name", subject.SubjectName);
                cmd.Parameters.AddWithValue("@courseId", subject.CourseID);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateSubject(Subject subject)
        {
            using (var con = new SQLiteConnection(connectionString))
            {
                con.Open();
                var cmd = new SQLiteCommand("UPDATE Subjects SET SubjectName = @name, CourseID = @courseId WHERE SubjectID = @id", con);
                cmd.Parameters.AddWithValue("@name", subject.SubjectName);
                cmd.Parameters.AddWithValue("@courseId", subject.CourseID);
                cmd.Parameters.AddWithValue("@id", subject.SubjectID);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteSubject(int subjectId)
        {
            using (var con = new SQLiteConnection(connectionString))
            {
                con.Open();
                var cmd = new SQLiteCommand("DELETE FROM Subjects WHERE SubjectID = @id", con);
                cmd.Parameters.AddWithValue("@id", subjectId);
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable GetCourses()
        {
            using (var con = new SQLiteConnection(connectionString))
            {
                con.Open();
                var cmd = new SQLiteCommand("SELECT CourseID, CourseName FROM Courses", con);
                var reader = cmd.ExecuteReader();
                var dt = new DataTable();
                dt.Load(reader);
                return dt;
            }
        }

        public DataTable GetAllSubjects()
        {
            using (SQLiteConnection con = new SQLiteConnection(connectionString))
            {
                con.Open();
                string query = "SELECT SubjectID, SubjectName, CourseID FROM Subjects";
                SQLiteDataAdapter da = new SQLiteDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

    }
}

