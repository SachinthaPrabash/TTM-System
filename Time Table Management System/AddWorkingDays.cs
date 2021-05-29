using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Time_Table_Management_System.Controller;
using Time_Table_Management_System.Model;
using Time_Table_Management_System.DBConnection;
using System.Collections;
using System.Data.SqlClient;

namespace Time_Table_Management_System
{
    public partial class AddWorkingDays : Form
    {
        public AddWorkingDays()
        {
            InitializeComponent();
        }
        AddWorkingDaysControl addcontrol = new AddWorkingDaysControl();
        AddWorkingDaysModel AddWorkingDaysModel = new AddWorkingDaysModel();

        DaysControl addcontrold = new DaysControl();
        addDaysModel addDaysModeld = new addDaysModel();


        //add button 
        private void btnadd_Click_1(object sender, EventArgs e)

        {
          
                
                //validate
              
                if (comboBox1.Text == "") MessageBox.Show("Select No of Working Days ");
                if (comboBox3.Text == "") MessageBox.Show("Select Start Time ");
                if (comboBox4.Text == "") MessageBox.Show("Select End Time ");

           
           else { 
                               
                AddWorkingDaysModel.noOfWorkingDays = int.Parse(comboBox1.Text);
                AddWorkingDaysModel.startTime = comboBox3.Text;
                AddWorkingDaysModel.timeSlot = comboBox4.Text;

                //insert to db
                addcontrol.insertaddWorkingDetails(AddWorkingDaysModel);
                // page load
                dataview.DataSource = addcontrol.getworkingdaysvalues();
                dataGridViewdays.DataSource = addcontrold.getdaysvalues();

                //get value
               /* textBox1.Text = "";*/
                comboBox1.Text = "";
                comboBox3.Text = "";
                comboBox4.Text = "";

            }


        
        }

        //delete button
        private void btndelete_Click(object sender, EventArgs e)
        {
            int x = int.Parse(Aid.Text);

            //delete from db
            addcontrol.deleteWorkingDetails(x);
            Aid.Text = "";
            //page load
            dataview.DataSource = addcontrol.getworkingdaysvalues();

            //get value
            
            comboBox1.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";

        }

        //update button
        private void btnupdate_Click(object sender, EventArgs e)
        {
            //validate
            
            if (comboBox3.Text == "") MessageBox.Show("Select No of Working Days ");
            if (comboBox4.Text == "") MessageBox.Show("Select No of Working Days ");

           

            AddWorkingDaysModel.id = int.Parse(Aid.Text);
            AddWorkingDaysModel.noOfWorkingDays = int.Parse(comboBox1.Text);
            AddWorkingDaysModel.startTime = comboBox3.Text;
            AddWorkingDaysModel.timeSlot = comboBox4.Text;

            //update db
            addcontrol.updateworkingdaysDetails(AddWorkingDaysModel);

            //page load
            dataview.DataSource = addcontrol.getworkingdaysvalues();
            dataGridViewdays.DataSource = addcontrold.getdaysvalues();

            //get value
            Aid.Text = "";
            comboBox1.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";


        }


        //view page load
        private void AddWorkingDays_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tLMDataSet1.lecture' table. You can move, or remove it, as needed.
            this.lectureTableAdapter.Fill(this.tLMDataSet1.lecture);
            dataview.DataSource = addcontrol.getworkingdaysvalues();
            dataGridViewdays.DataSource = addcontrold.getdaysvalues();
        }

        //table view
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        { 
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dataview.Rows[e.RowIndex];
                
                comboBox1.Text = row.Cells["NoOfWorkingDays"].Value.ToString();
                comboBox3.Text = row.Cells["StratTime"].Value.ToString();
                comboBox5.Text = row.Cells["EndTime"].Value.ToString();
                comboBox4.Text = row.Cells["TimeSlot"].Value.ToString();

            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Selectdays Selectdays = new Selectdays();
            Selectdays.Show();
          
        }

        private void dataGridViewdays_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dataGridViewdays.Rows[e.RowIndex];


            }
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Aid_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
    }
    
