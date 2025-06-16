using System;
using System.Windows.Forms;
using Unicom_TIC_Management_System__UMS_.Controllers;
using Unicom_TIC_Management_System__UMS_.Models;

namespace Unicom_TIC_Management_System__UMS_.Views
{
    public partial class RoomForm : Form
    {
        private RoomController controller = new RoomController();

        public RoomForm()
        {
            InitializeComponent();
        }

        private void RoomForm_Load(object sender, EventArgs e)
        {
            LoadRooms();

            // RoomName combo box
            cmbRoomName.Items.Clear();
            cmbRoomName.Items.Add("Lecture Hall");
            cmbRoomName.Items.Add("MainLab");
            cmbRoomName.Items.Add("MinLab1");
            cmbRoomName.Items.Add("MinLab2");

            // RoomType combo box
            cmbRoomType.Items.Clear();
            cmbRoomType.Items.Add("AC");
            cmbRoomType.Items.Add("NON AC");

            // Reset combo box selection
            cmbRoomName.SelectedIndex = -1;
            cmbRoomType.SelectedIndex = -1;
        }

        private void LoadRooms()
        {
            dgvRooms.DataSource = controller.GetAllRooms();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbRoomName.Text) || cmbRoomType.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            Room room = new Room()
            {
                RoomName = cmbRoomName.Text.Trim(),
                RoomType = cmbRoomType.SelectedItem.ToString()
            };

            controller.AddRoom(room);
            MessageBox.Show("Room added successfully.");
            LoadRooms();
            ResetForm();
        }

        private void ResetForm()
        {
            cmbRoomName.SelectedIndex = -1;
            cmbRoomType.SelectedIndex = -1;
        }

        private void cmbRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
