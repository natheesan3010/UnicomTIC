using System;
using System.Data;
using System.Windows.Forms;
using Unicom_TIC_Management_System__UMS_.Models;
using Unicom_TIC_Management_System__UMS_.Controllers;

namespace Unicom_TIC_Management_System__UMS_.Views
{
    public partial class ExamForm : Form
    {
        private ExamController controller = new ExamController();
        private int selectedExamId = -1;

        public ExamForm()
        {
            InitializeComponent();
            this.Load += ExamForm_Load;           // Ensure Load event wired
            examGrid.CellClick += examGrid_CellClick;  // Wire CellClick event
        }

        private void ExamForm_Load(object sender, EventArgs e)
        {
            LoadSubjects();  // Load subjects once on form load
            LoadExamData();  // Load exams into grid
        }

        private void LoadSubjects()
        {
            var dt = controller.GetAllSubjects();

            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("No subjects found in the database! Please check your data.");
                cmbSubject.DataSource = null;
                return;
            }

            cmbSubject.DataSource = dt;
            cmbSubject.DisplayMember = "SubjectName";
            cmbSubject.ValueMember = "SubjectID";
            cmbSubject.SelectedIndex = -1;
        }

        private void LoadExamData()
        {
            examGrid.DataSource = controller.GetAllExams();
            // Don't call LoadSubjects() here again
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbSubject.SelectedIndex == -1 || string.IsNullOrWhiteSpace(texam.Text))
            {
                MessageBox.Show("Please select a subject and enter an exam name.");
                return;
            }

            var exam = new Exam
            {
                SubjectID = Convert.ToInt32(cmbSubject.SelectedValue),
                ExamName = texam.Text.Trim()
            };
            controller.AddExam(exam);
            LoadExamData();
            texam.Clear();
            cmbSubject.SelectedIndex = -1;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedExamId == -1)
            {
                MessageBox.Show("Please select an exam to update.");
                return;
            }

            var exam = new Exam
            {
                ExamID = selectedExamId,
                SubjectID = Convert.ToInt32(cmbSubject.SelectedValue),
                ExamName = texam.Text.Trim()
            };
            controller.UpdateExam(exam);
            LoadExamData();
            texam.Clear();
            selectedExamId = -1;
            cmbSubject.SelectedIndex = -1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedExamId == -1)
            {
                MessageBox.Show("Please select an exam to delete.");
                return;
            }

            controller.DeleteExam(selectedExamId);
            LoadExamData();
            texam.Clear();
            selectedExamId = -1;
            cmbSubject.SelectedIndex = -1;
        }

        private void examGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = examGrid.Rows[e.RowIndex];
            selectedExamId = Convert.ToInt32(row.Cells["ExamID"].Value);
            texam.Text = row.Cells["ExamName"].Value.ToString();
            cmbSubject.SelectedValue = Convert.ToInt32(row.Cells["SubjectID"].Value);
        }

        
    }
}
