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
    public partial class AddStd : Form
    {
        DBcon DBConnection = new DBcon();
        SqlConnection con = new SqlConnection();

        public string academicys;
        public string prgrm;
        public string grpnum;
        public string subgrpnum;
        public string grpid;
        public string subgrpid;

        public AddStd()
        {
            InitializeComponent();
            con = DBConnection.getDBConnection();
            
        }

        StdAndTagsController StdControl = new StdAndTagsController();
        StdModel stdMode = new StdModel();

        private void saveA_Click(object sender, EventArgs e)
        {
            validateDetails();
        }

        private void generateA_Click(object sender, EventArgs e)
        {
            this.academicys = this.academicYS.Text.Trim();
            this.prgrm = this.program.SelectedItem.ToString();
            this.grpnum = this.grpNum.SelectedItem.ToString();
            this.subgrpnum = this.subGrpNum.SelectedItem.ToString();

            Console.WriteLine(this.academicys + "" + this.prgrm + "" + this.grpnum + "" + this.subgrpnum);
            this.grpid = this.academicys + "." + this.prgrm + "." + this.grpnum;
            this.subgrpid = this.academicys + "." + this.prgrm + "." + this.grpnum + "." + this.subgrpnum;

            this.grpId.Text = this.grpid;
            this.subId.Text = this.subgrpid;


        }

        private void clearA_Click(object sender, EventArgs e)
        {
            this.academicYS.Text = "";
            this.program.Text = "";
            this.grpNum.Text = "";
            this.subGrpNum.Text = "";
            this.grpId.Text = "";
            this.subId.Text = "";
        }

        private void validateDetails()
        {
            if (academicYS.Text == "")
            {

                MessageBox.Show("type the Acadamic Year Semester");
            }

            else if (program.Text == "")
            {
                MessageBox.Show("Enter your program");
            }

            else if (grpNum.Text == "")
            {
                MessageBox.Show("Enter your group number");
            }

            else if (subGrpNum.Text == "")
            {
                MessageBox.Show("Enter your sub group number");
            }

            else if (grpId.Text == "")
            {
                MessageBox.Show("generate group id");
            }

            else if (subId.Text == "")
            {
                MessageBox.Show("Generate sub ID");
            }

            else
            {
                stdMode.AcademicYS = academicYS.Text;
                stdMode.Program = this.prgrm;
                stdMode.GrpNum = this.grpnum;
                stdMode.SubGrpNum = this.subgrpnum;
                stdMode.GrpId = grpId.Text;
                stdMode.SubGrpId = subId.Text;
                StdControl.insertSTDvaluesIntoDB(stdMode);

                this.academicYS.Text = "";
                this.program.Text = "";
                this.grpNum.Text = "";
                this.subGrpNum.Text = "";
                this.grpId.Text = "";
                this.subId.Text = "";
            }
        }
    
    }

}
