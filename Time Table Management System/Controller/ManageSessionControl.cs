using System;
using System.Collections;
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
    class ManageSessionControl
    {
        DBcon DBConnection = new DBcon();
        SqlConnection con = new SqlConnection();

        public ManageSessionControl()
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

      public void insertManageSessionRoom(string name,int id)
        {

            conopen();
            
            string query = "insert into sessionForRoom values((SELECT sesId FROM session where sesId = '"+id+"'),(select roomID from roomTB where roomName = '"+name+"'))";

            SqlCommand com = new SqlCommand(query, con);
            com.ExecuteNonQuery();

            MessageBox.Show("No of Records have been inserted");
            con.Close();
        }

        public DataTable getsessionValues()
        {
            conopen();

            DataTable dtbuilding = new DataTable();

            string query = "select s.seesionForRoomID,s.sesID,r.roomName from sessionForRoom s, session se, roomTB r where s.sesID=se.sesId and s.roomname=r.roomID";

            SqlDataReader dr1 = new SqlCommand(query, con).ExecuteReader();

            dtbuilding.Load(dr1);
            return dtbuilding;
        }

        public void updateRoomForSession(string id,string sesid,string name)
        {
            conopen();

            String query = "update sessionForRoom set sesID = '"+sesid+"', roomname = (select roomID from roomTB where roomName = '"+name+"') where seesionForRoomID = '"+id+"' ";

            SqlCommand com = new SqlCommand(query, con);
            com.ExecuteNonQuery();

            MessageBox.Show(" Records have been inserted");

            con.Close();
        }

        public void deleteRoomFromSession(string id)
        {
            conopen();

            string query = "Delete from sessionForRoom where seesionForRoomID= '" + id+"' ";

            string ans = MessageBox.Show("Are sure to delete this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).ToString();

            SqlCommand com = new SqlCommand(query, con);
            if (ans == "Yes")
            {
                com.ExecuteNonQuery();
                MessageBox.Show(" records deleted");
            }

            con.Close();

        }

        //Manage session FOrm full table retrive

        public DataTable fullsessionretrive()
        {
            conopen();

            DataTable dtbuilding = new DataTable();

            string query = "select s.sesId,l.lecturerName,l2.lecturerName,t.TagName,sg.SubGroupID,sb.sub_name,s.noOfStudent,s.duration,r.roomName   from session s,lecture l,lecture l2, TagTB t,StudentGroup sg, subject sb ,sessionForRoom sr, roomTB r where s.lec1 = l.lid and s.lec2 = l2.lid and s.lec1_Tag = t.TagID and s.group_no = sg.StudentgropID and s.subject_name = sb.sub_id and sr.sesID = s.sesId and sr.roomname = r.roomID";

            SqlDataReader dr1 = new SqlCommand(query, con).ExecuteReader();

            dtbuilding.Load(dr1);
            return dtbuilding;

        }

        //
        public void selectRoom(String id)
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            String query = "select distinct r.roomName from roomForLecture rl,roomTB r, roomForGroup rg,roomForSubject rs where rl.room = r.roomID  or rg.room = r.roomID  or rs.room = r.roomID and rg.subGroupID IN(select s.group_no from session s where s.sesId= '" + id + "') and rl.lectureName IN(select s.lec1 from session s where s.sesId= '" + id + "') and rs.roomForSubjectID IN(select subject_name from session where sesId = '" + id + "') ";

            SqlCommand com = new SqlCommand(query, con);

            con.Close();
        }



        /*
         select distinct r.roomName
from roomForLecture rl,roomTB r,roomForGroup rg,roomForSubject rs
where rl.room=r.roomID  or rg.room=r.roomID  or rs.room=r.roomID
and rg.subGroupID IN (select s.group_no  from session s where s.sesId='6') and
rl.lectureName IN (select s.lec1 from session s where s.sesId='6') and
rs.roomForSubjectID IN (select subject_name from session where sesId='6' )
 
         
         */


        public void SELECTrOOM(string id)
        {
            DataRow dr;
            

            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            String query = "select distinct r.roomName from roomForLecture rl,roomTB r, roomForGroup rg,roomForSubject rs where rl.room = r.roomID  or rg.room = r.roomID  or rs.room = r.roomID and rg.subGroupID IN(select s.group_no from session s where s.sesId= '" + id + "') and rl.lectureName IN(select s.lec1 from session s where s.sesId= '" + id + "') and rs.roomForSubjectID IN(select subject_name from session where sesId = '" + id + "') ";

            SqlCommand com = new SqlCommand(query, con);

            SqlDataAdapter sda = new SqlDataAdapter(com);
            sda.SelectCommand = com;
            DataTable dt = new DataTable();
            sda.Fill(dt);

            dr = dt.NewRow();
            dr.ItemArray = new object[] { "--Select room--" };
            dt.Rows.InsertAt(dr, 0);





           // bunifuDropdown1.DataSource = dt;


            con.Close();
        }




    }
}
