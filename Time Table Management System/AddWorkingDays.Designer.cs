
namespace Time_Table_Management_System
{
    partial class AddWorkingDays
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnupdate = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataview = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.Aid = new System.Windows.Forms.TextBox();
            this.textBox1 = new Bunifu.UI.WinForms.BunifuDropdown();
            this.tLMDataSet1 = new Time_Table_Management_System.TLMDataSet1();
            this.lectureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lectureTableAdapter = new Time_Table_Management_System.TLMDataSet1TableAdapters.lectureTableAdapter();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tLMDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectureBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnupdate
            // 
            this.btnupdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnupdate.BackColor = System.Drawing.Color.Yellow;
            this.btnupdate.Location = new System.Drawing.Point(690, 518);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(110, 42);
            this.btnupdate.TabIndex = 90;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 41);
            this.label7.TabIndex = 89;
            this.label7.Text = "Employee ID ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // comboBox5
            // 
            this.comboBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "01 Hour",
            "02 Hours",
            "03 Hours",
            "04 Hours"});
            this.comboBox5.Location = new System.Drawing.Point(224, 414);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(215, 24);
            this.comboBox5.TabIndex = 87;
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // comboBox4
            // 
            this.comboBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "08 : 30 AM",
            "12 : 30 PM",
            "05 : 30 PM"});
            this.comboBox4.Location = new System.Drawing.Point(224, 332);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(215, 24);
            this.comboBox4.TabIndex = 86;
            // 
            // comboBox3
            // 
            this.comboBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "04 Hours",
            "05 Hours",
            "06 Hours",
            "07 Hours",
            "08 Hours",
            "09 Hours",
            "10 Hour"});
            this.comboBox3.Location = new System.Drawing.Point(224, 250);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(215, 24);
            this.comboBox3.TabIndex = 85;
            // 
            // comboBox2
            // 
            this.comboBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Weekdays",
            "Weekends"});
            this.comboBox2.Location = new System.Drawing.Point(224, 168);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(215, 24);
            this.comboBox2.TabIndex = 84;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // btndelete
            // 
            this.btndelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btndelete.BackColor = System.Drawing.Color.Red;
            this.btndelete.Location = new System.Drawing.Point(821, 517);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(110, 43);
            this.btndelete.TabIndex = 82;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.label6.Location = new System.Drawing.Point(3, 411);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 41);
            this.label6.TabIndex = 81;
            this.label6.Text = "Time Slot";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.label5.Location = new System.Drawing.Point(3, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 41);
            this.label5.TabIndex = 80;
            this.label5.Text = "Start Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.label4.Location = new System.Drawing.Point(3, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 82);
            this.label4.TabIndex = 79;
            this.label4.Text = "Working Time Per Day";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.label3.Location = new System.Drawing.Point(3, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 41);
            this.label3.TabIndex = 78;
            this.label3.Text = "Working Days";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.label1.Location = new System.Drawing.Point(3, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 82);
            this.label1.TabIndex = 77;
            this.label1.Text = "No Of Working Days";
            // 
            // btnadd
            // 
            this.btnadd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnadd.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnadd.Location = new System.Drawing.Point(560, 513);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(112, 47);
            this.btnadd.TabIndex = 76;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click_1);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, -114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(442, 36);
            this.label2.TabIndex = 75;
            this.label2.Text = "Add Working Days And Hours";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(62, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(442, 36);
            this.label8.TabIndex = 95;
            this.label8.Text = "Add Working Days And Hours";
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.comboBox1.Location = new System.Drawing.Point(224, 61);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(215, 24);
            this.comboBox1.TabIndex = 96;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(986, 49);
            this.panel1.TabIndex = 99;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Aid);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(986, 61);
            this.panel2.TabIndex = 100;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.comboBox1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBox2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.comboBox5, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.comboBox4, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.comboBox3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(62, 143);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.7737F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.55963F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(442, 497);
            this.tableLayoutPanel1.TabIndex = 101;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 110);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(62, 530);
            this.panel4.TabIndex = 103;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(62, 110);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(924, 27);
            this.panel3.TabIndex = 104;
            // 
            // dataview
            // 
            this.dataview.AllowCustomTheming = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dataview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataview.ColumnHeadersHeight = 40;
            this.dataview.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dataview.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataview.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataview.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataview.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataview.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dataview.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataview.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dataview.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dataview.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataview.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dataview.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataview.CurrentTheme.Name = null;
            this.dataview.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataview.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataview.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataview.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataview.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataview.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataview.EnableHeadersVisualStyles = false;
            this.dataview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataview.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dataview.HeaderBgColor = System.Drawing.Color.Empty;
            this.dataview.HeaderForeColor = System.Drawing.Color.White;
            this.dataview.Location = new System.Drawing.Point(544, 204);
            this.dataview.Name = "dataview";
            this.dataview.RowHeadersVisible = false;
            this.dataview.RowHeadersWidth = 51;
            this.dataview.RowTemplate.Height = 40;
            this.dataview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataview.Size = new System.Drawing.Size(418, 255);
            this.dataview.TabIndex = 105;
            this.dataview.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dataview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuDataGridView1_CellContentClick);
            // 
            // Aid
            // 
            this.Aid.Location = new System.Drawing.Point(588, 16);
            this.Aid.Name = "Aid";
            this.Aid.Size = new System.Drawing.Size(152, 22);
            this.Aid.TabIndex = 106;
            this.Aid.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Transparent;
            this.textBox1.BackgroundColor = System.Drawing.Color.White;
            this.textBox1.BorderColor = System.Drawing.Color.Silver;
            this.textBox1.BorderRadius = 1;
            this.textBox1.Color = System.Drawing.Color.Silver;
            this.textBox1.DataSource = this.lectureBindingSource;
            this.textBox1.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.textBox1.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.textBox1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.textBox1.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.textBox1.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBox1.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.textBox1.DisplayMember = "lid";
            this.textBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.textBox1.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.textBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.textBox1.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.textBox1.FillDropDown = true;
            this.textBox1.FillIndicator = false;
            this.textBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.FormattingEnabled = true;
            this.textBox1.Icon = null;
            this.textBox1.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.textBox1.IndicatorColor = System.Drawing.Color.Gray;
            this.textBox1.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.textBox1.ItemBackColor = System.Drawing.Color.White;
            this.textBox1.ItemBorderColor = System.Drawing.Color.White;
            this.textBox1.ItemForeColor = System.Drawing.Color.Black;
            this.textBox1.ItemHeight = 26;
            this.textBox1.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.textBox1.ItemHighLightForeColor = System.Drawing.Color.White;
            this.textBox1.ItemTopMargin = 3;
            this.textBox1.Location = new System.Drawing.Point(224, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(215, 32);
            this.textBox1.TabIndex = 97;
            this.textBox1.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.textBox1.TextLeftMargin = 5;
            this.textBox1.ValueMember = "lid";
            // 
            // tLMDataSet1
            // 
            this.tLMDataSet1.DataSetName = "TLMDataSet1";
            this.tLMDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lectureBindingSource
            // 
            this.lectureBindingSource.DataMember = "lecture";
            this.lectureBindingSource.DataSource = this.tLMDataSet1;
            // 
            // lectureTableAdapter
            // 
            this.lectureTableAdapter.ClearBeforeFill = true;
            // 
            // AddWorkingDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(986, 640);
            this.Controls.Add(this.dataview);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.label2);
            this.Name = "AddWorkingDays";
            this.Text = "AddWorkingDays";
            this.Load += new System.EventHandler(this.AddWorkingDays_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tLMDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectureBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.UI.WinForms.BunifuDataGridView dataview;
        private System.Windows.Forms.TextBox Aid;
        private Bunifu.UI.WinForms.BunifuDropdown textBox1;
        private TLMDataSet1 tLMDataSet1;
        private System.Windows.Forms.BindingSource lectureBindingSource;
        private TLMDataSet1TableAdapters.lectureTableAdapter lectureTableAdapter;
    }
}