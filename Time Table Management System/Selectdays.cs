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

namespace Time_Table_Management_System
{
    public partial class Selectdays: Form
    {
        public Selectdays()
        {
            InitializeComponent();
        }

        DaysControl addcontrol = new DaysControl();
        addDaysModel addDaysModel = new addDaysModel();



        private void btnadd_Click_1(object sender, EventArgs e)
        {

                addDaysModel.emp = comboBox1.Text;

            String day = "";

            if (checkBox1.CheckState == CheckState.Checked)
            {

                day += "Monday";
                addDaysModel.d1 = checkBox1.Text;
            }
            if (checkBox2.CheckState == CheckState.Checked)
            {

                day += "Tuesday";
                addDaysModel.d2 = checkBox2.Text;
            }
            if (checkBox3.CheckState == CheckState.Checked)
            {

                day += "Wednesday";
                addDaysModel.d3 = checkBox3.Text;
            }
            if (checkBox4.CheckState == CheckState.Checked)
            {

                day += "Thursday";
                addDaysModel.d4 = checkBox4.Text;
            }
            if (checkBox5.CheckState == CheckState.Checked)
            {

                day += "Friday";
                addDaysModel.d5 = checkBox5.Text;
            }
            if (checkBox6.CheckState == CheckState.Checked)
            {

                day += "Saturday";
                addDaysModel.d6 = checkBox6.Text;
            }
            if (checkBox7.CheckState == CheckState.Checked)
            {

                day += "Sunday";
                addDaysModel.d7 = checkBox7.Text;
            }


            MessageBox.Show(day);



 

            addcontrol.insertDays(addDaysModel);


            dataGridView1.DataSource = addcontrol.getdaysvalues();

            this.Close();



        }

            private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
                if (e.RowIndex >= 0)
                {

                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];


                }
            }

        private void Selectdays_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = addcontrol.getdaysvalues();
        }

       
    }
}
