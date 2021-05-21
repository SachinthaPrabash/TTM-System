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
    public partial class Assign_rooms_for__Lecturer : Form
    {
        DBcon DBConnection = new DBcon();
        SqlConnection con = new SqlConnection();

        roomForLectureControl roomForLectureControl = new roomForLectureControl();

        public Assign_rooms_for__Lecturer()
        {
            InitializeComponent();
            con = DBConnection.getDBConnection();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            String leName = lectureName.Text;
            String room = selectroom.Text;

            roomForLectureControl.insertroomForLecture(leName, room);

            clearAll();

            roomForLecture.DataSource = roomForLectureControl.viewLectureForRoom();
        }

        public void clearAll()
        {
            lecid.Clear();
            lectureName.SelectedIndex = -1;
            selectroom.SelectedIndex = -1;
        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Assign_rooms_for__Lecturer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tLMDataSet7.roomTB' table. You can move, or remove it, as needed.
            this.roomTBTableAdapter.Fill(this.tLMDataSet7.roomTB);
            // TODO: This line of code loads data into the 'tLMDataSet1.lecture' table. You can move, or remove it, as needed.
            this.lectureTableAdapter.Fill(this.tLMDataSet1.lecture);
            roomForLecture.DataSource = roomForLectureControl.viewLectureForRoom();

            clearAll();
        }

  

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            String lec = lectureName.Text;
            String room = selectroom.Text;
            String id = lecid.Text;


            roomForLectureControl.updateRoomForLecture(id,lec, room);

            clearAll();

            roomForLecture.DataSource = roomForLectureControl.viewLectureForRoom();
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            String lc = lecid.Text;

            roomForLectureControl.deleteRoomForLecture(lc);

            clearAll();

            roomForLecture.DataSource = roomForLectureControl.viewLectureForRoom();
        }

        private void selectroom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

            if (e.RowIndex >= 0)
            {
                {
                    if (e.RowIndex >= 0)
                    {

                        DataGridViewRow row = this.roomForLecture.Rows[e.RowIndex];

                        lecid.Text = row.Cells["roomForLectureID"].Value.ToString();
                        lectureName.Text = row.Cells["lecturerName"].Value.ToString();
                        selectroom.Text = row.Cells["roomName"].Value.ToString();

                    }
                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {

            String leName = lectureName.Text;
            String room = selectroom.Text;

            roomForLectureControl.insertroomForLecture(leName, room);

            clearAll();

            roomForLecture.DataSource = roomForLectureControl.viewLectureForRoom();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String lec = lectureName.Text;
            String room = selectroom.Text;
            String id = lecid.Text;


            roomForLectureControl.updateRoomForLecture(id, lec, room);

            clearAll();

            roomForLecture.DataSource = roomForLectureControl.viewLectureForRoom();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String lc = lecid.Text;

            roomForLectureControl.deleteRoomForLecture(lc);

            clearAll();

            roomForLecture.DataSource = roomForLectureControl.viewLectureForRoom();
        }
    }
}
