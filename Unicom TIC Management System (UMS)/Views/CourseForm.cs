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

        private void btnAdd_Click(object sender, EventArgs e)
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedCourseId != -1 && !string.IsNullOrEmpty(txtCourseName.Text))
            {
                controller.UpdateCourse(selectedCourseId, txtCourseName.Text.Trim());
                LoadCourses();
                txtCourseName.Clear();
                selectedCourseId = -1;
            }
            else
            {
                MessageBox.Show("Select a course and enter new name");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedCourseId != -1)
            {
                controller.DeleteCourse(selectedCourseId);
                LoadCourses();
                txtCourseName.Clear();
                selectedCourseId = -1;
            }
            else
            {
                MessageBox.Show("Select a course to delete");
            }
        }

        private void dgvCourse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedCourseId = Convert.ToInt32(dgvCourse.Rows[e.RowIndex].Cells["Id"].Value);
                txtCourseName.Text = dgvCourse.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            }
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
    }
}
