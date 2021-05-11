using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Time_Table_Management_System.DBConnection;
using Time_Table_Management_System.Model;
using Time_Table_Management_System.Controller;

namespace Time_Table_Management_System
{
    public partial class ManageLocation : Form
    {

        roomControl roomControl = new roomControl();
        locationModel locationModel = new locationModel();

        public ManageLocation()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tLMDataSet.locationTB' table. You can move, or remove it, as needed.
            this.locationTBTableAdapter.Fill(this.tLMDataSet.locationTB);
            bunifuDataGridView1.DataSource = roomControl.getRoomvalues();
        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            updRoomID.Text = bunifuDataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            updateBuildingDropdown.Text = bunifuDataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            updRoomName.Text = bunifuDataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            updCapacity.Text = bunifuDataGridView1.SelectedRows[0].Cells[3].Value.ToString();

            if (bunifuDataGridView1.SelectedRows[0].Cells[4].Value.ToString() == "Lecture Hall")
                updateLechallRB.Checked = true;
            else if (bunifuDataGridView1.SelectedRows[0].Cells[4].Value.ToString() == "Laboratory")
                updateLabRB.Checked = true;
            else
            {
                updateLechallRB.Checked = false;
                updateLabRB.Checked = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int x = int.Parse(updRoomID.Text);
            roomControl.DeleteRooomDet(x);

            clearall();

            bunifuDataGridView1.DataSource = roomControl.getRoomvalues();
        }

        private void btnUpdateRoom_Click(object sender, EventArgs e)
        {
            locationModel.roomID = int.Parse(updRoomID.Text);
            locationModel.buildingname = updateBuildingDropdown.Text;
            locationModel.roomname = updRoomName.Text;
            locationModel.capacity = int.Parse(updCapacity.Text);
           
            if (updateLechallRB.Checked = true)
                locationModel.roomType = "Lecture Hall";
            if (updateLabRB.Checked = true)
                locationModel.roomType = "Laboratory";

            roomControl.updateRoomDetails(locationModel);

            clearall();

            bunifuDataGridView1.DataSource = roomControl.getRoomvalues();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearall();
        }

        private void clearall()
        {
            updRoomID.Clear();
            updateBuildingDropdown.SelectedIndex = -1;
            updRoomName.Clear();
            updCapacity.Clear();
            updateLechallRB.Checked = false;
            updateLabRB.Checked = false;
        }
    }
}
