using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Time_Table_Management_System.DBConnection;
using Time_Table_Management_System.Model;

namespace Time_Table_Management_System.Controller
{
    class roomControl
    {
        DBcon DBConnection = new DBcon();
        SqlConnection con = new SqlConnection();

        public roomControl()
        {
            con = DBConnection.getDBConnection();
        }

        //Insert queries rooms
        public void insertRoomDetails(locationModel buildingMod)
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string query = "INSERT INTO roomTB(locationID,roomName,roomCapacity,roomType) VALUES ( (select locationID from locationTB where locationName ='" + buildingMod.buildingname + "') , '" + buildingMod.roomname + "' , '" + buildingMod.capacity + "' , '" + buildingMod.roomType + "')";

            SqlCommand com = new SqlCommand(query, con);
            com.ExecuteNonQuery();

            MessageBox.Show("No of Records have been inserted" + "Information");
            con.Close();
        }

        //get rooms data
        public DataTable getRoomvalues()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            DataTable dtbuilding = new DataTable();

            string query = "select r.roomID,l.locationName,r.roomName,r.roomCapacity,r.roomType  from roomTB r, locationTB l where l.locationID= r.locationID";

            SqlDataReader dr1 = new SqlCommand(query, con).ExecuteReader();

            dtbuilding.Load(dr1);
            return dtbuilding;
        }

        //delete rooms
        public void DeleteRooomDet(int id)
        {

            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string query = "DELETE  FROM roomTB  WHERE  roomID= '" + id + "'";

            SqlCommand com = new SqlCommand(query, con);

            string ans = MessageBox.Show("Are sure to delete this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).ToString();


            if (ans == "Yes")
            {
                com.ExecuteNonQuery();
                MessageBox.Show(" records deleted");
            }

            con.Close();

        }

        //update rooms 
        public void updateRoomDetails(locationModel buildingMod)
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }
            string query = "update roomTB set locationID= (select locationID from locationTB where locationName ='"+buildingMod.buildingname+"'), roomName='" + buildingMod.roomname + "' , roomCapacity='" + buildingMod.capacity + "', roomType='" + buildingMod.roomType + "' where roomID = '" + buildingMod.roomID + "' ";

            SqlCommand com = new SqlCommand(query, con);
            com.ExecuteNonQuery();

            MessageBox.Show("No of Records have been inserted");

            con.Close();
        }



    }
}
