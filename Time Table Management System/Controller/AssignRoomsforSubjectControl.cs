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
    class AssignRoomsforSubjectControl
    {
        DBcon DBConnection = new DBcon();
        SqlConnection con = new SqlConnection();

      
        public AssignRoomsforSubjectControl()
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
        public void insertAssignRoomsforSubject(String sub, String room)
        {
            conopen();

            string query = "INSERT INTO roomForSubject(subject,room) VALUES ( (select sub_id from subject where sub_name ='" + sub + "') ," +
                 "  (select roomID from roomTB where roomname ='" + room + "') )";

            SqlCommand com = new SqlCommand(query, con);
            com.ExecuteNonQuery();

            MessageBox.Show("No of Records have been inserted" + "Information");
            con.Close();
        }

        //view
        public DataTable viewSubjectRoom()
        {
            conopen();

            DataTable dtbuilding = new DataTable();

            string query = "select  rs.roomForSubjectID,s.sub_name,r.roomName from roomForSubject rs,subject s, roomTB r where rs.subject = s.sub_id and rs.room = r.roomID";

            SqlDataReader dr1 = new SqlCommand(query, con).ExecuteReader();

            dtbuilding.Load(dr1);
            return dtbuilding;
        }


        //update

        public void updateRoomForSubject(String id, String sub, String room)
        {
            conopen();

            String query = "update roomForSubject set subject = (select sub_id from subject where sub_name = '"+sub+"'), room = (select roomID from roomTB where roomName = '"+room+"') where roomForSubjectID = '"+id+"' ";

            SqlCommand com = new SqlCommand(query, con);
            com.ExecuteNonQuery();

            MessageBox.Show(" Records have been inserted");

            con.Close();

        }

        //delete

        public void deleteRoomForSubject(String sub)
        {
            conopen();

            String query = "delete from roomForSubject where roomForSubjectID='"+sub+"' ";


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
