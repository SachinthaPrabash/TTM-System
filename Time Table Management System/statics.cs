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
using System.Windows.Forms.DataVisualization.Charting;

namespace Time_Table_Management_System
{
    public partial class statics : Form
    {
        DBcon DBConnection = new DBcon();
        SqlConnection con = new SqlConnection();

        public statics()
        {
            InitializeComponent();
            con = DBConnection.getDBConnection();
            
            //last data
            lastrecordroom();

            //total 
            totCalrooms();


        }

        private void statics_Load(object sender, EventArgs e)
        {
            //Fetch the Statistical data from database.
            string query = "Select  roomCapacity,roomName from roomTB";
            SqlDataAdapter da = new SqlDataAdapter(query, con);

            var dt = new DataTable();
            da.Fill(dt);

            //Get the names of ROOMS
            string[] x = (from p in dt.AsEnumerable()
                          orderby p.Field<string>("roomName") ascending
                          select p.Field<string>("roomName")).ToArray();

            //Get the Total of CAPACITY
            int[] y = (from p in dt.AsEnumerable()
                       orderby p.Field<string>("roomName") ascending
                       select p.Field<int>("roomCapacity")).ToArray();

            chart1.Series[0].LegendText = "roomCapacity";
            
            //chart1.Series[0].ChartType = SeriesChartType.Bar;
            //chart1.Series[0].IsValueShownAsLabel = true;
            chart1.Series[0].Points.DataBindXY(x, y);
        }

        void lastrecordroom()
        {
            con.Open();
            SqlDataAdapter sd = new SqlDataAdapter("SELECT roomName from roomTB  ORDER BY roomID DESC ", con);
            DataTable dt1 = new DataTable();
            sd.Fill(dt1);
            label9.Text = dt1.Rows[0][0].ToString();
            con.Close();
        }

        void totCalrooms()
        {
            con.Open();
            SqlDataAdapter sd = new SqlDataAdapter("select count(distinct roomName) from roomTB  ", con);
            DataTable dt1 = new DataTable();
            sd.Fill(dt1);
            totrooms.Text = dt1.Rows[0][0].ToString();
            con.Close();
        }
    }
}
