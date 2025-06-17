using System.Data;
using System.Data.SQLite;
using Unicom_TIC_Management_System__UMS_.Repositories;

namespace Unicom_TIC_Management_System__UMS_.Controllers
{
    public class MarkController
    {
        public DataTable GetStudents()
        {
            using (var con = DbCon.GetConnection())
            {
                var cmd = new SQLiteCommand("SELECT StudentID, StudentName FROM Students;", con);
                var adapter = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public DataTable GetExams()
        {
            using (var con = DbCon.GetConnection())
            {
                var cmd = new SQLiteCommand("SELECT * FROM Exams;", con);
                var adapter = new SQLiteDataAdapter(cmd);
                var dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public DataTable GetAllMarks()
        {
            using (var con = DbCon.GetConnection())
            {
                string query = @"SELECT m.MarkID, s.StudentName, e.ExamName, m.Score
                                 FROM Marks m
                                 JOIN Students s ON m.StudentID = s.StudentID
                                 JOIN Exams e ON m.ExamID = e.ExamID;";
                var adapter = new SQLiteDataAdapter(query, con);
                var dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public void AddMark(int studentId, int examId, int score)
        {
            using (var con = DbCon.GetConnection())
            {
                var cmd = new SQLiteCommand("INSERT INTO Marks (StudentID, ExamID, Score) VALUES (@studentId, @examId, @score);", con);
                cmd.Parameters.AddWithValue("@studentId", studentId);
                cmd.Parameters.AddWithValue("@examId", examId);
                cmd.Parameters.AddWithValue("@score", score);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateMark(int markId, int studentId, int examId, int score)
        {
            using (var con = DbCon.GetConnection())
            {
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
            using (var con = DbCon.GetConnection())
            {
                var cmd = new SQLiteCommand("DELETE FROM Marks WHERE MarkID = @markId;", con);
                cmd.Parameters.AddWithValue("@markId", markId);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
