using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace Unicom_TIC_Management_System__UMS_.Views
{
    public partial class StudentForm : Form
    {
        // 1️⃣ Single shared connection for the form
        private SQLiteConnection _conn;

        private int selectedStudentId = -1;

        public StudentForm()
        {
            InitializeComponent();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            string dbPath = Path.Combine(Application.StartupPath, "unicomtic.db");
            _conn = new SQLiteConnection($"Data Source={dbPath};Version=3;");
            _conn.Open();
            LoadStudentData();
        }

        private void StudentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _conn?.Dispose();
        }

        /* ----------  Add  ---------- */
        private void btn_add_Click(object sender, EventArgs e)
        {
            string name = tname.Text.Trim();
            string nic = tnic.Text.Trim();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(nic))
            {
                MessageBox.Show("Please enter both Name and Address.");
                return;
            }

            const string sql =
                "INSERT INTO Students (StudentName, NIC) VALUES (@StudentName, @NIC)";

            using (var cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@StudentName", name);
                cmd.Parameters.AddWithValue("@NIC", nic);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Student added successfully.");
            tname.Clear();
            tnic.Clear();
            LoadStudentData();
        }

        /* ----------  Grid helper  ---------- */
        private void LoadStudentData()
        {
            const string sql = "SELECT StudentID, StudentName, NIC FROM Students"; 
            using (var da = new SQLiteDataAdapter(sql, _conn))
            {
                var dt = new DataTable();
                da.Fill(dt);
                student_data.DataSource = dt;
            }
        }

        private void student_data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = student_data.Rows[e.RowIndex];
            selectedStudentId = Convert.ToInt32(row.Cells["StudentID"].Value);
            tname.Text = row.Cells["StudentName"].Value.ToString();
            tnic.Text = row.Cells["NIC"].Value.ToString();
        }

        

        /* ----------  Update  ---------- */
        private void btn_update_Click(object sender, EventArgs e)
        {
            if (selectedStudentId == -1)
            {
                MessageBox.Show("Please select a student to update.");
                return;
            }

            string name = tname.Text.Trim();
            string nic = tnic.Text.Trim();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(nic))
            {
                MessageBox.Show("Please Enter The Name and NIC.");
                return;
            }

            const string sql =
                "UPDATE Students " +
                "SET StudentName = @StudentName, NIC_NO = @NIC_NO " +
                "WHERE Id = @Id";

            using (var cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@StudentName", name);
                cmd.Parameters.AddWithValue("@NIC_NO", nic);
                cmd.Parameters.AddWithValue("@Id", selectedStudentId);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Student updated successfully.");
            selectedStudentId = -1;
            tname.Clear();
            tnic.Clear();
            LoadStudentData();
        }

        private void btn_delete_Click_1(object sender, EventArgs e)
        {
            {
                if (selectedStudentId == -1)
                {
                    MessageBox.Show("Please select a student to delete.");
                    return;
                }

                const string sql = "DELETE FROM Students WHERE ID= @ID";
                using (var cmd = new SQLiteCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@ID", selectedStudentId);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Student deleted successfully.");
                selectedStudentId = -1;
                tname.Clear();
                tnic.Clear();
                LoadStudentData();
            }
        }
    }
}
