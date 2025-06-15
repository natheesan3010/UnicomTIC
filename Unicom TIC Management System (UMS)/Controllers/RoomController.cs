using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unicom_TIC_Management_System__UMS_.Models;

namespace Unicom_TIC_Management_System__UMS_.Controllers
{
    internal class RoomController
    {
        private static string connectionString = "Data Source=unicomtic.db";

        public DataTable GetAllRooms()
        {
            using (var con = new SQLiteConnection(connectionString))
            {
                con.Open();
                string query = "SELECT RoomID, RoomName, RoomType FROM Rooms";
                SQLiteDataAdapter da = new SQLiteDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public void AddRoom(Room room)
        {
            using (var con = new SQLiteConnection(connectionString))
            {
                con.Open();
                string query = "INSERT INTO Rooms (RoomName, RoomType) VALUES (@name, @type)";
                using (var cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@name", room.RoomName);
                    cmd.Parameters.AddWithValue("@type", room.RoomType);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
