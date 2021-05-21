
namespace Time_Table_Management_System
{
    partial class manageLecturer
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
            this.m_lec_Level = new System.Windows.Forms.ComboBox();
            this.m_lec_Building = new System.Windows.Forms.ComboBox();
            this.locationTBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tLMDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tLMDataSet = new Time_Table_Management_System.TLMDataSet();
            this.m_lec_Center = new System.Windows.Forms.ComboBox();
            this.m_lec_dept = new System.Windows.Forms.ComboBox();
            this.m_lec_Faculty = new System.Windows.Forms.ComboBox();
            this.m_lec_Rank = new System.Windows.Forms.TextBox();
            this.m_lec_Id = new System.Windows.Forms.TextBox();
            this.m_lec_name = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.lecturerView = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.m_lec_Lid = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tLMDataSet1 = new Time_Table_Management_System.TLMDataSet1();
            this.tLMDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lectureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lectureTableAdapter = new Time_Table_Management_System.TLMDataSet1TableAdapters.lectureTableAdapter();
            this.locationTBTableAdapter = new Time_Table_Management_System.TLMDataSetTableAdapters.locationTBTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.locationTBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tLMDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tLMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerView)).BeginInit();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tLMDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tLMDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectureBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // m_lec_Level
            // 
            this.m_lec_Level.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_lec_Level.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lec_Level.FormattingEnabled = true;
            this.m_lec_Level.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.m_lec_Level.Location = new System.Drawing.Point(495, 115);
            this.m_lec_Level.Name = "m_lec_Level";
            this.m_lec_Level.Size = new System.Drawing.Size(158, 37);
            this.m_lec_Level.TabIndex = 76;
            // 
            // m_lec_Building
            // 
            this.m_lec_Building.DataSource = this.locationTBBindingSource;
            this.m_lec_Building.DisplayMember = "locationName";
            this.m_lec_Building.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_lec_Building.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lec_Building.FormattingEnabled = true;
            this.m_lec_Building.Location = new System.Drawing.Point(495, 60);
            this.m_lec_Building.Name = "m_lec_Building";
            this.m_lec_Building.Size = new System.Drawing.Size(158, 37);
            this.m_lec_Building.TabIndex = 75;
            this.m_lec_Building.ValueMember = "locationName";
            // 
            // locationTBBindingSource
            // 
            this.locationTBBindingSource.DataMember = "locationTB";
            this.locationTBBindingSource.DataSource = this.tLMDataSetBindingSource;
            // 
            // tLMDataSetBindingSource
            // 
            this.tLMDataSetBindingSource.DataSource = this.tLMDataSet;
            this.tLMDataSetBindingSource.Position = 0;
            // 
            // tLMDataSet
            // 
            this.tLMDataSet.DataSetName = "TLMDataSet";
            this.tLMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // m_lec_Center
            // 
            this.m_lec_Center.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_lec_Center.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lec_Center.FormattingEnabled = true;
            this.m_lec_Center.Items.AddRange(new object[] {
            "Malabe",
            "Matara",
            "Jaffna",
            "Kurunegala"});
            this.m_lec_Center.Location = new System.Drawing.Point(495, 3);
            this.m_lec_Center.Name = "m_lec_Center";
            this.m_lec_Center.Size = new System.Drawing.Size(158, 37);
            this.m_lec_Center.TabIndex = 74;
            // 
            // m_lec_dept
            // 
            this.m_lec_dept.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_lec_dept.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lec_dept.FormattingEnabled = true;
            this.m_lec_dept.Items.AddRange(new object[] {
            "IT",
            "SE",
            "IM",
            "ISE",
            "CS",
            "CSNE "});
            this.m_lec_dept.Location = new System.Drawing.Point(134, 180);
            this.m_lec_dept.Name = "m_lec_dept";
            this.m_lec_dept.Size = new System.Drawing.Size(191, 37);
            this.m_lec_dept.TabIndex = 73;
            // 
            // m_lec_Faculty
            // 
            this.m_lec_Faculty.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_lec_Faculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lec_Faculty.FormattingEnabled = true;
            this.m_lec_Faculty.Items.AddRange(new object[] {
            "Compuiting",
            "Engineering",
            "Business"});
            this.m_lec_Faculty.Location = new System.Drawing.Point(134, 115);
            this.m_lec_Faculty.Name = "m_lec_Faculty";
            this.m_lec_Faculty.Size = new System.Drawing.Size(191, 37);
            this.m_lec_Faculty.TabIndex = 72;
            // 
            // m_lec_Rank
            // 
            this.m_lec_Rank.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_lec_Rank.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lec_Rank.Location = new System.Drawing.Point(495, 180);
            this.m_lec_Rank.Name = "m_lec_Rank";
            this.m_lec_Rank.Size = new System.Drawing.Size(158, 34);
            this.m_lec_Rank.TabIndex = 71;
            // 
            // m_lec_Id
            // 
            this.m_lec_Id.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_lec_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lec_Id.Location = new System.Drawing.Point(134, 60);
            this.m_lec_Id.Name = "m_lec_Id";
            this.m_lec_Id.Size = new System.Drawing.Size(191, 34);
            this.m_lec_Id.TabIndex = 70;
            // 
            // m_lec_name
            // 
            this.m_lec_name.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_lec_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lec_name.Location = new System.Drawing.Point(134, 3);
            this.m_lec_name.Name = "m_lec_name";
            this.m_lec_name.Size = new System.Drawing.Size(191, 34);
            this.m_lec_name.TabIndex = 69;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label9.Location = new System.Drawing.Point(331, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 28);
            this.label9.TabIndex = 68;
            this.label9.Text = "Rank";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label8.Location = new System.Drawing.Point(331, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 28);
            this.label8.TabIndex = 67;
            this.label8.Text = "Level";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label7.Location = new System.Drawing.Point(331, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 28);
            this.label7.TabIndex = 66;
            this.label7.Text = "Building";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label6.Location = new System.Drawing.Point(331, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 28);
            this.label6.TabIndex = 65;
            this.label6.Text = "Center";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.Location = new System.Drawing.Point(3, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 28);
            this.label5.TabIndex = 64;
            this.label5.Text = "Department";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(3, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 28);
            this.label4.TabIndex = 63;
            this.label4.Text = "Faculty";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(3, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 28);
            this.label3.TabIndex = 62;
            this.label3.Text = "Employee ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 56);
            this.label2.TabIndex = 61;
            this.label2.Text = "Lecturer name";
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button3.BackColor = System.Drawing.Color.Cyan;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(784, 286);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(189, 47);
            this.button3.TabIndex = 59;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lecturerView
            // 
            this.lecturerView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lecturerView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lecturerView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lecturerView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lecturerView.Location = new System.Drawing.Point(12, 126);
            this.lecturerView.Name = "lecturerView";
            this.lecturerView.RowHeadersWidth = 51;
            this.lecturerView.RowTemplate.Height = 24;
            this.lecturerView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lecturerView.Size = new System.Drawing.Size(756, 243);
            this.lecturerView.TabIndex = 58;
            this.lecturerView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lecturerView_CellContentClick);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(145)))), ((int)(((byte)(231)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(784, 222);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(189, 47);
            this.button2.TabIndex = 57;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(186)))), ((int)(((byte)(247)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(784, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 47);
            this.button1.TabIndex = 56;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "MANAGE LECTURER";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(986, 107);
            this.panel4.TabIndex = 55;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(986, 49);
            this.panel1.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label10.Location = new System.Drawing.Point(659, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 28);
            this.label10.TabIndex = 78;
            this.label10.Text = "Lecturer ID";
            // 
            // m_lec_Lid
            // 
            this.m_lec_Lid.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_lec_Lid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lec_Lid.Location = new System.Drawing.Point(823, 3);
            this.m_lec_Lid.Name = "m_lec_Lid";
            this.m_lec_Lid.Size = new System.Drawing.Size(160, 34);
            this.m_lec_Lid.TabIndex = 77;
            this.m_lec_Lid.TextChanged += new System.EventHandler(this.m_lec_Lid_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.31776F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.01558F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.m_lec_Lid, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label10, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.m_lec_name, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.m_lec_Rank, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.m_lec_Level, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.m_lec_Id, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.m_lec_Building, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.m_lec_Center, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.m_lec_Faculty, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.m_lec_dept, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label9, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label8, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 413);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.89286F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.10714F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(986, 227);
            this.tableLayoutPanel1.TabIndex = 79;
            // 
            // tLMDataSet1
            // 
            this.tLMDataSet1.DataSetName = "TLMDataSet1";
            this.tLMDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tLMDataSet1BindingSource
            // 
            this.tLMDataSet1BindingSource.DataSource = this.tLMDataSet1;
            this.tLMDataSet1BindingSource.Position = 0;
            // 
            // lectureBindingSource
            // 
            this.lectureBindingSource.DataMember = "lecture";
            this.lectureBindingSource.DataSource = this.tLMDataSet1BindingSource;
            // 
            // lectureTableAdapter
            // 
            this.lectureTableAdapter.ClearBeforeFill = true;
            // 
            // locationTBTableAdapter
            // 
            this.locationTBTableAdapter.ClearBeforeFill = true;
            // 
            // manageLecturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 640);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lecturerView);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "manageLecturer";
            this.Text = "manageLecturer";
            this.Load += new System.EventHandler(this.manageLecturer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.locationTBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tLMDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tLMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerView)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tLMDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tLMDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectureBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox m_lec_Level;
        private System.Windows.Forms.ComboBox m_lec_Building;
        private System.Windows.Forms.ComboBox m_lec_Center;
        private System.Windows.Forms.ComboBox m_lec_dept;
        private System.Windows.Forms.ComboBox m_lec_Faculty;
        private System.Windows.Forms.TextBox m_lec_Rank;
        private System.Windows.Forms.TextBox m_lec_Id;
        private System.Windows.Forms.TextBox m_lec_name;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView lecturerView;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox m_lec_Lid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.BindingSource tLMDataSet1BindingSource;
        private TLMDataSet1 tLMDataSet1;
        private System.Windows.Forms.BindingSource lectureBindingSource;
        private TLMDataSet1TableAdapters.lectureTableAdapter lectureTableAdapter;
        private TLMDataSet tLMDataSet;
        private System.Windows.Forms.BindingSource tLMDataSetBindingSource;
        private System.Windows.Forms.BindingSource locationTBBindingSource;
        private TLMDataSetTableAdapters.locationTBTableAdapter locationTBTableAdapter;
    }
}