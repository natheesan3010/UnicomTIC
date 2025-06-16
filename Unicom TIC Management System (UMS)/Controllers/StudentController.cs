using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using Unicom_TIC_Management_System__UMS_.Models;
using UnicomTICManagementSystem.Repositories;

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
            string sql = "INSERT INTO Students (StudentName, NIC) VALUES (@StudentName, @NIC)";
            using (var cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@StudentName", student.StudentName);
                cmd.Parameters.AddWithValue("@NIC", student.NIC_NO);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateStudent(Student student)
        {
            string sql = "UPDATE Students SET StudentName = @StudentName, NIC = @NIC WHERE StudentID = @StudentID";
            using (var cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@StudentName", student.StudentName);
                cmd.Parameters.AddWithValue("@NIC", student.NIC_NO);
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
            using (var conn = DatabaseManager.GetConnection())
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
            var cmd = new SQLiteCommand("SELECT * FROM Students", _conn);
            var adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }

    }
}
