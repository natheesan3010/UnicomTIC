using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using Unicom_TIC_Management_System__UMS_.Controllers;
using Unicom_TIC_Management_System__UMS_.Repositories;

namespace Unicom_TIC_Management_System__UMS_.Views
{
    public partial class CourseForm : Form
    {
        private int selectedCourseId = -1;
        private SQLiteConnection conn;
        private CourseController courseController;

        public CourseForm()
        {
            InitializeComponent();
            conn = DbCon.GetConnection(); // Use centralized DbCon
            courseController = new CourseController();
            LoadCourses();
        }

        private void LoadCourses()
        {
            dgvCourse.DataSource = courseController.GetAllCourses();
            dgvCourse.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCourse.AutoGenerateColumns = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string courseName = txtCourseName.Text.Trim();

            if (string.IsNullOrWhiteSpace(courseName))
            {
                MessageHelper.ShowError("Please enter the course name.");
                return;
            }

            if (courseController.AddCourse(courseName))
            {
                MessageHelper.ShowSuccess("Course added successfully!");
                txtCourseName.Clear();
                selectedCourseId = -1;
                LoadCourses();
            }
            else
            {
                MessageHelper.ShowError("Failed to add course.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedCourseId == -1)
            {
                MessageHelper.ShowError("Please select a course to update.");
                return;
            }

            string courseName = txtCourseName.Text.Trim();
            if (string.IsNullOrWhiteSpace(courseName))
            {
                MessageHelper.ShowError("Please enter the course name.");
                return;
            }

            courseController.UpdateCourse(selectedCourseId, courseName);
            MessageHelper.ShowSuccess("Course updated successfully!");
            txtCourseName.Clear();
            selectedCourseId = -1;
            LoadCourses();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedCourseId == -1)
            {
                MessageHelper.ShowConfirm("Please select a course to delete.");
                return;
            }

            courseController.DeleteCourse(selectedCourseId);

            // Reset AUTOINCREMENT if table empty
            string countQuery = "SELECT COUNT(*) FROM Courses";
            using (SQLiteCommand countCmd = new SQLiteCommand(countQuery, conn))
            {
                int count = Convert.ToInt32(countCmd.ExecuteScalar());
                if (count == 0)
                {
                    string resetQuery = "DELETE FROM sqlite_sequence WHERE name='Courses';";
                    using (SQLiteCommand resetCmd = new SQLiteCommand(resetQuery, conn))
                    {
                        resetCmd.ExecuteNonQuery();
                    }
                }
            }

            MessageBox.Show("Course deleted successfully!");
            txtCourseName.Clear();
            selectedCourseId = -1;
            LoadCourses();
        }

        private void dgvCourse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCourse.Rows[e.RowIndex];

                if (row.Cells["CourseID"].Value != null)
                {
                    selectedCourseId = Convert.ToInt32(row.Cells["CourseID"].Value);
                    txtCourseName.Text = row.Cells["CourseName"].Value?.ToString();
                }
            }
        }

        private void dgvCourse_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCourse.Rows[e.RowIndex];

                if (row.Cells["CourseID"].Value != null)
                {
                    selectedCourseId = Convert.ToInt32(row.Cells["CourseID"].Value);
                    txtCourseName.Text = row.Cells["CourseName"].Value?.ToString();
                }
            }
        }

        private void CourseForm_Load(object sender, EventArgs e)
        {
            // Optional
        }
    }
}
