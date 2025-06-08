using System;
using System.Windows.Forms;


namespace Unicom_TIC_Management_System__UMS_.Views
{
    public partial class MainForm : Form
    {
        public MainForm(Models.User user)
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadForm(new WelcomeForm()); // ஆரம்பத்தில் Welcome Form
        }


        private void LoadForm(Form form)
        {
            panelMain.Controls.Clear(); // பழைய Form-ஐ clear செய்க
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
            LoadForm(new ExamForm()); // ✅ ShowDialog() வேண்டாம்
        }

        private void btnMarks_Click(object sender, EventArgs e)
        {
            LoadForm(new MarkForm()); // ✅ ShowDialog() வேண்டாம்
        }

        private void btnTimetables_Click(object sender, EventArgs e)
        {
            LoadForm(new TimetableForm()); // ✅ ShowDialog() வேண்டாம்
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide(); // MainForm மறைக்கப்படுகிறது
            LoginForm loginForm = new LoginForm(); // ✅ முதல் எழுத்து capital
            loginForm.Show();
        }

       

        // இந்த function-ல் Form load செய்ய தேவையில்லை, paint event UI redraw செய்யப்படுகிறது மட்டும்.
        private void panelMain_Paint(object sender, PaintEventArgs e)
        {
            // இதை அழிக்கவும் அல்லது காலியாக வைக்கவும்
        }

        private void panelMain_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void MainForm_Load_1(object sender, EventArgs e)
        {

        }

        private void lblHeading_Click(object sender, EventArgs e)
        {

        }
    }
}
