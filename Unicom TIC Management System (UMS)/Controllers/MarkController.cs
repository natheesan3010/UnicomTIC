using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace Unicom_TIC_Management_System__UMS_.Controllers
{
    public class MarkController
    {
        private string connectionString = "Data Source=unicomtic.db;Version=3;";

        public DataTable GetStudents()
        {
            using (var con = new SQLiteConnection(connectionString))
            {
                con.Open();
                var cmd = new SQLiteCommand("SELECT StudentID, StudentName FROM Students;", con);
                var adapter = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public DataTable GetExams()
        {
            var dt = new DataTable();
            using (var con = new SQLiteConnection(connectionString))
            {
                con.Open();
                string query = "SELECT * FROM Exams"; // உங்கள் actual table name
                using (var cmd = new SQLiteCommand(query, con))
                using (var adapter = new SQLiteDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }
            }
            return dt;
        }

        public DataTable GetAllMarks()
        {
            using (var con = new SQLiteConnection(connectionString))
            {
                con.Open();
                string query = @"SELECT m.MarkID, s.StudentName, e.ExamName, m.Score
                                 FROM Marks m
                                 JOIN Students s ON m.StudentID = s.StudentID
                                 JOIN Exams e ON m.ExamID = e.ExamID;";
                var adapter = new SQLiteDataAdapter(query, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public void AddMark(int studentId, int examId, int score)
        {
            using (var con = new SQLiteConnection(connectionString))
            {
                con.Open();
                var cmd = new SQLiteCommand("INSERT INTO Marks (StudentID, ExamID, Score) VALUES (@studentId, @examId, @score);", con);
                cmd.Parameters.AddWithValue("@studentId", studentId);
                cmd.Parameters.AddWithValue("@examId", examId);
                cmd.Parameters.AddWithValue("@score", score);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateMark(int markId, int studentId, int examId, int score)
        {
            using (var con = new SQLiteConnection(connectionString))
            {
                con.Open();
                var cmd = new SQLiteCommand("UPDATE Marks SET StudentID = @studentId, ExamID = @examId, Score = @score WHERE MarkID = @markId;", con);
                cmd.Parameters.AddWithValue("@studentId", studentId);
                cmd.Parameters.AddWithValue("@examId", examId);
                cmd.Parameters.AddWithValue("@score", score);
                cmd.Parameters.AddWithValue("@markId", markId);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteMark(int markId)
        {
            // Create a new connection to the database
            using (var con = new SQLiteConnection(connectionString))
            {
                // Open the database connection
                con.Open();

                // Create the delete command
                var cmd = new SQLiteCommand("DELETE FROM Marks WHERE MarkID = @markId;", con);
                cmd.Parameters.AddWithValue("@markId", markId);

                // Execute the command
                cmd.ExecuteNonQuery();
            }
        }


    }
}
