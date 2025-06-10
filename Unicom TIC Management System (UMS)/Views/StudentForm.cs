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
            string address = taddress.Text.Trim();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show("Please enter both Name and Address.");
                return;
            }

            const string sql =
                "INSERT INTO Students (StudentName, NIC_NO) VALUES (@StudentName, @NIC_NO)";

            using (var cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@StudentName", name);
                cmd.Parameters.AddWithValue("@NIC_NO", address);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Student added successfully.");
            tname.Clear();
            taddress.Clear();
            LoadStudentData();
        }

        /* ----------  Grid helper  ---------- */
        private void LoadStudentData()
        {
            const string sql = "SELECT Id, StudentName, NIC_NO FROM Students";
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
            selectedStudentId = Convert.ToInt32(row.Cells["Id"].Value);
            tname.Text = row.Cells["StudentName"].Value.ToString();
            taddress.Text = row.Cells["NIC_NO"].Value.ToString();
        }

        /* ----------  Delete  ---------- */
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (selectedStudentId == -1)
            {
                MessageBox.Show("Please select a student to delete.");
                return;
            }

            const string sql = "DELETE FROM Students WHERE Id = @Id";
            using (var cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@Id", selectedStudentId);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Student deleted successfully.");
            selectedStudentId = -1;
            tname.Clear();
            taddress.Clear();
            LoadStudentData();
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
            string address = taddress.Text.Trim();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show("Please enter both Name and Address.");
                return;
            }

            const string sql =
                "UPDATE Students " +
                "SET StudentName = @StudentName, NIC_NO = @NIC_NO " +
                "WHERE Id = @Id";

            using (var cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@StudentName", name);
                cmd.Parameters.AddWithValue("@NIC_NO", address);
                cmd.Parameters.AddWithValue("@Id", selectedStudentId);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Student updated successfully.");
            selectedStudentId = -1;
            tname.Clear();
            taddress.Clear();
            LoadStudentData();
        }
    }
}
