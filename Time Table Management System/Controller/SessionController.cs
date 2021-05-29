using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Time_Table_Management_System.DBConnection;
using Time_Table_Management_System.Model;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Time_Table_Management_System.Controller
{
    class SessionController
    {

        DBcon DBConnection = new DBcon();
        SqlConnection con = new SqlConnection();


        public SessionController()
        {
            con = DBConnection.getDBConnection();
        }

        private static int NewMethod(SqlCommand com)
        {
            return com.ExecuteNonQuery();
        }


        //sessionStatus insert query
        public void insertSessionValuesIntoDB(SessionModel stMode)
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            if (stMode.Status1 == "Parallel")
            {
                string InsertQuery = "INSERT INTO ParallelTB VALUES((SELECT sesId FROM session WHERE sesId= @Sid), @Status)";

                SqlCommand cmd = new SqlCommand(InsertQuery, con);

                cmd.Parameters.Add(new SqlParameter("@Sid", stMode.SessionID));
                cmd.Parameters.Add(new SqlParameter("@Status", stMode.Status1));

                cmd.ExecuteNonQuery();
                MessageBox.Show("No of Records have been inserted  Information");
                con.Close();

            }

            else if (stMode.Status1 == "Consecutive")
            {
                string InsertQuery = "INSERT INTO ConsecutiveTB VALUES((SELECT sesId FROM session WHERE sesId= @Sid), @Status)";

                SqlCommand cmd = new SqlCommand(InsertQuery, con);

                cmd.Parameters.Add(new SqlParameter("Sid", stMode.SessionID));
                cmd.Parameters.Add(new SqlParameter("@Status", stMode.Status1));

                cmd.ExecuteNonQuery();
                MessageBox.Show("No of Records have been inserted  Information");
                con.Close();

            }

            else if (stMode.Status1 == "NonOverlapping")
            {
                string InsertQuery = "INSERT INTO  NonOverlapTB VALUES((SELECT sesId FROM session WHERE sesId= @Sid), @Status)";

                SqlCommand cmd = new SqlCommand(InsertQuery, con);

                cmd.Parameters.Add(new SqlParameter("Sid", stMode.SessionID));
                cmd.Parameters.Add(new SqlParameter("@Status", stMode.Status1));

                cmd.ExecuteNonQuery();
                MessageBox.Show("No of Records have been inserted  Information");
                con.Close();

            }
        }



        //delete 

        public void deleteSessionData(String id, String sts)
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            if (sts == "Parallel")
            {

                string query = "DELETE FROM ParallelTB WHERE Pid= '" + id + "'";

                SqlCommand com = new SqlCommand(query, con);

                string ans = MessageBox.Show("Are sure to delete this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).ToString();

                if (ans == "Yes")
                {
                    com.ExecuteNonQuery();
                    MessageBox.Show(" records deleted");


                }

            }

            else if (sts == "Consecutive")
            {

                string query = "DELETE FROM ConsecutiveTB WHERE Cid= '" + id + "'";

                SqlCommand com = new SqlCommand(query, con);

                string ans = MessageBox.Show("Are sure to delete this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).ToString();

                if (ans == "Yes")
                {
                    com.ExecuteNonQuery();
                    MessageBox.Show(" records deleted");


                }

            }

            else if (sts == "NonOverlapping")
            {

                string query = "DELETE FROM NonOverlapTB WHERE Nid= '" + id + "'";

                SqlCommand com = new SqlCommand(query, con);

                string ans = MessageBox.Show("Are sure to delete this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).ToString();

                if (ans == "Yes")
                {
                    com.ExecuteNonQuery();
                    MessageBox.Show(" records deleted");


                }

            }
            con.Close();
        }




    }
}
