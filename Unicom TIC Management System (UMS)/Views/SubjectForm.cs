using System;
using System.Data;
using System.Windows.Forms;
using Unicom_TIC_Management_System__UMS_.Controllers;
using Unicom_TIC_Management_System__UMS_.Models;

namespace Unicom_TIC_Management_System__UMS_.Views
{
    public partial class SubjectForm : Form
    {
        private SubjectController controller = new SubjectController();
        private int selectedSubjectId = -1;

        public SubjectForm()
        {
            InitializeComponent();
        }

        private void SubjectForm_Load(object sender, EventArgs e)
        {
            LoadCourses();
            LoadSubjects();
            cmbCourses.SelectedIndex = -1;
        }

        private void LoadCourses()
        {
            cmbCourses.DataSource = controller.GetCourses();
            cmbCourses.DisplayMember = "CourseName";
            cmbCourses.ValueMember = "CourseID";
        }

        private void LoadSubjects()
        {
            dgvsubject.DataSource = controller.GetAllSubjects();
            dgvsubject.Columns["CourseID"].Visible = false;
        }

        private void dgvsubject_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvsubject.Rows[e.RowIndex];
                selectedSubjectId = Convert.ToInt32(row.Cells["SubjectID"].Value);
                txtSubjectName.Text = row.Cells["SubjectName"].Value.ToString();
                cmbCourses.SelectedValue = row.Cells["CourseID"].Value;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSubjectName.Text) || cmbCourses.SelectedValue == null)
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            var subject = new Subject
            {
                SubjectName = txtSubjectName.Text.Trim(),
                CourseID = Convert.ToInt32(cmbCourses.SelectedValue)
            };

            controller.AddSubject(subject);
            LoadSubjects();
            ResetForm();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedSubjectId == -1 || string.IsNullOrWhiteSpace(txtSubjectName.Text))
            {
                MessageBox.Show("Please select a subject to update.");
                return;
            }

            var subject = new Subject
            {
                SubjectID = selectedSubjectId,
                SubjectName = txtSubjectName.Text.Trim(),
                CourseID = Convert.ToInt32(cmbCourses.SelectedValue)
            };

            controller.UpdateSubject(subject);
            LoadSubjects();
            ResetForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedSubjectId == -1)
            {
                MessageBox.Show("Please select a subject to delete.");
                return;
            }

            var result = MessageBox.Show("Are you sure you want to delete this subject?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                controller.DeleteSubject(selectedSubjectId);
                LoadSubjects();
                ResetForm();
            }
        }

        private void ResetForm()
        {
            txtSubjectName.Clear();
            cmbCourses.SelectedIndex = -1;
            selectedSubjectId = -1;
        }

    }
}
