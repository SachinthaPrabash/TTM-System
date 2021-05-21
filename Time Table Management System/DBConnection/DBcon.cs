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
            string conString = @"Server=tcp:ttms.database.windows.net,1433;Initial Catalog=TTM;Persist Security Info=False;User ID=adminuser;Password=admin@123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection con = new SqlConnection(conString);
            return con;
        }

        //Data Source=LAPTOP-UCQ3NA3T\SQLEXPRESS;Initial Catalog=TLM;Integrated Security=True

        
        //"Server=tcp:ttms.database.windows.net,1433;Initial Catalog=TTM;Persist Security Info=False;User ID=adminuser;Password=admin@123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
    }
    
}
