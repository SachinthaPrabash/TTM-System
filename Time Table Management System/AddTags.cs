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

    public partial class AddTags : Form
    {
        DBcon DBConnection = new DBcon();
        SqlConnection con = new SqlConnection();

        public string relt;

        public AddTags()
        {
            InitializeComponent();
            con = DBConnection.getDBConnection();
        }

        StdAndTagsController TagControl = new StdAndTagsController();
        TagModel TagMode = new TagModel();

        private void saveAT_Click(object sender, EventArgs e)
        {
            

            validateDetails();

        }

        private void clearAT_Click(object sender, EventArgs e)
        {
            
            this.tagN.Text = "";
            this.tagC.Text = "";
            this.relatedT.Text = "";


        }

        private void validateDetails()
        {
            

            if (tagN.Text == "")
            {

                MessageBox.Show("Enter Tag Name");
            }

            else if (tagC.Text == "")
            {
                MessageBox.Show("Enter your Tag Code");
            }

            else if (relatedT.Text == "")
            {
                MessageBox.Show("Enter your Related Tags");
            }

            else
            {
                this.relt = this.relatedT.SelectedItem.ToString();

                TagMode.TagName = tagN.Text;
                TagMode.TagCode = tagC.Text;
                TagMode.RelatedTag = this.relt;
                TagControl.insertTagvaluesIntoDB(TagMode);

                this.tagN.Text = "";
                this.tagC.Text = "";
                this.relatedT.Text = "";

            }
        }

        private void relatedT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
