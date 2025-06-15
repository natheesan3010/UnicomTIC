using System;
using System.Data;
using System.Windows.Forms;
using Unicom_TIC_Management_System__UMS_.Controllers;

namespace Unicom_TIC_Management_System__UMS_.Views
{
    public partial class MarkForm : Form
    {
        private MarkController controller;

        public MarkForm()
        {
            InitializeComponent();
            controller = new MarkController();
        }

        private void MarkForm_Load(object sender, EventArgs e)
        {
            LoadStudents();
            LoadExams();
            LoadMarks();
        }

        private void LoadStudents()
        {
            comboBoxStudent.DataSource = controller.GetStudents();
            comboBoxStudent.DisplayMember = "StudentName";
            comboBoxStudent.ValueMember = "StudentID";
        }

        private void LoadExams()
        {
            comboBoxExam.DataSource = controller.GetExams();
            comboBoxExam.DisplayMember = "ExamName";
            comboBoxExam.ValueMember = "ExamID";
        }

        private void LoadMarks()
        {
            dataGridViewMarks.DataSource = controller.GetAllMarks();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int studentId = Convert.ToInt32(comboBoxStudent.SelectedValue);
            int examId = Convert.ToInt32(comboBoxExam.SelectedValue);
            int score;

            if (!int.TryParse(textBoxScore.Text, out score) || score < 0 || score > 100)
            {
                MessageBox.Show("Score must be between 0 and 100.");
                return;
            }

            controller.AddMark(studentId, examId, score);
            MessageBox.Show("Mark added successfully.");
            LoadMarks();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewMarks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a mark to update.");
                return;
            }

            int markId = Convert.ToInt32(dataGridViewMarks.SelectedRows[0].Cells["MarkID"].Value);
            int studentId = Convert.ToInt32(comboBoxStudent.SelectedValue);
            int examId = Convert.ToInt32(comboBoxExam.SelectedValue);
            int score;

            if (!int.TryParse(textBoxScore.Text, out score) || score < 0 || score > 100)
            {
                MessageBox.Show("Score must be between 0 and 100.");
                return;
            }

            controller.UpdateMark(markId, studentId, examId, score);
            MessageBox.Show("Mark updated successfully.");
            LoadMarks();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewMarks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a mark to delete.");
                return;
            }

            int markId = Convert.ToInt32(dataGridViewMarks.SelectedRows[0].Cells["MarkID"].Value);
            DialogResult result = MessageBox.Show("Are you sure you want to delete this mark?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                controller.DeleteMark(markId);
                MessageBox.Show("Mark deleted successfully.");
                LoadMarks(); 
            }
        }

    }
}
