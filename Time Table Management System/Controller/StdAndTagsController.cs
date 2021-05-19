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
    class StdAndTagsController
    {
        DBcon DBConnection = new DBcon();
        SqlConnection con = new SqlConnection();

        //public string stdId;
        

        public StdAndTagsController()
        {
            con = DBConnection.getDBConnection();
        }

        private static int NewMethod(SqlCommand com)
        {
            return com.ExecuteNonQuery();
        }



        //std insert query
        public void insertSTDvaluesIntoDB(StdModel Stdmode)
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }
            string StdInsertQuery = "INSERT INTO StudentGroup(AcademicYearSem,Program,GroupNum,GroupID,SubGroupNum,SubGroupID)VALUES(@academicys,@prg,@grpN,@grpId,@subGrpN,@subGrpid)";
            SqlCommand cmd = new SqlCommand(StdInsertQuery, con);

            cmd.Parameters.Add(new SqlParameter("academicys", Stdmode.AcademicYS));
            cmd.Parameters.Add(new SqlParameter("prg", Stdmode.Program));
            cmd.Parameters.Add(new SqlParameter("grpN", Stdmode.GrpNum));
            cmd.Parameters.Add(new SqlParameter("grpId", Stdmode.GrpId));
            cmd.Parameters.Add(new SqlParameter("subGrpN", Stdmode.SubGrpNum));
            cmd.Parameters.Add(new SqlParameter("subGrpid", Stdmode.SubGrpId));

            cmd.ExecuteNonQuery();
            MessageBox.Show("No of Records have been inserted  Information");
            con.Close();
        }


        //tags insert query
        public void insertTagvaluesIntoDB(TagModel Tagmode)
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string StdInsertQuery = "INSERT INTO TagTB(TagName, TagCode, RelatedTag)VALUES(@TagNames,@TagCode,@RelatedTag)";
            SqlCommand cmd = new SqlCommand(StdInsertQuery, con);

            cmd.Parameters.Add(new SqlParameter("TagNames", Tagmode.TagName));
            cmd.Parameters.Add(new SqlParameter("TagCode", Tagmode.TagCode));
            cmd.Parameters.Add(new SqlParameter("RelatedTag", Tagmode.RelatedTag));

            cmd.ExecuteNonQuery();
            MessageBox.Show("All the data Added");
            con.Close();
        }

        //delete std

        public void deleteStdData(String id)
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string query = "DELETE FROM StudentGroup WHERE StudentgropID= '" + id + "'";

            SqlCommand com = new SqlCommand(query, con);

            string ans = MessageBox.Show("Are sure to delete this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).ToString();

            if (ans == "Yes")
            {
                com.ExecuteNonQuery();
                MessageBox.Show(" records deleted");
            }
            con.Close();
        }

        //delete tag

        public void deletetagData(String id)
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string query = "DELETE FROM TagTB WHERE TagID= '" + id + "'";

            SqlCommand com = new SqlCommand(query, con);

            string ans = MessageBox.Show("Are sure to delete this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).ToString();

            if (ans == "Yes")
            {
                com.ExecuteNonQuery();
                MessageBox.Show(" records deleted");


            }
            con.Close();
        }

    }
}
