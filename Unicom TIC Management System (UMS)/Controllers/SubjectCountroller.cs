using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using Unicom_TIC_Management_System__UMS_.Models;

namespace Unicom_TIC_Management_System__UMS_.Controllers
{
    public class SubjectController
    {
        private string connectionString = "Data Source=unicomtic.db;Version=3;";

        public List<Subject> GetAllSubjects()
        {
            var subjects = new List<Subject>();

            using (var con = new SQLiteConnection(connectionString))
            {
                con.Open();
                string query = @"SELECT s.SubjectID, s.SubjectName, c.CourseName, s.CourseID 
                                 FROM Subjects s
                                 INNER JOIN Courses c ON s.CourseID = c.CourseID";

                using (var cmd = new SQLiteCommand(query, con))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        subjects.Add(new Subject
                        {
                            SubjectID = reader.GetInt32(0),
                            SubjectName = reader.GetString(1),
                            CourseName = reader.GetString(2),
                            CourseID = reader.GetInt32(3)
                        });
                    }
                }
            }

            return subjects;
        }

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
    }
}
