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
    class AssignRoomsforgroupControler
    {

        DBcon DBConnection = new DBcon();
        SqlConnection con = new SqlConnection();

        public AssignRoomsforgroupControler()
        {
            con = DBConnection.getDBConnection();
        }

        public void conopen()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }
        }

        //Insert queries rooms
        public void insertAssignRoomsforgroup(String grp, String room)
        {
            conopen();

            string query = "INSERT INTO roomForGroup VALUES ( (select StudentgropID from StudentGroup where SubGroupID ='" + grp + "') ," +
               "  (select roomID from roomTB where roomname ='" + room + "') )";

            SqlCommand com = new SqlCommand(query, con);
            com.ExecuteNonQuery();

            MessageBox.Show("No of Records have been inserted" + "Information");

            con.Close();
        }

        //view update group for room

        public DataTable ViewGroup()
        {
            conopen();

            DataTable dtbuilding = new DataTable();

            string query = "select rg.groupForRoomID, s.SubGroupID,r.roomName from roomForGroup rg,StudentGroup s, roomTB r where rg.subGroupID = s.StudentgropID and rg.room = r.roomID ";

            SqlDataReader dr1 = new SqlCommand(query, con).ExecuteReader();

            dtbuilding.Load(dr1);
            return dtbuilding;

        }

        //update group

        public void groupForSessionUpdate(String id,String group,String room)
        {
            conopen();

            String query = "update roomForGroup  set room = (select roomID from roomTB where roomName = '"+room+ "') ,subGroupID = (select StudentgropID from StudentGroup where subGroupID='"+group+ "') where groupForRoomID ='"+id+"'";

            SqlCommand com = new SqlCommand(query, con);
            com.ExecuteNonQuery();

            MessageBox.Show(" Records have been inserted");
           
            con.Close();
        }

        //delete
        public void groupForSessionDelete(String id)
        {
            conopen();

            String query = "delete from roomForGroup where groupForRoomID='"+id+"' ";

            string ans = MessageBox.Show("Are sure to delete this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).ToString();

            SqlCommand com = new SqlCommand(query, con);
            if (ans == "Yes")
            {
                com.ExecuteNonQuery();
                MessageBox.Show(" records deleted");
            }

            con.Close();

        }


    }
}
