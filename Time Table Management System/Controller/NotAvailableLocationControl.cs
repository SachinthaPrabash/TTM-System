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
    class NotAvailableLocationControl
    {
        DBcon DBConnection = new DBcon();
        SqlConnection con1 = new SqlConnection();

        public NotAvailableLocationControl()
        {
            con1 = DBConnection.getDBConnection();
        }

        private static int Execution(SqlCommand command)
        {

            return command.ExecuteNonQuery();

        }

        //Insert queries

        public void InsertnotAvailableLocDetails(NotAvailableLocationModel add)
        {

            if (con1.State.ToString() != "Open")
            {
                con1.Open();
            }
            string query = "insert into NotAvailableLocation  values('"  +add.date + "',(select locationID from locationTB where locationName='"+add.loccation+ "'),(select roomID from roomTB where roomName='"+add.room+"'),'" + add.startTime + "','" + add.endTime + "')";

            SqlCommand com = new SqlCommand(query, con1);
            int ret = Execution(com);
            MessageBox.Show("Inserted Succesfully");
            con1.Close();

        }


        //Retrive queries


        public DataTable getNotAvailableLocvalues()
        {
            if (con1.State.ToString() != "Open")
            {
                con1.Open();
            }

            DataTable dtbuilding = new DataTable();

            string query = "select * from NotAvailableLocation";

            SqlDataReader dr2 = new SqlCommand(query, con1).ExecuteReader();

            dtbuilding.Load(dr2);
            return dtbuilding;
        }


        //Delete queries

        public void DeleteNotAvailableLocDetails(int Id)
        {
            if (con1.State.ToString() != "Open")
            {
                con1.Open();
            }

            string query = "DELETE FROM NotAvailableLocation WHERE Id= '" + Id + "'";

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

        public void UpdatenotAvailableLocDetails(NotAvailableLocationModel update)
        {

            if (con1.State.ToString() != "Open")
            {
                con1.Open();
            }
            
            string query = "update NotAvailableLocation set Date='" + update.date + "',Loccation=(select locationID from locationTB where locationName='" + update.loccation + "'),Room =(select roomID from roomTB where roomName='" + update.room + "'), StartTime ='" + update.startTime + "',EndTime ='" + update.endTime + "' where Id = '" + update.id + "' ";

            SqlCommand com = new SqlCommand(query, con1);
            int ret = Execution(com);
            MessageBox.Show("Updated succesfully");
            con1.Close();

        }
    }
}