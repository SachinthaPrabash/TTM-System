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
    public partial class Add_Room_to_Session : Form
    {
        DBcon DBConnection = new DBcon();
        SqlConnection con = new SqlConnection();


        ManageSessionControl ManageSessionControl = new ManageSessionControl();

        public Add_Room_to_Session()
        {
            InitializeComponent();
        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Add_Room_to_Session_Load(object sender, EventArgs e)
        {
            bunifuDataGridView1.DataSource = ManageSessionControl.fullsessionretrive();
        }
    }
}
