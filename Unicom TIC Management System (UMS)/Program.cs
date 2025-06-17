using System;
using System.Windows.Forms;
using Unicom_TIC_Management_System__UMS_.Views;
using UnicomTicManagementSystem.Data;


namespace UnicomTICManagementSystem
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            DatabaseManager.CreateTables();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
