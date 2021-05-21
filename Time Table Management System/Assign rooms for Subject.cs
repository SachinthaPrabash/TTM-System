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
    public partial class Assign_rooms_for_Subject : Form
    {

        DBcon DBConnection = new DBcon();
        SqlConnection con = new SqlConnection();


        AssignRoomsforSubjectControl AssignRoomsforSubject = new AssignRoomsforSubjectControl();

        public Assign_rooms_for_Subject()
        {
            InitializeComponent();
            con = DBConnection.getDBConnection();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            String subj = enterSubject.Text;
            String room = selectRoom.Text;

            AssignRoomsforSubject.insertAssignRoomsforSubject(subj, room);

            clearAll();

            assignForSubjectRoom.DataSource = AssignRoomsforSubject.viewSubjectRoom();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        public void clearAll()
        {
            enterSubject.SelectedIndex = -1;
            selectRoom.SelectedIndex = -1;
            roomForSubjectID.Clear();
        }

        private void Assign_rooms_for_Subject_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tLMDataSet7.roomTB' table. You can move, or remove it, as needed.
            this.roomTBTableAdapter.Fill(this.tLMDataSet7.roomTB);
            // TODO: This line of code loads data into the 'tLMDataSet4.subject' table. You can move, or remove it, as needed.
            this.subjectTableAdapter.Fill(this.tLMDataSet4.subject);
            assignForSubjectRoom.DataSource = AssignRoomsforSubject.viewSubjectRoom();

            clearAll();
        }

        private void assignForSubjectRoom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            roomForSubjectID.Text = assignForSubjectRoom.SelectedRows[0].Cells[0].Value.ToString();
            enterSubject.Text = assignForSubjectRoom.SelectedRows[0].Cells[1].Value.ToString();
            selectRoom.Text = assignForSubjectRoom.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            String id = roomForSubjectID.Text;
            String sub = enterSubject.Text;
            String room = selectRoom.Text;

            AssignRoomsforSubject.updateRoomForSubject(id, sub, room);

            clearAll();

            assignForSubjectRoom.DataSource = AssignRoomsforSubject.viewSubjectRoom();
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            String id = roomForSubjectID.Text;

            AssignRoomsforSubject.deleteRoomForSubject(id);

            clearAll();

            assignForSubjectRoom.DataSource = AssignRoomsforSubject.viewSubjectRoom();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String subj = enterSubject.Text;
            String room = selectRoom.Text;

            AssignRoomsforSubject.insertAssignRoomsforSubject(subj, room);

            clearAll();

            assignForSubjectRoom.DataSource = AssignRoomsforSubject.viewSubjectRoom();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String id = roomForSubjectID.Text;
            String sub = enterSubject.Text;
            String room = selectRoom.Text;

            AssignRoomsforSubject.updateRoomForSubject(id, sub, room);

            clearAll();

            assignForSubjectRoom.DataSource = AssignRoomsforSubject.viewSubjectRoom();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String id = roomForSubjectID.Text;

            AssignRoomsforSubject.deleteRoomForSubject(id);

            clearAll();

            assignForSubjectRoom.DataSource = AssignRoomsforSubject.viewSubjectRoom();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                {
                    if (e.RowIndex >= 0)
                    {

                        DataGridViewRow row = this.assignForSubjectRoom.Rows[e.RowIndex];

                        roomForSubjectID.Text = row.Cells["roomForSubjectID"].Value.ToString();
                        enterSubject.Text = row.Cells["sub_name"].Value.ToString();
                        selectRoom.Text = row.Cells["roomName"].Value.ToString();

                    }
                }
            }
        }
    }
}
