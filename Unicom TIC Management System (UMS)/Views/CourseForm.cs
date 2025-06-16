using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Unicom_TIC_Management_System__UMS_.Views
{
    public partial class CourseForm : Form
    {
        private int selectedCourseId = -1;
        private SQLiteConnection conn;

        public CourseForm()
        {
            InitializeComponent();
            conn = new SQLiteConnection("Data Source=unicomtic.db;Version=3;");
            conn.Open();
            LoadCourses();
        }

        private void LoadCourses()
        {
            string query = "SELECT CourseID AS Id, CourseName FROM Courses";
            using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
            using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvCourse.DataSource = dt;
            }
            dgvCourse.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCourse.AutoGenerateColumns = true;  // இதும் சேர்த்திருக்கவும்
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            string coursename = txtCourseName.Text.Trim();

            if (string.IsNullOrWhiteSpace(coursename))
            {
                MessageBox.Show("Please Add The Course Name.");
                return;
            }

            string query = "INSERT INTO Courses (CourseName) VALUES (@CourseName)";
            using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@CourseName", coursename);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Course Add Successfully! ");
            txtCourseName.Clear();
            selectedCourseId = -1;
            LoadCourses();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedCourseId == -1)
            {
                MessageBox.Show("Please Select The Course!");
                return;
            }

            string coursename = txtCourseName.Text.Trim();

            if (string.IsNullOrWhiteSpace(coursename))
            {
                MessageBox.Show("Please Add The Course Name.");
                return;
            }

            string query = "UPDATE Courses SET CourseName = @CourseName WHERE CourseID = @Id";
            using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@CourseName", coursename);
                cmd.Parameters.AddWithValue("@Id", selectedCourseId);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Course Update Successfully!");
            txtCourseName.Clear();
            selectedCourseId = -1;
            LoadCourses();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedCourseId == -1)
            {
                MessageBox.Show("Please select a course to delete.");
                return;
            }

            // Delete course using existing open connection
            string query = "DELETE FROM Courses WHERE CourseID = @Id";
            using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Id", selectedCourseId);
                cmd.ExecuteNonQuery();
            }

            // Check if table is empty and reset AUTOINCREMENT
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
                // Console அல்லது MessageBox கொண்டு columns inspect பண்ணவும்:
                string courseIdStr = row.Cells["Id"].Value?.ToString();
                string courseNameStr = row.Cells["CourseName"].Value?.ToString();

                if (!string.IsNullOrEmpty(courseIdStr))
                    selectedCourseId = Convert.ToInt32(courseIdStr);

                if (!string.IsNullOrEmpty(courseNameStr))
                    txtCourseName.Text = courseNameStr;
                else
                    txtCourseName.Text = "";
            }
        }



        private void CourseForm_Load(object sender, EventArgs e)
        {

        }

        private void dgvCourse_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCourse.Rows[e.RowIndex];

                // CourseID (Id) மற்றும் CourseName textbox-ல் நிரப்புங்கள்
                selectedCourseId = Convert.ToInt32(row.Cells["Id"].Value);
                txtCourseName.Text = row.Cells["CourseName"].Value.ToString();
            }
        }
    }
}
