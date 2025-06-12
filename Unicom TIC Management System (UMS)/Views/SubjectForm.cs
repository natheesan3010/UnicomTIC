using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Unicom_TIC_Management_System__UMS_.Views
{
    public partial class SubjectForm : Form
    {
        private string connectionString = "Data Source=unicomtic.db;Version=3;";
        private int selectedSubjectId = -1;

        public SubjectForm()
        {
            InitializeComponent();
        }

        private void SubjectForm_Load(object sender, EventArgs e)
        {
            LoadCoursesToComboBox();
            LoadSubjectsToGrid();
        }

        private void LoadCoursesToComboBox()
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT CourseID, CourseName FROM Courses";
                using (var cmd = new SQLiteCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    cobCourse.DisplayMember = "CourseName";
                    cobCourse.ValueMember = "CourseID";
                    cobCourse.DataSource = dt;
                }
            }
        }

        private void LoadSubjectsToGrid()
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = @"
                    SELECT s.SubjectID AS Id, s.SubjectName, c.CourseName, s.CourseID 
                    FROM Subjects s 
                    LEFT JOIN Courses c ON s.CourseID = c.CourseID";

                using (var cmd = new SQLiteCommand(query, conn))
                using (var adapter = new SQLiteDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvsubject.DataSource = dt;
                }
            }

            dgvsubject.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvsubject.AutoGenerateColumns = true;
        }

        private void dgvsubject_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvsubject.Rows[e.RowIndex];

                txtSubjectName.Text = row.Cells["SubjectName"].Value.ToString();

                if (row.Cells["CourseID"].Value != DBNull.Value)
                {
                    cobCourse.SelectedValue = Convert.ToInt32(row.Cells["CourseID"].Value);
                }
            }
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Optional: handle text changed
        }

        private void cob_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Optional: handle course selection change
        }

        private void btnadd_Click(object sender, EventArgs e)
        {

        }
    }
}
