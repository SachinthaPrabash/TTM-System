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
using Time_Table_Management_System.Model;
using Time_Table_Management_System.Controller;
using System.Data.SqlClient;

namespace Time_Table_Management_System
{
    public partial class ManageTags : Form
    {
        DBcon DBConnection = new DBcon();
        SqlConnection con = new SqlConnection();

        public ManageTags()
        {
            InitializeComponent();
            con = DBConnection.getDBConnection();
        }

        StdAndTagsController TagControl = new StdAndTagsController();
        TagModel TagMode = new TagModel();


        public void RetrieveTagsDetails()
        {
            con.Open();

            String StudentRetrieveQuery = "select * from TagTB";
            SqlCommand cmd = new SqlCommand(StudentRetrieveQuery, con);
            cmd.CommandType = CommandType.Text;

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataTable DT = new DataTable();
            DA.Fill(DT);
            this.tagTB.DataSource = DT;

            con.Close();



        }

        private void ManageTags_Load(object sender, EventArgs e)
        {
            RetrieveTagsDetails();
        }

        private void clearMT_Click(object sender, EventArgs e)
        {
            this.Tagid.Text = "";
            this.tagN.Text = "";
            this.tagC.Text = "";
            this.relatedT.Text = "";
        }

        private void deleteMT_Click(object sender, EventArgs e)
        {
            TagControl.deletetagData(this.Tagid.Text);
            RetrieveTagsDetails();
            this.Tagid.Text = "";
            this.tagN.Text = "";
            this.tagC.Text = "";
            this.relatedT.Text = "";

        }

        private void Tagid_TextChanged(object sender, EventArgs e)
        {

        }

        public void DataRetrieve(String id)
        {
            con.Open();

            String DataRetrieveQuery = "select * from TagTB WHERE TagID = @tagId";
            SqlCommand cmd = new SqlCommand(DataRetrieveQuery, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@tagId", id);
            SqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                this.Tagid.Text = dataReader.GetValue(0).ToString();
                this.tagN.Text = dataReader.GetValue(1).ToString();
                this.tagC.Text = dataReader.GetValue(2).ToString();
                this.relatedT.Text = dataReader.GetValue(3).ToString();
            }
            con.Close();
        }

        private void search_Click(object sender, EventArgs e)
        {
            this.DataRetrieve(this.Tagid.Text);

        }


        public void UpdateDB()
        {

            con.Open();
            String TagsUpdateQuery = "UPDATE TagTB SET TagName = @TagNames, TagCode = @TagCode, RelatedTag = @RelatedTag WHERE TagID = @tagId ";
            SqlCommand cmd = new SqlCommand(TagsUpdateQuery, con);
            cmd.CommandType = CommandType.Text;

            

            cmd.Parameters.AddWithValue("@tagId", this.Tagid.Text.Trim());
            cmd.Parameters.AddWithValue("@TagNames", this.tagN.Text.Trim());
            cmd.Parameters.AddWithValue("@TagCode", this.tagC.Text.Trim());
            cmd.Parameters.AddWithValue("@RelatedTag", this.relatedT.SelectedItem.ToString());

            cmd.ExecuteNonQuery();

            string ans = MessageBox.Show("Are sure to update this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).ToString();

            if (ans == "Yes")
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show(" records updated");
               
            }


            con.Close();

            RetrieveTagsDetails();
            this.Tagid.Text = "";
            this.tagN.Text = "";
            this.tagC.Text = "";
            this.relatedT.Text = "";

        }

        private void updateMT_Click(object sender, EventArgs e)
        {
            UpdateDB();
        }
    }

    
}
