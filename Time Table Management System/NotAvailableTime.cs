using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Time_Table_Management_System.Controller;
using Time_Table_Management_System.Model;
using Time_Table_Management_System.DBConnection;
using System.Data.SqlClient;

namespace Time_Table_Management_System
{
    public partial class NotAvailableTime : Form
    {
        public NotAvailableTime()
        {
            InitializeComponent();
        }
        Controller.NotAvailableTimeControl NotAvailable = new Controller.NotAvailableTimeControl();
        NotAvailableTimeModel NotAvailableTimeModel = new NotAvailableTimeModel();

       
        private void btnadd_Click(object sender, EventArgs e)
        {
            if (date.Text == "")
            {
                MessageBox.Show("Select Date");
                if (selectlecure.Text == "") MessageBox.Show("Select Lecturer ");
                if (selectgroup.Text == "") MessageBox.Show("Select Group ");
                if (selectsubgroup.Text == "") MessageBox.Show("Select Sub Group");
                if (selectsession.Text == "") MessageBox.Show("Select Session ID ");
                if (selectstart1.Text == "") MessageBox.Show("Enter time");
            }

            else
            {


               
                NotAvailableTimeModel.date = date.Value.ToString("MM.dd.yyyyy");
                NotAvailableTimeModel.lecturerName = selectlecure.Text;
                NotAvailableTimeModel.group = selectgroup.Text;
                NotAvailableTimeModel.subGroup = selectsubgroup.Text;
                NotAvailableTimeModel.sessionID = selectsession.Text;
                NotAvailableTimeModel.startTime = selectstart1.Text;
                NotAvailableTimeModel.endTime = selectend.Text;


                NotAvailable.InsertnotAvailableDetails(NotAvailableTimeModel);


                dataviewNA.DataSource = NotAvailable.getNotAvailablevalues();

               
                date.Text = "";
                selectlecure.Text = "";
                selectgroup.Text = "";
                selectsubgroup.Text = "";
                selectsession.Text = "";
                selectstart1.Text = "";
                selectend.Text = "";

            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnupdateNA_Click(object sender, EventArgs e)
        {

                
                if (date.Text == "") MessageBox.Show("Select Date");
                if (selectlecure.Text == "") MessageBox.Show("Select Lecturer ");
                if (selectgroup.Text == "") MessageBox.Show("Select Group ");
                if (selectsubgroup.Text == "") MessageBox.Show("Select Sub Group");
                if (selectsession.Text == "") MessageBox.Show("Select Session ID ");
                if (selectstart1.Text == "") MessageBox.Show("Enter time");


               
                NotAvailableTimeModel.date = date.Value.ToString("MM.dd.yyyyy");
                NotAvailableTimeModel.lecturerName = selectlecure.Text;
                NotAvailableTimeModel.group = selectgroup.Text;
                NotAvailableTimeModel.subGroup = selectsubgroup.Text;
                NotAvailableTimeModel.sessionID = selectsession.Text;
                NotAvailableTimeModel.startTime = selectstart1.Text;
                NotAvailableTimeModel.endTime = selectend.Text;

                NotAvailable.UpdatenotAvailableDetails(NotAvailableTimeModel);

                dataviewNA.DataSource = NotAvailable.getNotAvailablevalues();

               
                date.Text = "";
                selectlecure.Text = "";
                selectgroup.Text = "";
                selectsubgroup.Text = "";
                selectsession.Text = "";
                selectstart1.Text = "";
                selectend.Text = "";


        }

        private void btndeleteNA_Click(object sender, EventArgs e)
        {
                int x = int.Parse(id.Text);
                NotAvailable.DeleteNotaAvailableDetails(x);
                id.Text = "";

                dataviewNA.DataSource = NotAvailable.getNotAvailablevalues();

                id.Text = "";
                date.Text = "";
                selectlecure.Text = "";
                selectgroup.Text = "";
                selectsubgroup.Text = "";
                selectsession.Text = "";
                selectstart1.Text = "";
                selectend.Text = "";
            }

        private void AddWorkingDays_Load(object sender, EventArgs e)
        {
               
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dataviewNA.Rows[e.RowIndex];

                id.Text = row.Cells["Id"].Value.ToString();
                date.Text = row.Cells["Date"].Value.ToString();
                selectlecure.Text = row.Cells["LecturerName"].Value.ToString();
                selectgroup.Text = row.Cells["Group"].Value.ToString();
                selectsubgroup.Text = row.Cells["SubGroup"].Value.ToString();
                selectsession.Text = row.Cells["SessionID"].Value.ToString();
                selectstart1.Text = row.Cells["StartTime"].Value.ToString();
                selectend.Text = row.Cells["EndTime"].Value.ToString();

            }
        }

        private void NotAvailableTime_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tLMDataSet6.session' table. You can move, or remove it, as needed.
            this.sessionTableAdapter.Fill(this.tLMDataSet6.session);
            // TODO: This line of code loads data into the 'tLMDataSet5.StudentGroup' table. You can move, or remove it, as needed.
            this.studentGroupTableAdapter1.Fill(this.tLMDataSet5.StudentGroup);
            // TODO: This line of code loads data into the 'tLMDataSet2.StudentGroup' table. You can move, or remove it, as needed.
            this.studentGroupTableAdapter.Fill(this.tLMDataSet2.StudentGroup);
            // TODO: This line of code loads data into the 'tLMDataSet1.lecture' table. You can move, or remove it, as needed.
            this.lectureTableAdapter.Fill(this.tLMDataSet1.lecture);
            dataviewNA.DataSource = NotAvailable.getNotAvailablevalues();

            clearALL();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void selectstart1_TextChanged(object sender, EventArgs e)
        {

        }

        public void clearALL()
        {
            this.date.Text = "";
            selectlecure.SelectedIndex = -1;
            selectgroup.SelectedIndex = -1;
            selectsubgroup.SelectedIndex = -1;
            selectsession.SelectedIndex = -1;
            selectstart1.Clear();
            selectend.Clear();
        }
    }
}
