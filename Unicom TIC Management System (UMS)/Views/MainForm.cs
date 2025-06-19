using System;
using System.Windows.Forms;
using Unicom_TIC_Management_System__UMS_.Models;


namespace Unicom_TIC_Management_System__UMS_.Views
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadForm(new WelcomeForm()); // first show Welcome Form
        }


        private void LoadForm(Form form)
        {
            panelMain.Controls.Clear(); // old  Form clear 
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelMain.Controls.Add(form);
            form.Show();
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            LoadForm(new StudentForm());
        }
    

    private void btnCourses_Click(object sender, EventArgs e)
        {
            LoadForm(new CourseForm());
        }

        private void btnSubjects_Click(object sender, EventArgs e)
        {
            LoadForm(new SubjectForm());
        }

       

        private void btnExams_Click(object sender, EventArgs e)
        {
            LoadForm(new ExamForm()); 
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
            this.Hide(); // MainForm hiden
            LoginForm loginForm = new LoginForm(); 
            loginForm.Show();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            new NewaccountForm().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadForm(new RoomForm());
        }
        private void btnPassword_Click(object sender, EventArgs e)
        {
            LoadForm(new ResetPasswordForm());
        }

        private void btnAtt_Click(object sender, EventArgs e)
        {
            LoadForm(new AttendanceForm());
        }
    }
}
