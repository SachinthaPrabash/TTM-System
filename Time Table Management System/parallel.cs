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
    public partial class parallel : Form
    {

        DBcon DBConnection = new DBcon();
        SqlConnection con = new SqlConnection();


        public parallel()
        {
            InitializeComponent();
            con = DBConnection.getDBConnection();
        }

        SessionController sesControl = new SessionController();
        SessionModel sesMode = new SessionModel();


        public void RetrieveparallelDetails()
        {
            con.Open();

            String RetrieveQuery = "select P.Pid as PID, S.* from session S, ParallelTB P WHERE P.Sid = S.sesId";
            SqlCommand cmd = new SqlCommand(RetrieveQuery, con);
            cmd.CommandType = CommandType.Text;

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataTable DT = new DataTable();
            DA.Fill(DT);
            this.parallelTB.DataSource = DT;

            con.Close();



        }

        private void parallel_Load(object sender, EventArgs e)
        {
            RetrieveparallelDetails();
        }


        public void DeleteDB(String Id, String sts)
        {
            sesControl.deleteSessionData(Id, sts);
            RetrieveparallelDetails();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dlt_Click(object sender, EventArgs e)
        {
            DeleteDB(this.ParallelId.Text, "Parallel");
            
        }

        private void back_Click(object sender, EventArgs e)
        {
            
        }

    }
}
