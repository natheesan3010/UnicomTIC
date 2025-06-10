using System;
using System.Windows.Forms;
using Unicom_TIC_Management_System__UMS_.Controllers;

namespace Unicom_TIC_Management_System__UMS_.Views
{
    public partial class CourseForm : Form
    {
        private CourseController controller = new CourseController();
        private int selectedCourseId = -1;

        public CourseForm()
        {
            InitializeComponent();
            LoadCourses();
        }

        private void LoadCourses()
        {
            dgvCourse.DataSource = controller.GetAllCourses();
        }

        

        // btnAdd_Click_1 not needed anymore
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCourseName.Text))
            {
                bool result = controller.AddCourse(txtCourseName.Text.Trim());
                if (result)
                {
                    LoadCourses();
                    txtCourseName.Clear();
                }
                else
                {
                    MessageBox.Show("Failed to add course. Check DB connection or controller logic.");
                }
            }
            else
            {
                MessageBox.Show("Enter course name");
            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (selectedCourseId != -1 && !string.IsNullOrWhiteSpace(txtCourseName.Text))
            {
                if (controller.UpdateCourse(selectedCourseId, txtCourseName.Text.Trim()))
                {
                    LoadCourses();
                    txtCourseName.Clear();
                    selectedCourseId = -1;
                    MessageBox.Show("Course updated successfully!");
                }
                else
                {
                    MessageBox.Show("Error updating course.");
                }
            }
            else
            {
                MessageBox.Show("Please select a course and enter a new name.");
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (selectedCourseId != -1)
            {
                var confirmResult = MessageBox.Show("Are you sure to delete this course?",
                    "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    if (controller.DeleteCourse(selectedCourseId))
                    {
                        LoadCourses();
                        txtCourseName.Clear();
                        selectedCourseId = -1;
                        MessageBox.Show("Course deleted successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Error deleting course.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a course to delete.");
            }
        }

        private void CourseForm_Load(object sender, EventArgs e)
        {

        }

        private void dgvCourse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCourse.Rows[e.RowIndex];
                selectedCourseId = Convert.ToInt32(dgvCourse.Rows[e.RowIndex].Cells[0].Value);
                txtCourseName.Text = dgvCourse.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

    }
}
