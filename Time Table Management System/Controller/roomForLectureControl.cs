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
    class roomForLectureControl
    {
        DBcon DBConnection = new DBcon();
        SqlConnection con = new SqlConnection();

        public roomForLectureControl()
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
        public void insertroomForLecture(String Lname,String room)
        {
            conopen();

           string query = "INSERT INTO roomForLecture(lectureName,room) VALUES ( (select lid from lecture where lecturerName ='" + Lname + "') ," +
                "  (select roomID from roomTB where roomname ='" + room + "') )";

            SqlCommand com = new SqlCommand(query, con);
            com.ExecuteNonQuery();

            MessageBox.Show("No of Records have been inserted" + "Information");
            con.Close();
        }

        //view

       public DataTable viewLectureForRoom()
        {
            conopen();

            DataTable dtbuilding = new DataTable();

            string query = "select rl.roomForLectureID,l.lecturerName,r.roomName from roomForLecture rl,lecture l, roomTB r where rl.lectureName = l.lid and rl.room = r.roomID ";

            SqlDataReader dr1 = new SqlCommand(query, con).ExecuteReader();

            dtbuilding.Load(dr1);
            return dtbuilding;
        }

        //update

    public void updateRoomForLecture(String id,String lec,String room)
        {
            conopen();

            String query = "update roomForLecture set room = (select roomID from roomTB where roomName = '"+room+ "') , lectureName = (select lid from lecture where lecturerName = '" + lec+ "') where roomForLectureID='"+id+"' ";

            SqlCommand com = new SqlCommand(query, con);
            com.ExecuteNonQuery();

            MessageBox.Show(" Records have been inserted");

            con.Close();

        }

        //delete

        public void deleteRoomForLecture(String lec)
        {
            conopen();

            String query = "delete from roomForLecture where roomForLectureID='"+lec+"' ";


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
