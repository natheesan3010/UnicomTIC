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
            LoadCourses();         // Load courses into the ComboBox
            LoadStudentData();     // Load students into the DataGridView
        }

        private void StudentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            controller.CloseConnection();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tname.Text) || string.IsNullOrWhiteSpace(tnic.Text) || cmbcourse.SelectedIndex == -1)
            {
                MessageBox.Show("Please enter Name, NIC, and select a Course.");
                return;
            }

            var student = new Student
            {
                StudentName = tname.Text.Trim(),
                NIC_NO = tnic.Text.Trim(),
                CourseID = Convert.ToInt32(cmbcourse.SelectedValue)
            };

            controller.AddStudent(student);
            ClearInputs();
            LoadStudentData();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (selectedStudentId == -1)
            {
                MessageBox.Show("Please select a student first.");
                return;
            }

            if (string.IsNullOrWhiteSpace(tname.Text) || string.IsNullOrWhiteSpace(tnic.Text) || cmbcourse.SelectedIndex == -1)
            {
                MessageBox.Show("Please enter Name, NIC, and select a Course.");
                return;
            }

            var student = new Student
            {
                StudentID = selectedStudentId,
                StudentName = tname.Text.Trim(),
                NIC_NO = tnic.Text.Trim(),
                CourseID = Convert.ToInt32(cmbcourse.SelectedValue)
            };

            controller.UpdateStudent(student);
            ClearInputs();
            LoadStudentData();
        }

        private void btn_delete_Click_1(object sender, EventArgs e)
        {
            if (selectedStudentId == -1)
            {
                MessageBox.Show("Please select a student first.");
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

            // Set selected course in combo box
            if (row.Cells["CourseID"].Value != DBNull.Value)
            {
                cmbcourse.SelectedValue = Convert.ToInt32(row.Cells["CourseID"].Value);
            }
        }

        private void LoadStudentData()
        {
            student_data.DataSource = controller.GetAllStudents();
        }

        private void LoadCourses()
        {
            DataTable dt = controller.GetAllCourses();
            cmbcourse.DisplayMember = "CourseName";
            cmbcourse.ValueMember = "CourseID";
            cmbcourse.DataSource = dt;
            cmbcourse.SelectedIndex = -1; // No course selected initially
        }

        private void ClearInputs()
        {
            tname.Clear();
            tnic.Clear();
            cmbcourse.SelectedIndex = -1;
            selectedStudentId = -1;
        }

        private void cmbcourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Optional: logic when a course is selected
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Optional: logic for filtering/searching students
        }
    }
}
