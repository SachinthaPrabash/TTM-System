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
using Time_Table_Management_System.Controller;
using System.Data.SqlClient;
using System.IO;

namespace Time_Table_Management_System
{
    public partial class Timetable : Form
    {
        public Timetable()
        {
            InitializeComponent();
            con = DBConnection.getDBConnection();
        }

        DBcon DBConnection = new DBcon();
        SqlConnection con = new SqlConnection();


        timeTableController TimeTableController = new timeTableController();

        private void button1_Click(object sender, EventArgs e)
        {
            String lec = lecinput.Text;

            dataGridView1.DataSource=  TimeTableController.Gettimetable(lec);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();

            String lec = lecinput.Text;


            SqlDataAdapter sd = new SqlDataAdapter(" select distinct s.sesId,w.WorkingDays,s.lec1,sg.SubGroupID,s.duration,r.roomname from WorkingDays w,session s, lecture l,StudentGroup sg, roomTB r,sessionForRoom sr where s.lec1 = l.lid and sr.sesID = s.sesId and sr.roomname = r.roomID and w.EmployeeId = l.lid and sg.StudentgropID = s.group_no and s.lec1 = '" + lec + "'   ", con);
            DataTable dt = new DataTable();
            sd.Fill(dt);

            StringBuilder sb = new StringBuilder();

            IEnumerable<string> columnNames = dt.Columns.Cast<DataColumn>().
                                              Select(column => column.ColumnName);
            sb.AppendLine(string.Join(",", columnNames));

            foreach (DataRow row in dt.Rows)
            {
                IEnumerable<string> fields = row.ItemArray.Select(field => field.ToString());
                sb.AppendLine(string.Join(",", fields));
            }

           // File.WriteAllText("test.pdf", sb.ToString());

            File.WriteAllText(Path.Combine(@"C:\Users\Public\Downloads", "test.csv"), sb.ToString());

            con.Close();

        }

   

    }
}
