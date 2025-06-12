using System;
using System.Data;
using System.Windows.Forms;
using Unicom_TIC_Management_System__UMS_.Controllers;
using Unicom_TIC_Management_System__UMS_.Models;

namespace Unicom_TIC_Management_System__UMS_.Views
{
    public partial class StudentForm : Form
    {
        private StudentController controller;
        private int selectedStudentId = -1;

        public StudentForm()
        {
            InitializeComponent();
            controller = new StudentController();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            LoadStudentData();
        }

        private void StudentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            controller.CloseConnection();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            var student = new Student
            {
                StudentName = tname.Text.Trim(),
                NIC_NO = tnic.Text.Trim()
            };

            if (string.IsNullOrWhiteSpace(student.StudentName) || string.IsNullOrWhiteSpace(student.NIC_NO))
            {
                MessageBox.Show("Name மற்றும் NIC-ஐ உள்ளிடவும்.");
                return;
            }

            controller.AddStudent(student);
            ClearInputs();
            LoadStudentData();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (selectedStudentId == -1)
            {
                MessageBox.Show("முதலில் ஒரு மாணவரைத் தேர்ந்தெடுக்கவும்.");
                return;
            }

            var student = new Student
            {
                StudentID = selectedStudentId,
                StudentName = tname.Text.Trim(),
                NIC_NO = tnic.Text.Trim()
            };

            controller.UpdateStudent(student);
            ClearInputs();
            LoadStudentData();
        }

        private void btn_delete_Click_1(object sender, EventArgs e)
        {
            if (selectedStudentId == -1)
            {
                MessageBox.Show("முதலில் ஒரு மாணவரைத் தேர்ந்தெடுக்கவும்.");
                return;
            }

            controller.DeleteStudent(selectedStudentId);
            ClearInputs();
            LoadStudentData();
        }

        private void student_data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = student_data.Rows[e.RowIndex];
            selectedStudentId = Convert.ToInt32(row.Cells["StudentID"].Value);
            tname.Text = row.Cells["StudentName"].Value.ToString();
            tnic.Text = row.Cells["NIC"].Value.ToString();
        }

        private void LoadStudentData()
        {
            student_data.DataSource = controller.GetAllStudents();
        }

        private void ClearInputs()
        {
            tname.Clear();
            tnic.Clear();
            selectedStudentId = -1;
        }
    }
}
