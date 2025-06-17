using System.Data;
using System.Data.SQLite;
using Unicom_TIC_Management_System__UMS_.Models;
using Unicom_TIC_Management_System__UMS_.Repositories; // For DbCon

namespace Unicom_TIC_Management_System__UMS_.Controllers
{
    internal class TimetableController
    {
        public static DataTable GetTimetables()
        {
            using (SQLiteConnection con = DbCon.GetConnection())
            {
                // Enable foreign keys
                using (var cmd = new SQLiteCommand("PRAGMA foreign_keys = ON;", con))
                {
                    cmd.ExecuteNonQuery();
                }

                string query = @"SELECT t.TimetableID, s.SubjectName, t.TimeSlot, r.RoomName, r.RoomType
                                 FROM Timetables t
                                 JOIN Subjects s ON t.SubjectID = s.SubjectID
                                 JOIN Rooms r ON t.RoomID = r.RoomID";

                SQLiteDataAdapter da = new SQLiteDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public static void AddTimetable(Timetable timetable)
        {
            using (var con = DbCon.GetConnection())
            {
                // Enable foreign keys
                using (var pragmaCmd = new SQLiteCommand("PRAGMA foreign_keys = ON;", con))
                {
                    pragmaCmd.ExecuteNonQuery();
                }

                string query = @"INSERT INTO Timetables (SubjectID, TimeSlot, RoomID) 
                                 VALUES (@sid, @slot, @rid)";
                using (var cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@sid", timetable.SubjectID);
                    cmd.Parameters.AddWithValue("@slot", timetable.TimeSlot);
                    cmd.Parameters.AddWithValue("@rid", timetable.RoomID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void UpdateTimetable(Timetable timetable)
        {
            using (SQLiteConnection con = DbCon.GetConnection())
            {
                string query = "UPDATE Timetables SET SubjectID = @sid, TimeSlot = @slot, RoomID = @rid WHERE TimetableID = @id";
                using (var cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@sid", timetable.SubjectID);
                    cmd.Parameters.AddWithValue("@slot", timetable.TimeSlot);
                    cmd.Parameters.AddWithValue("@rid", timetable.RoomID);
                    cmd.Parameters.AddWithValue("@id", timetable.TimetableID);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
