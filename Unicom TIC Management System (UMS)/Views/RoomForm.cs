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
            cmbRoomType.Items.Add("Lab");
            cmbRoomType.Items.Add("Hall");
        }

        private void LoadRooms()
        {
            dgvRooms.DataSource = controller.GetAllRooms();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRoomName.Text) || cmbRoomType.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            Room room = new Room()
            {
                RoomName = txtRoomName.Text.Trim(),
                RoomType = cmbRoomType.SelectedItem.ToString()
            };

            controller.AddRoom(room);
            MessageBox.Show("Room added successfully.");
            LoadRooms();
            ResetForm();
        }

        private void ResetForm()
        {
            txtRoomName.Clear();
            cmbRoomType.SelectedIndex = -1;
        }
    }
}
