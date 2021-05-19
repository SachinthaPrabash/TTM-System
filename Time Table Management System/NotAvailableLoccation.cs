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
    public partial class NotAvailableLoccation : Form
    {
        public NotAvailableLoccation()
        {
            InitializeComponent();
        }

        Controller.NotAvailableLocationControl NotAvailableLoc = new Controller.NotAvailableLocationControl();
        NotAvailableLocationModel NotAvailableLocationModel = new NotAvailableLocationModel();

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void selectend_TextChanged(object sender, EventArgs e)
        {

        }

        private void NotAvailableTime_Load(object sender, EventArgs e)
        {
            dataviewNL.DataSource = NotAvailableLoc.getNotAvailableLocvalues();
        }


        private void dataviewNA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dataviewNL.Rows[e.RowIndex];

                id.Text = row.Cells["Id"].Value.ToString();
                date.Text = row.Cells["Date"].Value.ToString();
                selectlocation.Text = row.Cells["Loccation"].Value.ToString();
                selectroom.Text = row.Cells["Room"].Value.ToString();
                selectstart1.Text = row.Cells["StartTime"].Value.ToString();
                selectend.Text = row.Cells["EndTime"].Value.ToString();

            }
        }

        private void btndeleteNL_Click(object sender, EventArgs e)
        {
            int x = int.Parse(id.Text);
            NotAvailableLoc.DeleteNotAvailableLocDetails(x);


            dataviewNL.DataSource = NotAvailableLoc.getNotAvailableLocvalues();

            
            date.Text = "";
            selectlocation.Text = "";
            selectroom.Text = "";
            selectstart1.Text = "";
            selectend.Text = "";
        }

        private void btnupdateNA_Click(object sender, EventArgs e)
        {

            if (date.Text == "") MessageBox.Show("Enter Date");
            if (selectlocation.Text == "") MessageBox.Show("Select Lecturer ");
            if (selectroom.Text == "") MessageBox.Show("Select Group ");
            if (selectstart1.Text == "") MessageBox.Show("Select Sub Group");
            if (selectend.Text == "") MessageBox.Show("Select Session ID ");


            NotAvailableLocationModel.date = date.Value.ToString("MM.dd.yyyyy");
            NotAvailableLocationModel.loccation = selectlocation.Text;
            NotAvailableLocationModel.room = selectroom.Text;
            NotAvailableLocationModel.startTime = selectstart1.Text;
            NotAvailableLocationModel.endTime = selectend.Text;


            NotAvailableLoc.UpdatenotAvailableLocDetails(NotAvailableLocationModel);

            dataviewNL.DataSource = NotAvailableLoc.getNotAvailableLocvalues();

            date.Text = "";
            selectlocation.Text = "";
            selectroom.Text = "";
            selectstart1.Text = "";
            selectend.Text = "";


        }

        private void btnaddNA_Click(object sender, EventArgs e)
        {
            if (date.Text == "")
            {
                MessageBox.Show("Enter Date");
                if (selectlocation.Text == "") MessageBox.Show("Select Lecturer ");
                if (selectroom.Text == "") MessageBox.Show("Select Group ");
                if (selectstart1.Text == "") MessageBox.Show("Select Sub Group");
                if (selectend.Text == "") MessageBox.Show("Select Session ID ");
               

            }
            else
            {

                NotAvailableLocationModel.date = date.Value.ToString("MM.dd.yyyyy");
                NotAvailableLocationModel.loccation = selectlocation.Text;
                NotAvailableLocationModel.room = selectroom.Text;
                NotAvailableLocationModel.startTime = selectstart1.Text;
                NotAvailableLocationModel.endTime = selectend.Text;


                NotAvailableLoc.InsertnotAvailableLocDetails(NotAvailableLocationModel);
                
                dataviewNL.DataSource = NotAvailableLoc.getNotAvailableLocvalues();

               
                date.Text = "";
                selectlocation.Text = "";
                selectroom.Text = "";
                selectstart1.Text = "";
                selectend.Text = "";

            }
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }



        private void selectgroup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void selectlecure_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void selectstart1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NotAvailableLoccation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tLMDataSet7.roomTB' table. You can move, or remove it, as needed.
            this.roomTBTableAdapter.Fill(this.tLMDataSet7.roomTB);
            // TODO: This line of code loads data into the 'tLMDataSet.locationTB' table. You can move, or remove it, as needed.
            this.locationTBTableAdapter.Fill(this.tLMDataSet.locationTB);
            dataviewNL.DataSource = NotAvailableLoc.getNotAvailableLocvalues();

            clearAll();
        }


        public void clearAll()
        {
            this.date.Text = "";
            selectlocation.SelectedIndex = -1;
            selectroom.SelectedIndex = -1;
            selectstart1.Clear();
            selectend.Clear();
        }
    }
}
