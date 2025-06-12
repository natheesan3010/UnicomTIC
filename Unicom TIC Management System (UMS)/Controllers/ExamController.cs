using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using Unicom_TIC_Management_System__UMS_.Models;
using System.Windows.Forms;

namespace Unicom_TIC_Management_System__UMS_.Controllers
{
    public class ExamController
    {
        private readonly string _connectionString;

        public ExamController()
        {
            string dbPath = Path.Combine(Application.StartupPath, "unicomtic.db");
            _connectionString = $"Data Source={dbPath};Version=3;";
        }

        public DataTable GetAllExams()
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                var dt = new DataTable();
                string sql = @"
            SELECT e.ExamID, e.ExamName, s.SubjectName
            FROM Exams e
            INNER JOIN Subjects s ON e.SubjectID = s.SubjectID
        ";
                using (var cmd = new SQLiteCommand(sql, conn))
                using (var da = new SQLiteDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
                return dt;
            }
        }


        public void AddExam(Exam exam)
        {
            try
            {
                using (var conn = new SQLiteConnection(_connectionString))
                {
                    conn.Open();
                    string sql = "INSERT INTO Exams (SubjectID, ExamName) VALUES (@SubjectID, @ExamName)";
                    using (var cmd = new SQLiteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@SubjectID", exam.SubjectID);
                        cmd.Parameters.AddWithValue("@ExamName", exam.ExamName);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding exam: " + ex.Message);
            }
        }

        public void UpdateExam(Exam exam)
        {
            try
            {
                using (var conn = new SQLiteConnection(_connectionString))
                {
                    conn.Open();
                    string sql = "UPDATE Exams SET SubjectID = @SubjectID, ExamName = @ExamName WHERE ExamID = @ExamID";
                    using (var cmd = new SQLiteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@SubjectID", exam.SubjectID);
                        cmd.Parameters.AddWithValue("@ExamName", exam.ExamName);
                        cmd.Parameters.AddWithValue("@ExamID", exam.ExamID);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating exam: " + ex.Message);
            }
        }

        public void DeleteExam(int examId)
        {
            try
            {
                using (var conn = new SQLiteConnection(_connectionString))
                {
                    conn.Open();
                    string sql = "DELETE FROM Exams WHERE ExamID = @ExamID";
                    using (var cmd = new SQLiteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@ExamID", examId);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting exam: " + ex.Message);
            }
        }

        public DataTable GetAllSubjects()
        {
            try
            {
                using (var conn = new SQLiteConnection(_connectionString))
                {
                    conn.Open();
                    var dt = new DataTable();
                    string sql = "SELECT SubjectID, SubjectName FROM Subjects";
                    using (var cmd = new SQLiteCommand(sql, conn))
                    using (var da = new SQLiteDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                    return dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching subjects: " + ex.Message);
                return null;
            }
        }
    }
}
