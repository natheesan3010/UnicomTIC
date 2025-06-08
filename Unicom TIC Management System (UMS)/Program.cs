using System;
using System.Windows.Forms;
using Unicom_TIC_Management_System__UMS_.Views;
using UnicomTICManagementSystem.Repositories;


namespace UnicomTICManagementSystem
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            DatabaseManager.InitializeDatabase();  // <--- Ensures DB and default admin exists
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new loginform());
        }
    }

    internal class loginform : Form
    {
    }
}
