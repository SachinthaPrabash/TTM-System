using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time_Table_Management_System
{
    public partial class Homepage : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-UCQ3NA3T\SQLEXPRESS;Initial Catalog=TLM;Integrated Security=True");
        public Homepage()
        {
            InitializeComponent();
            customizeDialog();
        }

        private void customizeDialog()
        {
            lecturePanel.Visible = false;
            Studentpanel.Visible = false;
            subjectpanel.Visible = false;
            Workingdaypanel.Visible = false;
            tagpanel.Visible = false;
            locationpanel.Visible = false;
            sessionpanel.Visible = false;
            manageSessionpanel.Visible = false;


        }

        private void hideSubMenu()
        {
            if (lecturePanel.Visible = true)
                lecturePanel.Visible = false;
            if (Studentpanel.Visible = true)
                Studentpanel.Visible = false;
            if (subjectpanel.Visible = true)
                subjectpanel.Visible = false;
            if (Workingdaypanel.Visible = true)
                Workingdaypanel.Visible = false;
            if (tagpanel.Visible = true)
                tagpanel.Visible = false;
            if (locationpanel.Visible = true)
                locationpanel.Visible = false;
            if (sessionpanel.Visible = true)
                sessionpanel.Visible = false;
            if (manageSessionpanel.Visible = true)
                manageSessionpanel.Visible = false;

        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                //hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;

        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelchildForm.Controls.Add(childForm);
            panelchildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            openChildForm(new manageLecturer());
            showSubMenu(lecturePanel);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            openChildForm(new addLecturer());
        }

        private void button19_Click(object sender, EventArgs e)
        {
            openChildForm(new manageSubject());
            showSubMenu(subjectpanel);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            openChildForm(new addSubject());
        }

        private void button25_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageLocation());
            showSubMenu(locationpanel);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            openChildForm(new addlocation());
        }

        private void button17_Click(object sender, EventArgs e)
        {
            openChildForm(new AddRooms());
        }

        private void button27_Click(object sender, EventArgs e)
        {
            openChildForm(new manageSession());
            showSubMenu(sessionpanel);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            openChildForm(new addSession());
        }

        private void button29_Click(object sender, EventArgs e)
        {
            openChildForm(new Add_Room_to_Session());
            showSubMenu(manageSessionpanel);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            openChildForm(new Manage_session());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            openChildForm(new Assign_rooms_for__Lecturer());
        }

        private void button11_Click(object sender, EventArgs e)
        {
            openChildForm(new Assign_rooms_for_Groups());
        }

        private void button12_Click(object sender, EventArgs e)
        {
            openChildForm(new Assign_rooms_for_Subject());
        }

        private void button21_Click(object sender, EventArgs e)
        {
            
            showSubMenu(Workingdaypanel);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            openChildForm(new AddWorkingDays());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new NotAvailableTime());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new NotAvailableLoccation());
        }

        private void Stude_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageStd());
            showSubMenu(Studentpanel);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            openChildForm(new AddStd());
        }

        private void button23_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageTags());
            showSubMenu(tagpanel);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            openChildForm(new AddTags());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new nonOverlap());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChildForm(new consecutive());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openChildForm(new parallel());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            openChildForm(new SessionTA());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            openChildForm(new statics());
        }

        private void lecturePanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
