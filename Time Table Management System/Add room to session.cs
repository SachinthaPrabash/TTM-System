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
using System.Data.SqlClient;

namespace Time_Table_Management_System
{
    public partial class Manage_session : Form
    {
        DBcon DBConnection = new DBcon();
        SqlConnection con = new SqlConnection();


        ManageSessionControl ManageSessionControl = new ManageSessionControl();

        public Manage_session()
        {
            InitializeComponent();
            con = DBConnection.getDBConnection();

            test1();

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            int x = int.Parse(selectSession.Text);
            String roomname = selectRoom.Text;

            ManageSessionControl.insertManageSessionRoom(roomname, x);
            clearAll();

            roomtosession.DataSource = ManageSessionControl.getsessionValues();
        }

        public void clearAll()
        {
            selectSession.Clear();
            selectRoom.Clear();
            roomToSubjectID.Clear();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void Manage_session_Load(object sender, EventArgs e)
        {
            roomtosession.DataSource = ManageSessionControl.getsessionValues();
            
        }

        private void roomtosession_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            roomToSubjectID.Text = roomtosession.SelectedRows[0].Cells[0].Value.ToString();
            selectSession.Text = roomtosession.SelectedRows[0].Cells[1].Value.ToString();
            selectRoom.Text = roomtosession.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            String sesid = selectSession.Text;
            String room = selectRoom.Text;
            String ID = roomToSubjectID.Text;

            

            ManageSessionControl.updateRoomForSession(ID,sesid, room);

            clearAll();

            roomtosession.DataSource = ManageSessionControl.getsessionValues();

        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            String id = roomToSubjectID.Text;

            ManageSessionControl.deleteRoomFromSession(id);

            clearAll();

            roomtosession.DataSource = ManageSessionControl.getsessionValues();
        }

        private void selectRoom_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void bunifuDropdown1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void SELECTrOOM()
        {
            DataRow dr;
            String id = selectSession.Text;

            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            String query = "select distinct r.roomName from roomForLecture rl,roomTB r, roomForGroup rg,roomForSubject rs where rl.room = r.roomID  or rg.room = r.roomID  or rs.room = r.roomID and rg.subGroupID IN(select s.group_no from session s where s.sesId= '" + id + "') and rl.lectureName IN(select s.lec1 from session s where s.sesId= '" + id + "') and rs.roomForSubjectID IN(select subject_name from session where sesId = '" + id + "') ";

            SqlCommand com = new SqlCommand(query, con);

            SqlDataAdapter sda = new SqlDataAdapter(com);
           
            DataTable dt = new DataTable();
            sda.Fill(dt);

            dr = dt.NewRow();
            dr.ItemArray = new object[] { "--Select room--" };

            dt.Rows.InsertAt(dr, 0);

            


           
            bunifuDropdown1.DataSource = dt;
            

            con.Close();
        }

        public void test1()
        {
            con.Open();

            String id = selectSession.Text;

            DataSet ds = new DataSet();


           
            String query = "select distinct r.roomName from roomForLecture rl,roomTB r, roomForGroup rg,roomForSubject rs where rl.room = r.roomID  or rg.room = r.roomID  or rs.room = r.roomID and rg.subGroupID IN(select s.group_no from session s where s.sesId= '" + id + "') and rl.lectureName IN(select s.lec1 from session s where s.sesId= '" + id + "') and rs.roomForSubjectID IN(select subject_name from session where sesId = '" + id + "') ";
            SqlDataReader dr;
            SqlCommand com = new SqlCommand(query, con);

            SqlDataAdapter sda = new SqlDataAdapter(com);

            
            sda.Fill(ds);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                bunifuDropdown1.Items.Add(ds.Tables[0].Rows[i][0]);
            }
        }



    }
}
