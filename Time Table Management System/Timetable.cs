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
using System.Collections;

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


            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            DataTable gotLectureDet = new DataTable();

            string query = "select distinct s.sesId,l.lecturerName,sg.SubGroupID,s.duration,r.roomname,lo.locationName  " +
                "from WorkingDays w,session s,lecture l,StudentGroup sg, roomTB r,sessionForRoom sr,locationTB lo " +
                " where s.lec1 = l.lid and sr.sesID = s.sesId and lo.locationID=r.locationID and sr.roomname = r.roomID and sg.StudentgropID = s.group_no and s.lec1 = '"+lec+"' ";

            SqlDataReader data = new SqlCommand(query, con).ExecuteReader();


            gotLectureDet.Load(data);

            con.Close();

            DataTable newData = new DataTable();

            newData.Columns.Add("Time", typeof(String));
            newData.Columns.Add("Monday", typeof(String));
            newData.Columns.Add("Tuesday", typeof(String));
            newData.Columns.Add("Wednesday", typeof(String));
            newData.Columns.Add("Thursday", typeof(String));
            newData.Columns.Add("Friday", typeof(String));
            newData.Columns.Add("Saturday", typeof(String));
            newData.Columns.Add("Sunday", typeof(String));

            String[] timeSlot = new String[] { "08.30-09.30", "09.30-10.30", "10.30-11.30", "11.30-12.30", "12.30-1.30", "01.30-02.30", "02.30-03.30", "03.30-04.30", "04.30-05.30" };

            for (int i = 0; i < timeSlot.Length; i++)
            {
                newData.Rows.Add(new object[] { timeSlot[i], "--", "--", "--", "--", "--", "--", "--" });
            }

            foreach (DataRow row in gotLectureDet.Rows)
            {
                string ss = row[0] + ":" + row[1] + ":" + row[2] + ":" + row[3] + ":" + row[4] + ":" + row[5];

                string col = null;

                if (row[5].Equals("Monday"))
                {
                    col = "Monday";
                }
                else if (row[5].Equals("Tuesday"))
                {
                    col = "Tuesday";
                }
                else if (row[5].Equals("Wednesday"))
                {
                    col = "Wednesday";
                }
                else if (row[5].Equals("Thursday"))
                {
                    col = "Thursday";
                }
                else if (row[5].Equals("Friday"))
                {
                    col = "Friday";
                }

                for (int i = 0; i < timeSlot.Length; i++)
                {
                    if (row[4].Equals(timeSlot[i]))
                    {
                        newData.Rows[i][col] = ss;
                        break;
                    }
                }
            }
        

            dataGridView2.DataSource = newData;

             dataGridView1.DataSource=  TimeTableController.Gettimetable(lec);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();

            String lec = lecinput.Text;

            SqlDataAdapter sd = new SqlDataAdapter("select distinct s.sesId, l.lecturerName, sg.SubGroupID, s.duration, r.roomname, lo.locationName from WorkingDays w,session s,lecture l,StudentGroup sg, roomTB r,sessionForRoom sr,locationTB lo  where s.lec1 = l.lid and sr.sesID = s.sesId and lo.locationID=r.locationID and sr.roomname = r.roomID and sg.StudentgropID = s.group_no and s.lec1 = '" + lec + "' ", con);
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
