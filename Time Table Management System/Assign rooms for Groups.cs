using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using Time_Table_Management_System.DBConnection;
using Time_Table_Management_System.Model;
using Time_Table_Management_System.Controller;
using System.Data.SqlClient;

namespace Time_Table_Management_System
{
    public partial class Assign_rooms_for_Groups : Form
    {
        DBcon DBConnection = new DBcon();
        SqlConnection con = new SqlConnection();

        AssignRoomsforgroupControler AssignRoomsforgroupControler = new AssignRoomsforgroupControler();


        public Assign_rooms_for_Groups()
        {
            InitializeComponent();
            con = DBConnection.getDBConnection();
        }


        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            String group = selectGroup.Text;
            String room = selectRoom.Text;

            AssignRoomsforgroupControler.insertAssignRoomsforgroup(group, room);

            clearAll();

            groupforRoomGridView.DataSource = AssignRoomsforgroupControler.ViewGroup();
        }

        public void clearAll()
        {
            selectGroup.SelectedIndex= -1;
            selectRoom.SelectedIndex = -1;
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
           

        }

        private void Assign_rooms_for_Groups_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tLMDataSet7.roomTB' table. You can move, or remove it, as needed.
            this.roomTBTableAdapter.Fill(this.tLMDataSet7.roomTB);
            // TODO: This line of code loads data into the 'tLMDataSet2.StudentGroup' table. You can move, or remove it, as needed.
            this.studentGroupTableAdapter.Fill(this.tLMDataSet2.StudentGroup);
            groupforRoomGridView.DataSource = AssignRoomsforgroupControler.ViewGroup();

            clearAll();
        }

        private void groupforRoomGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            groupaForID.Text = groupforRoomGridView.SelectedRows[0].Cells[0].Value.ToString();
            selectGroup.Text = groupforRoomGridView.SelectedRows[0].Cells[1].Value.ToString();
            selectRoom.Text = groupforRoomGridView.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            String id = groupaForID.Text;
            String gro = selectGroup.Text;
            String room = selectRoom.Text;

            AssignRoomsforgroupControler.groupForSessionUpdate(id,gro, room);

            clearAll();

            groupforRoomGridView.DataSource = AssignRoomsforgroupControler.ViewGroup();
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            String id = groupaForID.Text;

            AssignRoomsforgroupControler.groupForSessionDelete(id);

            clearAll();

            groupforRoomGridView.DataSource = AssignRoomsforgroupControler.ViewGroup();
        }
    }
}
