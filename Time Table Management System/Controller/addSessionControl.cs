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

    class addSessionControl
    {
        DBcon DBConnection = new DBcon();
        SqlConnection con = new SqlConnection();


        public addSessionControl() {
            con = DBConnection.getDBConnection();
        }


        private static int Execution(SqlCommand command)
        {

            return command.ExecuteNonQuery();

        }


        public void insertSessionDetails(addSessionModel add)
        {

            if (con.State.ToString() != "Open")
            {
                con.Open();
            }
            string query = "insert into session values((select lid from lecture where lecturerName='"+add.lec1+ "'),(select lid from lecture where lecturerName='" + add.lec2 + "'),(select TagID from TagTB where TagName='" + add.lec1_Tag + "'),(select StudentgropID from StudentGroup where SubGroupID='" + add.group_no + "'),'" + add.subject_name + "','" + add.noOfStudent + "','" + add.duration + "')";

            SqlCommand com = new SqlCommand(query, con);
            int ret = Execution(com);

            MessageBox.Show("inserted succesfully");
            con.Close();


        }


        public DataTable GetSessionDetails()
        {


            if (con.State.ToString() != "Open")
            {

                con.Open();

            }

            DataTable gotSessionDet = new DataTable();

            string query = "select distinct s.sesId,l.lecturerName,t.TagName,sg.SubGroupID,s.subject_name,s.noOfStudent,s.duration from session s,lecture l, lecture l2, TagTB t, StudentGroup sg, subject sb where s.lec1 = l.lid and s.lec1_Tag = t.TagID and s.group_no = sg.StudentgropID";
            SqlDataReader data = new SqlCommand(query, con).ExecuteReader();


            gotSessionDet.Load(data);
            return gotSessionDet;

        }


        //function for fdelete lecturer details 
        public void deleteRow(int IDNumber)
        {
            try
            {
                if (con.State.ToString() != "Open")
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("DELETE FROM session WHERE sesId = " + IDNumber, con))
                    {
                        command.ExecuteNonQuery();
                    }
                    con.Close();
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
            }
        }

        public void updateSession(string lec_1, string lec_2, string lec_tag_1, string groupno, string subjectname, int noOfStudent, decimal duration,int sessionId)
        {

            //
            try
            {
                if (con.State.ToString() != "Open")
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("update session set lec1=(select lid from lecture where lecturerName='"+lec_1+"'), lec2 = (select lid from lecture where lecturerName = '"+lec_2+"'),lec1_Tag = (select TagID from TagTB where TagName = '"+lec_tag_1+"'),group_no = (select StudentgropID from StudentGroup where SubGroupID = '"+groupno+"'),subject_name ='"+subjectname+"',noOfStudent = '"+noOfStudent+"',duration = '"+duration+ "' where sesId='"+ sessionId + "' ", con))
                    {
                        command.ExecuteNonQuery();
                    }
                    con.Close();
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
            }


        }



        public DataTable searchData(String search_value)
        {



            if (con.State.ToString() != "Open")
            {

                con.Open();

            }

            DataTable gotSessionDet = new DataTable();

            string query = "select * from session where CONCAT([sesId],[lec1],[lec2],[lec1_Tag],[group_no],[subject_name],[noOfStudent],[duration]) like '%" + search_value + "%'";
            SqlDataReader data = new SqlCommand(query, con).ExecuteReader();


            gotSessionDet.Load(data);
            return gotSessionDet;




        }


    }
}
