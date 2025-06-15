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
    public partial class TeacherDashBoard : Form
    {
        public TeacherDashBoard()
        {
            InitializeComponent();
        }

        private void btnExams_Click(object sender, EventArgs e)
        {
            LoadForm(new ExamForm());
        }

        private void LoadForm(Form form)
        {
            panelMain1.Controls.Clear(); // old  Form clear 
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelMain1.Controls.Add(form);
            form.Show();
        }

        
        private void TeacherDashBoard_Load(object sender, EventArgs e)
        {
            LoadForm(new WelcomeForm());
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            LoadForm(new WelcomeForm());
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            LoadForm(new StudentForm());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadForm(new RoomForm());

        }

        private void btnMarks_Click(object sender, EventArgs e)
        {
            LoadForm(new MarkForm());
        }

        private void btnTimetables_Click(object sender, EventArgs e)
        {
            LoadForm(new TimetableForm());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

    }
}
