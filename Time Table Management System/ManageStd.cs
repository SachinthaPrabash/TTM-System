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
    public partial class ManageStd : Form
    {

        DBcon DBConnection = new DBcon();
        SqlConnection con = new SqlConnection();

        public string academicys;
        public string prgrm;
        public string grpnum;
        public string subgrpnum;
        public string grpid;
        public string subgrpid;

        public ManageStd()
        {
            InitializeComponent();
            con = DBConnection.getDBConnection();
        }

        StdAndTagsController StdControl = new StdAndTagsController();
        StdModel stdMode = new StdModel();

        private void stdTB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ManageStd_Load(object sender, EventArgs e)
        {
            this.RetrieveStudentDetails();
            
        }

        
        private void clear_Click(object sender, EventArgs e)
        {
            this.StdID.Text = "";
            this.academicYS.Text = "";
            this.program.Text = "";
            this.grpNum.Text = "";
            this.subGrpNum.Text = "";
            this.grpId.Text = "";
            this.subId.Text = "";
        }

        private void delete_Click(object sender, EventArgs e)
        {
            StdControl.deleteStdData(this.StdID.Text);
            RetrieveStudentDetails();

            this.StdID.Text = "";
            this.academicYS.Text = "";
            this.program.Text = "";
            this.grpNum.Text = "";
            this.subGrpNum.Text = "";
            this.grpId.Text = "";
            this.subId.Text = "";
        }

       
        

        private void update_Click(object sender, EventArgs e)
        {
            this.generate();
            
            
        }

        private void search_Click_1(object sender, EventArgs e)
        {
            this.DataRetrieve(this.StdID.Text);

        }

        private void subGrpNum_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        public void generate()
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

            this.UpdateDB();
        }


        public void RetrieveStudentDetails()
        {
            con.Open();

            String StudentRetrieveQuery = "select * from StudentGroup";
            SqlCommand cmd = new SqlCommand(StudentRetrieveQuery, con);
            cmd.CommandType = CommandType.Text;

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataTable DT = new DataTable();
            DA.Fill(DT);
            this.stdTB.DataSource = DT;

            con.Close();



        }


        public void DataRetrieve(String id)
        {
            con.Open();

            String DataRetrieveQuery = "select * from StudentGroup WHERE StudentgropID = @stdID";
            SqlCommand cmd = new SqlCommand(DataRetrieveQuery, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@stdID", id);
            SqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                this.StdID.Text = dataReader.GetValue(0).ToString();
                this.academicYS.Text = dataReader.GetValue(1).ToString();
                this.program.Text = dataReader.GetValue(2).ToString();
                this.grpNum.Text = dataReader.GetValue(3).ToString();
                this.grpId.Text = dataReader.GetValue(4).ToString();
                this.subGrpNum.Text = dataReader.GetValue(5).ToString();
                this.subId.Text = dataReader.GetValue(6).ToString();

            }
            con.Close();
        }



        public void UpdateDB()
        {

            con.Open();
            String StdUpdateQuery = "UPDATE StudentGroup SET AcademicYearSem = @academicys, Program = @prgram, GroupNum = @grpN, GroupID = @grpId, SubGroupNum = @subNum, SubGroupID = @subId WHERE StudentgropID = @StdID ";
            SqlCommand cmd = new SqlCommand(StdUpdateQuery, con);
            cmd.CommandType = CommandType.Text;

            //cmd.Parameters.AddWithValue("@stdID", uid);

            cmd.Parameters.AddWithValue("@StdID", this.StdID.Text.Trim());
            cmd.Parameters.AddWithValue("@academicys", this.academicYS.Text.Trim());
            cmd.Parameters.AddWithValue("@prgram", this.program.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@grpN", this.grpNum.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@grpId", this.grpId.Text.Trim());
            cmd.Parameters.AddWithValue("@subNum", this.subGrpNum.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@subId", this.subId.Text.Trim());

            cmd.ExecuteNonQuery();

            string ans = MessageBox.Show("Are sure to update this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).ToString();

            if (ans == "Yes")
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show(" records updated");
            }


            con.Close();

            RetrieveStudentDetails();
            this.StdID.Text = "";
            this.academicYS.Text = "";
            this.program.Text = "";
            this.grpNum.Text = "";
            this.subGrpNum.Text = "";
            this.grpId.Text = "";
            this.subId.Text = "";

        }

    }
}
