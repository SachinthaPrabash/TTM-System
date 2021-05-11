using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Time_Table_Management_System.DBConnection;
using Time_Table_Management_System.Model;

namespace Time_Table_Management_System.Controller
{
    class staticsController
    {
        DBcon DBConnection = new DBcon();
        SqlConnection con = new SqlConnection();

        public staticsController()
        {
            con = DBConnection.getDBConnection();
        }

        public void lastrecordrooms()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }
            string query = "SELECT roomName from roomTB  ORDER BY roomID DESC ";

            SqlCommand com = new SqlCommand(query, con);
            com.ExecuteNonQuery();
            con.Close();
        }


    }
}
