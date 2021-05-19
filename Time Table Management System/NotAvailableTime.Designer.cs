
namespace Time_Table_Management_System
{
    partial class NotAvailableTime
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
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.selectsession = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.selectsubgroup = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.selectgroup = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.selectlecure = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.btnaddNA = new System.Windows.Forms.Button();
            this.btnupdateNA = new System.Windows.Forms.Button();
            this.btndeleteNA = new System.Windows.Forms.Button();
            this.dataviewNA = new System.Windows.Forms.DataGridView();
            this.selectend = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.selectstart1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tLMDataSet1 = new Time_Table_Management_System.TLMDataSet1();
            this.lectureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lectureTableAdapter = new Time_Table_Management_System.TLMDataSet1TableAdapters.lectureTableAdapter();
            this.tLMDataSet2 = new Time_Table_Management_System.TLMDataSet2();
            this.studentGroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentGroupTableAdapter = new Time_Table_Management_System.TLMDataSet2TableAdapters.StudentGroupTableAdapter();
            this.tLMDataSet4 = new Time_Table_Management_System.TLMDataSet4();
            this.tLMDataSet4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tLMDataSet5 = new Time_Table_Management_System.TLMDataSet5();
            this.studentGroupBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studentGroupTableAdapter1 = new Time_Table_Management_System.TLMDataSet5TableAdapters.StudentGroupTableAdapter();
            this.studentGroupBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tLMDataSet6 = new Time_Table_Management_System.TLMDataSet6();
            this.sessionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sessionTableAdapter = new Time_Table_Management_System.TLMDataSet6TableAdapters.sessionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataviewNA)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tLMDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectureBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tLMDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentGroupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tLMDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tLMDataSet4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tLMDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentGroupBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentGroupBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tLMDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(104, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 34);
            this.label16.TabIndex = 69;
            this.label16.Text = "End Time (AM/PM)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 34);
            this.label15.TabIndex = 68;
            this.label15.Text = "Start Time (AM/PM)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.label14.Location = new System.Drawing.Point(3, 379);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 32);
            this.label14.TabIndex = 67;
            this.label14.Text = "Time";
            // 
            // selectsession
            // 
            this.selectsession.DataSource = this.sessionBindingSource;
            this.selectsession.DisplayMember = "sesId";
            this.selectsession.Dock = System.Windows.Forms.DockStyle.Top;
            this.selectsession.FormattingEnabled = true;
            this.selectsession.Location = new System.Drawing.Point(191, 317);
            this.selectsession.Name = "selectsession";
            this.selectsession.Size = new System.Drawing.Size(203, 24);
            this.selectsession.TabIndex = 66;
            this.selectsession.ValueMember = "sesId";
            this.selectsession.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.label13.Location = new System.Drawing.Point(3, 314);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(173, 64);
            this.label13.TabIndex = 65;
            this.label13.Text = "Select Session ID";
            // 
            // selectsubgroup
            // 
            this.selectsubgroup.DataSource = this.studentGroupBindingSource2;
            this.selectsubgroup.DisplayMember = "SubGroupID";
            this.selectsubgroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.selectsubgroup.FormattingEnabled = true;
            this.selectsubgroup.Location = new System.Drawing.Point(191, 242);
            this.selectsubgroup.Name = "selectsubgroup";
            this.selectsubgroup.Size = new System.Drawing.Size(203, 24);
            this.selectsubgroup.TabIndex = 64;
            this.selectsubgroup.ValueMember = "SubGroupID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.label10.Location = new System.Drawing.Point(3, 239);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 64);
            this.label10.TabIndex = 63;
            this.label10.Text = "Select Sub Group";
            // 
            // selectgroup
            // 
            this.selectgroup.DataSource = this.studentGroupBindingSource1;
            this.selectgroup.DisplayMember = "GroupID";
            this.selectgroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.selectgroup.FormattingEnabled = true;
            this.selectgroup.Location = new System.Drawing.Point(191, 177);
            this.selectgroup.Name = "selectgroup";
            this.selectgroup.Size = new System.Drawing.Size(203, 24);
            this.selectgroup.TabIndex = 62;
            this.selectgroup.ValueMember = "GroupID";
            this.selectgroup.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.label9.Location = new System.Drawing.Point(3, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 32);
            this.label9.TabIndex = 61;
            this.label9.Text = "Select Group";
            // 
            // selectlecure
            // 
            this.selectlecure.DataSource = this.lectureBindingSource;
            this.selectlecure.DisplayMember = "lecturerName";
            this.selectlecure.Dock = System.Windows.Forms.DockStyle.Top;
            this.selectlecure.FormattingEnabled = true;
            this.selectlecure.Location = new System.Drawing.Point(191, 117);
            this.selectlecure.Name = "selectlecure";
            this.selectlecure.Size = new System.Drawing.Size(203, 24);
            this.selectlecure.TabIndex = 60;
            this.selectlecure.ValueMember = "lecturerName";
            this.selectlecure.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.label8.Location = new System.Drawing.Point(3, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(172, 32);
            this.label8.TabIndex = 59;
            this.label8.Text = "Select Lecturer";
            // 
            // date
            // 
            this.date.CustomFormat = "yyyy--MM--dd";
            this.date.Dock = System.Windows.Forms.DockStyle.Top;
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date.Location = new System.Drawing.Point(191, 53);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(203, 22);
            this.date.TabIndex = 58;
            this.date.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 32);
            this.label7.TabIndex = 57;
            this.label7.Text = "Date";
            // 
            // btnaddNA
            // 
            this.btnaddNA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnaddNA.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnaddNA.Location = new System.Drawing.Point(530, 505);
            this.btnaddNA.Name = "btnaddNA";
            this.btnaddNA.Size = new System.Drawing.Size(112, 47);
            this.btnaddNA.TabIndex = 81;
            this.btnaddNA.Text = "ADD";
            this.btnaddNA.UseVisualStyleBackColor = false;
            this.btnaddNA.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnupdateNA
            // 
            this.btnupdateNA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnupdateNA.BackColor = System.Drawing.Color.Yellow;
            this.btnupdateNA.Location = new System.Drawing.Point(671, 507);
            this.btnupdateNA.Name = "btnupdateNA";
            this.btnupdateNA.Size = new System.Drawing.Size(110, 42);
            this.btnupdateNA.TabIndex = 91;
            this.btnupdateNA.Text = "UPDATE";
            this.btnupdateNA.UseVisualStyleBackColor = false;
            this.btnupdateNA.Click += new System.EventHandler(this.btnupdateNA_Click);
            // 
            // btndeleteNA
            // 
            this.btndeleteNA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btndeleteNA.BackColor = System.Drawing.Color.Red;
            this.btndeleteNA.Location = new System.Drawing.Point(824, 507);
            this.btndeleteNA.Name = "btndeleteNA";
            this.btndeleteNA.Size = new System.Drawing.Size(110, 43);
            this.btndeleteNA.TabIndex = 92;
            this.btndeleteNA.Text = "DELETE";
            this.btndeleteNA.UseVisualStyleBackColor = false;
            this.btndeleteNA.Click += new System.EventHandler(this.btndeleteNA_Click);
            // 
            // dataviewNA
            // 
            this.dataviewNA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataviewNA.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataviewNA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataviewNA.Location = new System.Drawing.Point(507, 187);
            this.dataviewNA.Name = "dataviewNA";
            this.dataviewNA.RowHeadersWidth = 51;
            this.dataviewNA.RowTemplate.Height = 24;
            this.dataviewNA.Size = new System.Drawing.Size(373, 253);
            this.dataviewNA.TabIndex = 99;
            this.dataviewNA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // selectend
            // 
            this.selectend.Location = new System.Drawing.Point(104, 48);
            this.selectend.Name = "selectend";
            this.selectend.Size = new System.Drawing.Size(96, 22);
            this.selectend.TabIndex = 101;
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(191, 3);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(100, 22);
            this.id.TabIndex = 103;
            this.id.Visible = false;
            this.id.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // selectstart1
            // 
            this.selectstart1.Location = new System.Drawing.Point(3, 48);
            this.selectstart1.Name = "selectstart1";
            this.selectstart1.Size = new System.Drawing.Size(95, 22);
            this.selectstart1.TabIndex = 104;
            this.selectstart1.TextChanged += new System.EventHandler(this.selectstart1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(986, 49);
            this.panel1.TabIndex = 105;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(986, 68);
            this.panel2.TabIndex = 106;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(459, 36);
            this.label2.TabIndex = 26;
            this.label2.Text = "Not Available Times Allocation";
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 117);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(84, 523);
            this.panel3.TabIndex = 107;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(84, 117);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(902, 47);
            this.panel4.TabIndex = 108;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.60705F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.39295F));
            this.tableLayoutPanel1.Controls.Add(this.id, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.date, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.selectlecure, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.selectgroup, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.selectsubgroup, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label13, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.selectsession, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label14, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(84, 164);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.68525F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.44538F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.60504F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.65546F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.7563F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.65546F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.95798F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(397, 476);
            this.tableLayoutPanel1.TabIndex = 109;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label15, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label16, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.selectstart1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.selectend, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(191, 382);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(203, 91);
            this.tableLayoutPanel2.TabIndex = 104;
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
            // tLMDataSet2
            // 
            this.tLMDataSet2.DataSetName = "TLMDataSet2";
            this.tLMDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentGroupBindingSource
            // 
            this.studentGroupBindingSource.DataMember = "StudentGroup";
            this.studentGroupBindingSource.DataSource = this.tLMDataSet2;
            // 
            // studentGroupTableAdapter
            // 
            this.studentGroupTableAdapter.ClearBeforeFill = true;
            // 
            // tLMDataSet4
            // 
            this.tLMDataSet4.DataSetName = "TLMDataSet4";
            this.tLMDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tLMDataSet4BindingSource
            // 
            this.tLMDataSet4BindingSource.DataSource = this.tLMDataSet4;
            this.tLMDataSet4BindingSource.Position = 0;
            // 
            // tLMDataSet5
            // 
            this.tLMDataSet5.DataSetName = "TLMDataSet5";
            this.tLMDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentGroupBindingSource1
            // 
            this.studentGroupBindingSource1.DataMember = "StudentGroup";
            this.studentGroupBindingSource1.DataSource = this.tLMDataSet5;
            // 
            // studentGroupTableAdapter1
            // 
            this.studentGroupTableAdapter1.ClearBeforeFill = true;
            // 
            // studentGroupBindingSource2
            // 
            this.studentGroupBindingSource2.DataMember = "StudentGroup";
            this.studentGroupBindingSource2.DataSource = this.tLMDataSet2;
            // 
            // tLMDataSet6
            // 
            this.tLMDataSet6.DataSetName = "TLMDataSet6";
            this.tLMDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sessionBindingSource
            // 
            this.sessionBindingSource.DataMember = "session";
            this.sessionBindingSource.DataSource = this.tLMDataSet6;
            // 
            // sessionTableAdapter
            // 
            this.sessionTableAdapter.ClearBeforeFill = true;
            // 
            // NotAvailableTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 640);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataviewNA);
            this.Controls.Add(this.btndeleteNA);
            this.Controls.Add(this.btnupdateNA);
            this.Controls.Add(this.btnaddNA);
            this.Name = "NotAvailableTime";
            this.Text = "NotAvailableTime";
            this.Load += new System.EventHandler(this.NotAvailableTime_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataviewNA)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tLMDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectureBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tLMDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentGroupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tLMDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tLMDataSet4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tLMDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentGroupBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentGroupBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tLMDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox selectsession;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox selectsubgroup;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox selectgroup;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox selectlecure;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnaddNA;
        private System.Windows.Forms.Button btnupdateNA;
        private System.Windows.Forms.Button btndeleteNA;
        private System.Windows.Forms.DataGridView dataviewNA;
        private System.Windows.Forms.TextBox selectend;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox selectstart1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private TLMDataSet1 tLMDataSet1;
        private System.Windows.Forms.BindingSource lectureBindingSource;
        private TLMDataSet1TableAdapters.lectureTableAdapter lectureTableAdapter;
        private TLMDataSet2 tLMDataSet2;
        private System.Windows.Forms.BindingSource studentGroupBindingSource;
        private TLMDataSet2TableAdapters.StudentGroupTableAdapter studentGroupTableAdapter;
        private System.Windows.Forms.BindingSource tLMDataSet4BindingSource;
        private TLMDataSet4 tLMDataSet4;
        private TLMDataSet5 tLMDataSet5;
        private System.Windows.Forms.BindingSource studentGroupBindingSource1;
        private TLMDataSet5TableAdapters.StudentGroupTableAdapter studentGroupTableAdapter1;
        private System.Windows.Forms.BindingSource studentGroupBindingSource2;
        private TLMDataSet6 tLMDataSet6;
        private System.Windows.Forms.BindingSource sessionBindingSource;
        private TLMDataSet6TableAdapters.sessionTableAdapter sessionTableAdapter;
    }
}