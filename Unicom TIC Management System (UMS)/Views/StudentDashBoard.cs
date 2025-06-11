using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unicom_TIC_Management_System__UMS_.Views
{
    public partial class StudentDashBoard : Form
    {
        public StudentDashBoard()
        {
            InitializeComponent();
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnStudents_Click(object sender, EventArgs e)
        {

        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCourses_Click(object sender, EventArgs e)
        {

        }

        private void btnSubjects_Click(object sender, EventArgs e)
        {

        }

        private void btnExams_Click(object sender, EventArgs e)
        {

        }

        private void btnMarks_Click(object sender, EventArgs e)
        {

        }

        private void btnTimetables_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide(); // MainForm hiden
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
