using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicom_TIC_Management_System__UMS_.Repositories
{
    public static class DbCon
    {
        private static string connectionString = "Data Source = unicomtic.db; Version=3;";

        public static SQLiteConnection GetConnection()
        {
            try
            {
                var conn = new SQLiteConnection(connectionString);
                conn.Open();
                return conn;
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to connect to database: " + ex.Message);
            }
        }

    }

}
