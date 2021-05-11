using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms.BunifuButton;
using Time_Table_Management_System.DBConnection;
using Time_Table_Management_System.Model;
using Time_Table_Management_System.Controller;

namespace Time_Table_Management_System
{
    public partial class AddRooms : Form
    {
       
        DBcon DBConnection = new DBcon();
        SqlConnection con = new SqlConnection();

        roomControl roomControl = new roomControl();
        locationModel locationModel = new locationModel();

        //constructor
        public AddRooms()
        {
            InitializeComponent();
            con = DBConnection.getDBConnection();
            
        }

        private void AddRooms_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tLMDataSet.locationTB' table. You can move, or remove it, as needed.
            this.locationTBTableAdapter.Fill(this.tLMDataSet.locationTB);
            
        }

        //insert rooms data
        private void addbtn_Click(object sender, EventArgs e)
        {
          
                locationModel.buildingname = bNameDropdown.Text;
                locationModel.roomname = addRoomName.Text;
                locationModel.capacity = int.Parse(addCapacity.Text);
           
           
            if (rbLab.Checked = true)
            {
                locationModel.roomType = "Lecture Hall";

            }
            else if (rbLecHall.Checked = true)
                locationModel.roomType = "Laboratory";

            
           
            roomControl.insertRoomDetails(locationModel);

            clearAll();
        }

        //clear button
        private void clearbtn_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        //all clear method
        private void clearAll()
        {
            bNameDropdown.SelectedIndex = -1;
            addRoomName.Clear();
            addCapacity.Clear();
            rbLecHall.Checked = false;
            rbLab.Checked = false;
            
        }


    }
}
