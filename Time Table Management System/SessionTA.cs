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
    public partial class SessionTA : Form
    {
        DBcon DBConnection = new DBcon();
        SqlConnection con = new SqlConnection();

     
        public SessionTA()
        {
            InitializeComponent();
            con = DBConnection.getDBConnection();

        }

        SessionController sesControl = new SessionController();
        SessionModel sesMode = new SessionModel();


        //retrieve
        public void RetrieveSessionsDetails()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            String StudentRetrieveQuery = "select * from session";
            SqlCommand cmd = new SqlCommand(StudentRetrieveQuery, con);
            cmd.CommandType = CommandType.Text;

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataTable DT = new DataTable();
            DA.Fill(DT);
            this.SessionTB.DataSource = DT;

            con.Close();



        }

        public void insertSession(String id, String sts)
        {
            sesMode.SessionID = id;
            sesMode.Status1 = sts;
            sesControl.insertSessionValuesIntoDB(sesMode);

            this.sessionsId.Text = "";



        }

        private void SessionTA_Load(object sender, EventArgs e)
        {
            RetrieveSessionsDetails();
        }


        private void cnt_Click(object sender, EventArgs e)
        {
                
           this.insertSession(this.sessionsId.Text, "Consecutive");
            
            
            
        }

        private void Pbtn_Click(object sender, EventArgs e)
        {
            
            this.insertSession(this.sessionsId.Text, "Parallel");
            
            
        }

        private void NObtn_Click(object sender, EventArgs e)
        {
            
            this.insertSession(this.sessionsId.Text, "NonOverlapping");
            
        }

        private void SessionTB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addSes_Click(object sender, EventArgs e)
        {
            
        }

        private void clear_Click(object sender, EventArgs e)
        {
            this.sessionsId.Text = "";

        }
    }
}
