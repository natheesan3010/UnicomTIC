using System.Data;
using System.Data.SQLite;
using Unicom_TIC_Management_System__UMS_.Models;
using Unicom_TIC_Management_System__UMS_.Repositories;

namespace Unicom_TIC_Management_System__UMS_.Controllers
{
    internal class RoomController
    {
        public DataTable GetAllRooms()
        {
            using (var con = DbCon.GetConnection())
            {
                string query = "SELECT RoomID, RoomName, RoomType FROM Rooms";
                SQLiteDataAdapter da = new SQLiteDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public void AddRoom(Room room)
        {
            using (var con = DbCon.GetConnection())
            {
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
