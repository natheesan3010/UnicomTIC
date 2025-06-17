using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using Unicom_TIC_Management_System__UMS_.Models;

namespace Unicom_TIC_Management_System__UMS_.Controllers
{
    public class StudentController
    {
        private SQLiteConnection _conn;

        public StudentController()
        {
            string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "unicomtic.db");
            _conn = new SQLiteConnection($"Data Source={dbPath};Version=3;");
            _conn.Open();
        }

        public void CloseConnection()
        {
            _conn?.Close();
        }

        public void AddStudent(Student student)
        {
            string sql = "INSERT INTO Students (StudentName, NIC, CourseID) VALUES (@StudentName, @NIC, @CourseID)";
            using (var cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@StudentName", student.StudentName);
                cmd.Parameters.AddWithValue("@NIC", student.NIC_NO);
                cmd.Parameters.AddWithValue("@CourseID", student.CourseID);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateStudent(Student student)
        {
            string sql = "UPDATE Students SET StudentName = @StudentName, NIC = @NIC, CourseID = @CourseID WHERE StudentID = @StudentID";
            using (var cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@StudentName", student.StudentName);
                cmd.Parameters.AddWithValue("@NIC", student.NIC_NO);
                cmd.Parameters.AddWithValue("@CourseID", student.CourseID);
                cmd.Parameters.AddWithValue("@StudentID", student.StudentID);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteStudent(int studentId)
        {
            string sql = "DELETE FROM Students WHERE StudentID = @StudentID";
            using (var cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@StudentID", studentId);
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable GetAllCourses()
        {
            var dt = new DataTable();
            using (var conn = new SQLiteConnection(_conn.ConnectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("SELECT CourseID, CourseName FROM Courses", conn);
                dt.Load(cmd.ExecuteReader());
            }
            return dt;
        }

        public DataTable GetAllStudents()
        {
            var dt = new DataTable();
            string sql = @"
                SELECT s.StudentID, s.StudentName, s.NIC, s.CourseID, c.CourseName
                FROM Students s
                LEFT JOIN Courses c ON s.CourseID = c.CourseID";

            var cmd = new SQLiteCommand(sql, _conn);
            var adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
    }
}
