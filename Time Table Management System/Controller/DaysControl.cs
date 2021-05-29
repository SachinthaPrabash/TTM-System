using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Time_Table_Management_System.DBConnection;
using Time_Table_Management_System.Model;

namespace Time_Table_Management_System.Controller
{
    class DaysControl
    {


        DBcon DBConnection = new DBcon();
        SqlConnection con = new SqlConnection();

        public DaysControl()
        {
            con = DBConnection.getDBConnection();
        }

        //Insert queries

        public void insertDays(addDaysModel daysMod)
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }
        
            string query = "insert into Days  values('" + daysMod.emp + "','" + daysMod.d1 + "','" + daysMod.d2 + "','" + daysMod.d3 + "','" + daysMod.d4 + "','" + daysMod.d5 + "','" + daysMod.d6 + "','" + daysMod.d7 + "')";


            SqlCommand cmd = new SqlCommand(query, con);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Successfully Inserted");

            con.Close();
        }



        //Retrive queries

        public DataTable getdaysvalues()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            DataTable dtbuilding = new DataTable();

            string query = "select * from Days";

            SqlDataReader dr1 = new SqlCommand(query, con).ExecuteReader();

            dtbuilding.Load(dr1);
            return dtbuilding;
        }


    }
}
