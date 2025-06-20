using System.Data;
using System.Data.SQLite;
using Unicom_TIC_Management_System__UMS_.Models;
using Unicom_TIC_Management_System__UMS_.Repositories;

namespace Unicom_TIC_Management_System__UMS_.Controllers
{
    public class AttendanceController
    {
        public DataTable GetAllAttendance()
        {
            var conn = DbCon.GetConnection();
            string query = @"
                SELECT a.AttendanceID, a.StudentID, s.StudentName, sub.SubjectName, a.Date, a.Status
                FROM Attendances a
                JOIN Students s ON a.StudentID = s.StudentID
                JOIN Subjects sub ON a.SubjectID = sub.SubjectID";

            var da = new SQLiteDataAdapter(query, conn);
            var dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void AddAttendance(Attendance attendance)
        {
            var conn = DbCon.GetConnection();
            string query = @"
                INSERT OR IGNORE INTO Attendances (StudentID, SubjectID, Date, Status)
                VALUES (@StudentID, @SubjectID, @Date, @Status)";

            var cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@StudentID", attendance.StudentID);
            cmd.Parameters.AddWithValue("@SubjectID", attendance.SubjectID);
            cmd.Parameters.AddWithValue("@Date", attendance.Date.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@Status", attendance.Status);
            cmd.ExecuteNonQuery();
        }

        public void UpdateAttendance(Attendance attendance)
        {
            var conn = DbCon.GetConnection();
            string query = @"
                UPDATE Attendances SET Status = @Status
                WHERE StudentID = @StudentID AND SubjectID = @SubjectID AND Date = @Date";

            var cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@StudentID", attendance.StudentID);
            cmd.Parameters.AddWithValue("@SubjectID", attendance.SubjectID);
            cmd.Parameters.AddWithValue("@Date", attendance.Date.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@Status", attendance.Status);
            cmd.ExecuteNonQuery();
        }

        public void DeleteAttendance(int attendanceID)
        {
            var conn = DbCon.GetConnection();
            string query = "DELETE FROM Attendances WHERE AttendanceID = @AttendanceID";

            var cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@AttendanceID", attendanceID);
            cmd.ExecuteNonQuery();
        }
    }
}
