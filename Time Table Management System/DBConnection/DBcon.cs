using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_Table_Management_System.DBConnection
{
    class DBcon
    {
        public SqlConnection getDBConnection()
        {
            string conString = @"Data Source=LAPTOP-UCQ3NA3T\SQLEXPRESS;Initial Catalog=TLM;Integrated Security=True";
            SqlConnection con = new SqlConnection(conString);
            return con;
        }


    }
}
