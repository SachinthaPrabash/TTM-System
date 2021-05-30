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


        public void clearAll()
        {
            selectSession.SelectedIndex=-1;
            roomselect.SelectedIndex=-1;
            roomToSubjectID.Clear();
        }



        private void Manage_session_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tLMDataSet7.roomTB' table. You can move, or remove it, as needed.
            this.roomTBTableAdapter.Fill(this.tLMDataSet7.roomTB);
            // TODO: This line of code loads data into the 'tLMDataSet6.session' table. You can move, or remove it, as needed.
            this.sessionTableAdapter.Fill(this.tLMDataSet6.session);
            roomtosession.DataSource = ManageSessionControl.getsessionValues();
            clearAll();

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
                roomselect.Items.Add(ds.Tables[0].Rows[i][0]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void savebtn_Click_1(object sender, EventArgs e)
        {
            int x = int.Parse(selectSession.Text);
            String roomname = roomselect.Text;

            ManageSessionControl.insertManageSessionRoom(roomname, x);
            clearAll();

            roomtosession.DataSource = ManageSessionControl.getsessionValues();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String sesid = selectSession.Text;
            String room = roomselect.Text;
            String ID = roomToSubjectID.Text;



            ManageSessionControl.updateRoomForSession(ID, sesid, room);

            clearAll();

            roomtosession.DataSource = ManageSessionControl.getsessionValues();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            String id = roomToSubjectID.Text;

            ManageSessionControl.deleteRoomFromSession(id);

            clearAll();

            roomtosession.DataSource = ManageSessionControl.getsessionValues();
        }

        private void roomtosession_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.RowIndex >= 0)
            {
                {
                    if (e.RowIndex >= 0)
                    {

                        DataGridViewRow row = this.roomtosession.Rows[e.RowIndex];

                        roomToSubjectID.Text = row.Cells["seesionForRoomID"].Value.ToString();
                        selectSession.Text = row.Cells["sesId"].Value.ToString();
                        roomselect.Text = row.Cells["roomName"].Value.ToString();

                    }
                }
            }
        }


    }
}

