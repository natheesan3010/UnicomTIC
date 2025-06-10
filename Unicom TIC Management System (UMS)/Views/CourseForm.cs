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
            string query = "SELECT CourseId, CourseName FROM Courses";
            using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
            using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvCourse.DataSource = dt;
            }

            dgvCourse.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string coursename = txtCourseName.Text.Trim();

            if (string.IsNullOrWhiteSpace(coursename))
            {
                MessageBox.Show("Course Name இடுக.");
                return;
            }

            string query = "INSERT INTO Courses (CourseName) VALUES (@CourseName)";
            using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@CourseName", coursename);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Course வெற்றிகரமாக சேர்க்கப்பட்டது.");
            txtCourseName.Clear();
            selectedCourseId = -1;
            LoadCourses();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedCourseId == -1)
            {
                MessageBox.Show("தயவுசெய்து Course ஐ தேர்வு செய்யவும்.");
                return;
            }

            string coursename = txtCourseName.Text.Trim();

            if (string.IsNullOrWhiteSpace(coursename))
            {
                MessageBox.Show("Course Name இடுக.");
                return;
            }

            string query = "UPDATE Courses SET CourseName = @CourseName WHERE Id = @Id";
            using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@CourseName", coursename);
                cmd.Parameters.AddWithValue("@Id", selectedCourseId);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Course வெற்றிகரமாக புதுப்பிக்கப்பட்டது.");
            txtCourseName.Clear();
            selectedCourseId = -1;
            LoadCourses();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedCourseId == -1)
            {
                MessageBox.Show("Course தேர்வு செய்யவும்.");
                return;
            }

            string query = "DELETE FROM Courses WHERE Id = @Id";
            using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Id", selectedCourseId);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Course வெற்றிகரமாக நீக்கப்பட்டது.");
            txtCourseName.Clear();
            selectedCourseId = -1;
            LoadCourses();
        }

        private void dgvCourse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCourse.Rows[e.RowIndex];
                selectedCourseId = Convert.ToInt32(row.Cells["Id"].Value);
                txtCourseName.Text = row.Cells["CourseName"].Value.ToString();
            }
        }

        private void CourseForm_Load(object sender, EventArgs e)
        {

        }
    }
}
