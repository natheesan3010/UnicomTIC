using System;
using System.Data;
using System.Windows.Forms;
using Unicom_TIC_Management_System__UMS_.Controllers;
using Unicom_TIC_Management_System__UMS_.Models;
using Unicom_TIC_Management_System__UMS_.Repositories;

namespace Unicom_TIC_Management_System__UMS_.Views
{
    public partial class ExamForm : Form
    {
        private ExamController controller = new ExamController();
        private int selectedExamId = -1;

        public ExamForm()
        {
            InitializeComponent();
            this.Load += ExamForm_Load;
            examGrid.CellClick += examGrid_CellClick;

            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            btnAdd.Click += button1_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
        }

        private void ExamForm_Load(object sender, EventArgs e)
        {
            LoadSubjects();
            LoadExamData();
            ClearFields();
        }

        private void LoadSubjects()
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Error loading subjects: " + ex.Message);
            }
        }

        private void LoadExamData()
        {
            try
            {
                examGrid.DataSource = controller.GetAllExams();

                if (examGrid.Columns["ExamID"] != null)
                    examGrid.Columns["ExamID"].HeaderText = "Exam ID";

                if (examGrid.Columns["ExamName"] != null)
                    examGrid.Columns["ExamName"].HeaderText = "Exam Name";

                if (examGrid.Columns["SubjectID"] != null)
                    examGrid.Columns["SubjectID"].Visible = false;

                if (examGrid.Columns["SubjectName"] != null)
                    examGrid.Columns["SubjectName"].HeaderText = "Subject";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading exams: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbSubject.SelectedIndex == -1 || string.IsNullOrWhiteSpace(texam.Text))
            {
                MessageBox.Show("Please select a subject and enter an exam name.");
                return;
            }

            try
            {
                var exam = new Exam
                {
                    SubjectID = Convert.ToInt32(cmbSubject.SelectedValue),
                    ExamName = texam.Text.Trim()
                };
                controller.AddExam(exam);
                LoadExamData();
                ClearFields();
                MessageBox.Show("Exam added successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding exam: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedExamId == -1)
            {
                MessageBox.Show("Please select an exam to update.");
                return;
            }

            if (cmbSubject.SelectedIndex == -1 || string.IsNullOrWhiteSpace(texam.Text))
            {
                MessageHelper.ShowError("Please select a subject and enter an exam name.");
                return;
            }

            try
            {
                var exam = new Exam
                {
                    ExamID = selectedExamId,
                    SubjectID = Convert.ToInt32(cmbSubject.SelectedValue),
                    ExamName =texam.Text.Trim()
                };
                controller.UpdateExam(exam);
                LoadExamData();
                ClearFields();
                MessageHelper.ShowSuccess("Exam updated successfully.");
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError("Error updating exam: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedExamId == -1)
            {
                MessageHelper.ShowError("Please select an exam to delete.");
                return;
            }

            bool confirm = MessageHelper.ShowConfirm("Are you sure you want to delete this exam?");
            if (!confirm) return;

            controller.DeleteExam(selectedExamId);
            LoadExamData();
            ClearFields();
            MessageHelper.ShowSuccess("Exam deleted successfully!");
        }
        

        private void examGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                var row = examGrid.Rows[e.RowIndex];
                selectedExamId = Convert.ToInt32(row.Cells["ExamID"].Value);
                texam.Text = row.Cells["ExamName"].Value.ToString();
                cmbSubject.SelectedValue = Convert.ToInt32(row.Cells["SubjectID"].Value);

                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                btnAdd.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError("Error selecting exam: " + ex.Message);
            }
        }

        private void ClearFields()
        {
            texam.Clear();
            cmbSubject.SelectedIndex = -1;
            selectedExamId = -1;

            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnAdd.Enabled = true;
        }
    }
}
