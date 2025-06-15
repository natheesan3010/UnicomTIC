using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unicom_TIC_Management_System__UMS_.Controllers;
using Unicom_TIC_Management_System__UMS_.Models;

namespace Unicom_TIC_Management_System__UMS_.Views
{
    public partial class StudentDashBoard : Form
    {
        public StudentDashBoard()
        {
            InitializeComponent();
        }

       

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide(); // MainForm hiden
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            CourseController courseController = new CourseController();
            DataTable dt = courseController.GetAllCourses();
            View.DataSource = dt;
        }

        private void btnSubjects_Click(object sender, EventArgs e)
        {
            SubjectController SubjectController = new SubjectController();
            DataTable dt = SubjectController.GetAllSubjects();
            View.DataSource = dt;
        }

        private void btnExams_Click(object sender, EventArgs e)
        {
            ExamController ExamController = new ExamController();
            DataTable dt = ExamController.GetAllExams();
            View.DataSource = dt;
        }

        private void btnMarks_Click(object sender, EventArgs e)
        {
            MarkController markController = new MarkController();
            DataTable dt = markController.GetExams();
            View.DataSource = dt;
        }

        private void btnTimetables_Click(object sender, EventArgs e)
        {
            TimetableController TimetableController = new TimetableController();
            DataTable dt = TimetableController.GetTimetables();
            View.DataSource = dt;
        }
    }
}
