using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Time_Table_Management_System.DBConnection;

namespace Time_Table_Management_System.Controller
{
    class timeTableController
    {
        DBcon DBConnection = new DBcon();
        SqlConnection con = new SqlConnection();

        public timeTableController()
        {
            con = DBConnection.getDBConnection();

        }

        public void selctDate( string lecName)
        {
            ArrayList arlist = new ArrayList();
            arlist.Add("Moday");
            arlist.Add("Tuesday");
            arlist.Add("Moday");
            arlist.Add("Moday");
            arlist.Add("Moday");
            arlist.Add("Moday");
            arlist.Add("Moday");

            ArrayList time = new ArrayList();
            arlist.Add("8.30-9.30");
            arlist.Add("9.30-10.30");
            arlist.Add("10.30-11.30");
            arlist.Add("Moday");
            arlist.Add("Moday");
            arlist.Add("Moday");
            arlist.Add("Moday");

            
            for (int i = 0; i < arlist.Count; i++)
            {
                if (arlist[i] == "Monday")
                {
                    
                    for(int duration = 0; duration <= 8; duration++)
                    {
                        //session --> duration data
                        //lecture --> session id
                        //


                    }


                }
            }
        }

        public void getTimeSloat()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }
            string query = "";

            SqlCommand com = new SqlCommand(query, con);
            com.ExecuteNonQuery();


            con.Close();
        }

        public ArrayList lecturetoSession(string lec)
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }
         

            DataSet ds = new DataSet();

            String query = "select s.sesId from session s,lecture l where s.lec1 = l.lid and l.lecturerName = '" + lec + "' ";
            SqlDataReader dr;
            SqlCommand com = new SqlCommand(query, con);

            SqlDataAdapter sda = new SqlDataAdapter(com);

            sda.Fill(ds);

            ArrayList lecToSes = new ArrayList();

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                lecToSes.Add(ds.Tables[0].Rows[i][0]);
            }

            con.Close();
            return lecToSes;

        }

        public void sessionDuration()
        {
            //lecturetosession --> sesid--> duration


            
        }


    }
        
        }
