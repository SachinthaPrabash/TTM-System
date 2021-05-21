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
using Time_Table_Management_System.DBConnection;
using Time_Table_Management_System.Model;
using Time_Table_Management_System.Controller;


namespace Time_Table_Management_System
{
    public partial class addlocation : Form
    {

        DBcon DBConnection = new DBcon();
        SqlConnection con = new SqlConnection();

        locationControl LocationControl = new locationControl();
        locationModel locationModel = new locationModel();

        //constructor
        public addlocation()
        {
            InitializeComponent();
            con = DBConnection.getDBConnection();
        }

        //insert location data 
        private void addbtn_Click(object sender, EventArgs e)
        {
            
           
        }

        //bind data from table to text
        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        //retrive data set to tabale
        private void addlocation_Load(object sender, EventArgs e)
        {
            bunifuDataGridView1.DataSource = LocationControl.getlocationvalues();
        }


        //all clear method
        private void clearAll()
        {
            addBuildingID.Clear();
            addBuildingname.Clear();
        }

        private void nullCheckValidate(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(addBuildingname.Text))
            {
                e.Cancel = true;
                addBuildingname.Focus();
                errorProvider1.SetError(addBuildingname, "Name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(addBuildingname, "");
            }
        }

        private void addbtn_Click_1(object sender, EventArgs e)
        {
            if (addBuildingname.Text != "")
            {
                locationModel.buildingname = addBuildingname.Text;
                LocationControl.insertLocationDetails(locationModel);

                bunifuDataGridView1.DataSource = LocationControl.getlocationvalues();
            }
            else
            {
                MessageBox.Show("Please Fill the all the required fields ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btndelete_Click_1(object sender, EventArgs e)
        {
            int x = int.Parse(addBuildingID.Text);
            LocationControl.DeleteLocationDet(x);

            clearAll();

            bunifuDataGridView1.DataSource = LocationControl.getlocationvalues();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            int y = int.Parse(addBuildingID.Text);
            String buildingname = addBuildingname.Text;

            LocationControl.updateLocationDetails(buildingname, y);

            clearAll();

            bunifuDataGridView1.DataSource = LocationControl.getlocationvalues();
        }

        private void clearbtn_Click_1(object sender, EventArgs e)
        {
            clearAll();
        }

        private void bunifuDataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
 
            if (e.RowIndex >= 0)
            {
                {
                    if (e.RowIndex >= 0)
                    {

                        DataGridViewRow row = this.bunifuDataGridView1.Rows[e.RowIndex];

                        addBuildingID.Text = row.Cells["locationID"].Value.ToString();
                        addBuildingname.Text = row.Cells["locationName"].Value.ToString();
                        

                    }
                }
            }
        }
    }
}