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
    public partial class MainForm: Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            CourseForm CourseForm = new CourseForm();
            CourseForm.ShowDialog();
        }

        private void btnSubjects_Click(object sender, EventArgs e)
        {

        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            StudentForm StudentForm = new StudentForm();
            StudentForm.ShowDialog();
        }

        private void btnExams_Click(object sender, EventArgs e)
        {
            ExamForm ExamForm = new ExamForm();
            ExamForm.ShowDialog();
        }

        private void btnMarks_Click(object sender, EventArgs e)
        {
            MarkForm MarkForm = new MarkForm();
            MarkForm.ShowDialog();
        }

        private void btnTimetables_Click(object sender, EventArgs e)
        {
            TimetableForm TimetableForm = new TimetableForm();
            TimetableForm.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            loginform loginform = new loginform();
            loginform.ShowDialog();
            
        }
    }
}
