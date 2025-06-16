using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unicom_TIC_Management_System__UMS_.Models;

namespace Unicom_TIC_Management_System__UMS_.Controllers
{
    internal class TimetableController
    {
        private static string connectionString = "Data Source=unicomtic.db";
        private static SQLiteConnection conn;

        public static DataTable GetTimetables()
        {
            using (SQLiteConnection con = new SQLiteConnection(connectionString))
            {
                con.Open();
                
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
            using (var con = new SQLiteConnection(connectionString))
            {
                con.Open();

                // foreign key enable
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
            using (SQLiteConnection con = new SQLiteConnection(connectionString))
            {
                con.Open();
                string query = "UPDATE Timetables SET SubjectID = @sid, TimeSlot = @slot, RoomID = @rid WHERE TimetableID = @id";
                SQLiteCommand cmd = new SQLiteCommand(query, con);
                cmd.Parameters.AddWithValue("@sid", timetable.SubjectID);
                cmd.Parameters.AddWithValue("@slot", timetable.TimeSlot);
                cmd.Parameters.AddWithValue("@rid", timetable.RoomID);
                cmd.Parameters.AddWithValue("@id", timetable.TimetableID);
                cmd.ExecuteNonQuery();
            }
        }

    }
}
