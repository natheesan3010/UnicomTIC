using System;
using System.Data;
using System.Windows.Forms;
using Unicom_TIC_Management_System__UMS_.Controllers;
using Unicom_TIC_Management_System__UMS_.Models;
using System.Data.SQLite;

namespace Unicom_TIC_Management_System__UMS_.Views
{
    public partial class AttendanceForm : Form
    {
        private AttendanceController controller = new AttendanceController();

        public AttendanceForm()
        {
            InitializeComponent();
            LoadSubjects();
            comboBoxStatus.Items.AddRange(new string[] { "Present", "Absent", "Late", "Excused" });
            RefreshGrid();
        }

        private void LoadSubjects()
        {
            var conn = new SQLiteConnection("Data Source=unicomtic.db");
            conn.Open();
            var cmd = new SQLiteCommand("SELECT SubjectID, SubjectName FROM Subjects", conn);
            var dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            comboBoxSubject.DisplayMember = "SubjectName";
            comboBoxSubject.ValueMember = "SubjectID";
            comboBoxSubject.DataSource = dt;
        }

        private void RefreshGrid()
        {
            dgvAttendance.DataSource = controller.GetAllAttendance();
        }

        private void btnMarkAttendance_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                Attendance attendance = new Attendance
                {
                    StudentID = int.Parse(textBoxStudentID.Text),
                    SubjectID = Convert.ToInt32(comboBoxSubject.SelectedValue),
                    Date = DatePicker.Value,
                    Status = comboBoxStatus.Text
                };
                controller.AddAttendance(attendance);
                RefreshGrid();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                Attendance attendance = new Attendance
                {
                    StudentID = int.Parse(textBoxStudentID.Text),
                    SubjectID = Convert.ToInt32(comboBoxSubject.SelectedValue),
                    Date = DatePicker.Value,
                    Status = comboBoxStatus.Text
                };
                controller.UpdateAttendance(attendance);
                RefreshGrid();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvAttendance.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvAttendance.CurrentRow.Cells["AttendanceID"].Value);
                controller.DeleteAttendance(id);
                RefreshGrid();
            }
        }

        private void dgvAttendance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvAttendance.Rows[e.RowIndex];
                textBoxStudentID.Text = row.Cells["StudentID"].Value.ToString();
                textBoxStudentName.Text = row.Cells["StudentName"].Value.ToString();
                comboBoxSubject.Text = row.Cells["SubjectName"].Value.ToString();
                comboBoxStatus.Text = row.Cells["Status"].Value.ToString();
                DatePicker.Value = DateTime.Parse(row.Cells["Date"].Value.ToString());
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(textBoxStudentID.Text))
            {
                MessageBox.Show("Student ID is required.");
                return false;
            }

            if (comboBoxSubject.SelectedIndex == -1 || string.IsNullOrEmpty(comboBoxStatus.Text))
            {
                MessageBox.Show("Please select a subject and status.");
                return false;
            }

            return true;
        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            DatePicker.Text = DatePicker.Value.ToString("MM/dd/yyyy"); 
        }

    }
}
