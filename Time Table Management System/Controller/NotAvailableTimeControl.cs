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
    class NotAvailableTimeControl
    {
        DBcon DBConnection = new DBcon();
        SqlConnection con1 = new SqlConnection();

        public NotAvailableTimeControl()
        {
            con1 = DBConnection.getDBConnection();
        }

        private static int Execution(SqlCommand command)
        {

            return command.ExecuteNonQuery();

        }

        //Insert queries

        public void InsertnotAvailableDetails(NotAvailableTimeModel add)
        {

            if (con1.State.ToString() != "Open")
            {
                con1.Open();
            }
            string query = "insert into NotAvailableTime  values('" + add.date + "','" + add.lecturerName + "','" + add.group + "','" + add.subGroup + "','" + add.sessionID + "','" + add.startTime + "','" + add.endTime + "')";

            SqlCommand com = new SqlCommand(query, con1);
            int ret = Execution(com);
            MessageBox.Show("inserted succesfully");
            con1.Close();

        }


        //Retrive queries


        public DataTable getNotAvailablevalues()
        {
            if (con1.State.ToString() != "Open")
            {
                con1.Open();
            }

            DataTable dtbuilding = new DataTable();

            string query = "select * from NotAvailableTime";

            SqlDataReader dr2 = new SqlCommand(query, con1).ExecuteReader();

            dtbuilding.Load(dr2);
            return dtbuilding;
        }


        //Delete queries

        public void DeleteNotaAvailableDetails(int Id)
        {
            if (con1.State.ToString() != "Open")
            {
                con1.Open();
            }

            string query = "DELETE FROM NotAvailableTime WHERE Id= '" + Id + "'";

            SqlCommand com = new SqlCommand(query, con1);

            string ans = MessageBox.Show("Are sure to delete this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).ToString();

            if (ans == "Yes")
            {
                com.ExecuteNonQuery();
                MessageBox.Show(" Records Successfully Deleted");

            }
            con1.Close();


        }

        //Update queries

        public void UpdatenotAvailableDetails(NotAvailableTimeModel update)
        {

            if (con1.State.ToString() != "Open")
            {
                con1.Open();
            }

            string query = "update NotAvailableTime set Date='" + update.date + "',LecturerName='" + update.lecturerName + "',[Group] ='" + update.group + "', SubGroup ='" + update.subGroup + "',SessionID ='" + update.sessionID + "',StartTime = '" + update.startTime + "',EndTime='" + update.endTime + "' where Id = '" + update.id + "' ";


            SqlCommand com = new SqlCommand(query, con1);
            int ret = Execution(com);
            MessageBox.Show("Updated succesfully");
            con1.Close();

        }
    }
}