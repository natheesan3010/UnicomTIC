using System;
using System.Data;
using System.Windows.Forms;
using Unicom_TIC_Management_System__UMS_.Controllers;
using Unicom_TIC_Management_System__UMS_.Models;

namespace Unicom_TIC_Management_System__UMS_.Views
{
    public partial class TimetableForm : Form
    {
        private int selectedTimetableId = -1;
        private SubjectController subjectController = new SubjectController();
        private RoomController roomController = new RoomController();

        public TimetableForm()
        {
            InitializeComponent();
        }

        private void TimetableForm_Load(object sender, EventArgs e)
        {
            cmbSubject.DataSource = subjectController.GetAllSubjects();
            cmbSubject.DisplayMember = "SubjectName";
            cmbSubject.ValueMember = "SubjectID";

            cmbTimeSlot.Items.AddRange(new string[]
            {
        "Monday 10 AM",
        "Monday 2 PM",
        "Tuesday 10 AM",
        "Tuesday 2 PM",
        "Wednesday 10 AM"
            });

            // Room ComboBox
            cmbRoom.DataSource = roomController.GetAllRooms();  // object மூலம் அழைக்கப்பட்டது
            cmbRoom.DisplayMember = "RoomName";
            cmbRoom.ValueMember = "RoomID";

            LoadTimetables();
        }


        private void LoadTimetables()
        {
            gridTimetable.DataSource = TimetableController.GetTimetables();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbSubject.SelectedValue == null || cmbTimeSlot.SelectedItem == null || cmbRoom.SelectedValue == null)
            {
                MessageBox.Show("Please select all fields.");
                return;
            }

            Timetable entry = new Timetable
            {
                SubjectID = Convert.ToInt32(cmbSubject.SelectedValue),
                TimeSlot = cmbTimeSlot.SelectedItem.ToString(),
                RoomID = Convert.ToInt32(cmbRoom.SelectedValue)
            };

            TimetableController.AddTimetable(entry);
            LoadTimetables();
            MessageBox.Show("Timetable entry added successfully.");
        }

        private void gridTimetable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = gridTimetable.Rows[e.RowIndex];
            selectedTimetableId = Convert.ToInt32(row.Cells["TimetableID"].Value);

            cmbSubject.Text = row.Cells["SubjectName"].Value.ToString();
            cmbTimeSlot.Text = row.Cells["TimeSlot"].Value.ToString();
            cmbRoom.Text = row.Cells["RoomName"].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedTimetableId == -1)
            {
                MessageBox.Show("Please select a timetable entry to update.");
                return;
            }

            Timetable updatedEntry = new Timetable
            {
                TimetableID = selectedTimetableId,
                SubjectID = Convert.ToInt32(cmbSubject.SelectedValue),
                TimeSlot = cmbTimeSlot.SelectedItem.ToString(),
                RoomID = Convert.ToInt32(cmbRoom.SelectedValue)
            };

            TimetableController.UpdateTimetable(updatedEntry);
            LoadTimetables();
            MessageBox.Show("Timetable entry updated successfully.");

            // reset selection
            selectedTimetableId = -1;
        }

        private void cmbRoom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
