
namespace Time_Table_Management_System
{
    partial class addSession
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.selected_lec = new System.Windows.Forms.TextBox();
            this.duration = new System.Windows.Forms.TextBox();
            this.lec1_tag = new System.Windows.Forms.ComboBox();
            this.tagTBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tLMDataSet3 = new Time_Table_Management_System.TLMDataSet3();
            this.lect_1 = new System.Windows.Forms.ComboBox();
            this.lectureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tLMDataSet1 = new Time_Table_Management_System.TLMDataSet1();
            this.subject = new System.Windows.Forms.ComboBox();
            this.subjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tLMDataSet4 = new Time_Table_Management_System.TLMDataSet4();
            this.lect_2 = new System.Windows.Forms.ComboBox();
            this.group = new System.Windows.Forms.ComboBox();
            this.studentGroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tLMDataSet2 = new Time_Table_Management_System.TLMDataSet2();
            this.button1 = new System.Windows.Forms.Button();
            this.no_of_student = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tLMDataSet = new Time_Table_Management_System.TLMDataSet();
            this.tLMDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lectureTableAdapter = new Time_Table_Management_System.TLMDataSet1TableAdapters.lectureTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.studentGroupTableAdapter = new Time_Table_Management_System.TLMDataSet2TableAdapters.StudentGroupTableAdapter();
            this.tagTBTableAdapter = new Time_Table_Management_System.TLMDataSet3TableAdapters.TagTBTableAdapter();
            this.subjectTableAdapter = new Time_Table_Management_System.TLMDataSet4TableAdapters.subjectTableAdapter();
            this.lectureBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tagTBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tLMDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectureBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tLMDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tLMDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentGroupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tLMDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tLMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tLMDataSetBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lectureBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(986, 49);
            this.panel1.TabIndex = 27;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 39);
            this.label1.TabIndex = 28;
            this.label1.Text = "ADD SESSION";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button3
            // 
            this.button3.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(220)))), ((int)(((byte)(235)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(580, 570);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(241, 58);
            this.button3.TabIndex = 64;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label9
            // 
            this.label9.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.label9.Location = new System.Drawing.Point(3, 287);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 58);
            this.label9.TabIndex = 63;
            this.label9.Text = "Selected Lecturers";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.label8.Location = new System.Drawing.Point(421, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 29);
            this.label8.TabIndex = 62;
            this.label8.Text = "Select Tag";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.label7.Location = new System.Drawing.Point(3, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 58);
            this.label7.TabIndex = 61;
            this.label7.Text = "Select Lecturer2";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.label6.Location = new System.Drawing.Point(421, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 29);
            this.label6.TabIndex = 60;
            this.label6.Text = "Duration";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.label5.Location = new System.Drawing.Point(421, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 29);
            this.label5.TabIndex = 59;
            this.label5.Text = "No. of  student";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 58);
            this.label2.TabIndex = 58;
            this.label2.Text = "Select Lecturer1";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // selected_lec
            // 
            this.selected_lec.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.selected_lec.Dock = System.Windows.Forms.DockStyle.Top;
            this.selected_lec.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selected_lec.Location = new System.Drawing.Point(183, 290);
            this.selected_lec.Name = "selected_lec";
            this.selected_lec.Size = new System.Drawing.Size(232, 38);
            this.selected_lec.TabIndex = 57;
            this.selected_lec.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // duration
            // 
            this.duration.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.duration.Dock = System.Windows.Forms.DockStyle.Top;
            this.duration.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duration.Location = new System.Drawing.Point(630, 146);
            this.duration.Name = "duration";
            this.duration.Size = new System.Drawing.Size(204, 38);
            this.duration.TabIndex = 56;
            this.duration.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lec1_tag
            // 
            this.lec1_tag.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lec1_tag.DataSource = this.tagTBBindingSource;
            this.lec1_tag.DisplayMember = "TagName";
            this.lec1_tag.Dock = System.Windows.Forms.DockStyle.Top;
            this.lec1_tag.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lec1_tag.FormattingEnabled = true;
            this.lec1_tag.Location = new System.Drawing.Point(630, 3);
            this.lec1_tag.Name = "lec1_tag";
            this.lec1_tag.Size = new System.Drawing.Size(204, 39);
            this.lec1_tag.TabIndex = 55;
            this.lec1_tag.ValueMember = "TagName";
            this.lec1_tag.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // tagTBBindingSource
            // 
            this.tagTBBindingSource.DataMember = "TagTB";
            this.tagTBBindingSource.DataSource = this.tLMDataSet3;
            // 
            // tLMDataSet3
            // 
            this.tLMDataSet3.DataSetName = "TLMDataSet3";
            this.tLMDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lect_1
            // 
            this.lect_1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lect_1.DataSource = this.lectureBindingSource;
            this.lect_1.DisplayMember = "lecturerName";
            this.lect_1.Dock = System.Windows.Forms.DockStyle.Top;
            this.lect_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lect_1.FormattingEnabled = true;
            this.lect_1.Location = new System.Drawing.Point(183, 3);
            this.lect_1.Name = "lect_1";
            this.lect_1.Size = new System.Drawing.Size(232, 39);
            this.lect_1.TabIndex = 54;
            this.lect_1.ValueMember = "lecturerName";
            this.lect_1.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // lectureBindingSource
            // 
            this.lectureBindingSource.DataMember = "lecture";
            this.lectureBindingSource.DataSource = this.tLMDataSet1;
            // 
            // tLMDataSet1
            // 
            this.tLMDataSet1.DataSetName = "TLMDataSet1";
            this.tLMDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // subject
            // 
            this.subject.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.subject.DataSource = this.subjectBindingSource;
            this.subject.DisplayMember = "sub_name";
            this.subject.Dock = System.Windows.Forms.DockStyle.Top;
            this.subject.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subject.FormattingEnabled = true;
            this.subject.Location = new System.Drawing.Point(183, 218);
            this.subject.Name = "subject";
            this.subject.Size = new System.Drawing.Size(232, 39);
            this.subject.TabIndex = 53;
            this.subject.ValueMember = "sub_name";
            this.subject.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // subjectBindingSource
            // 
            this.subjectBindingSource.DataMember = "subject";
            this.subjectBindingSource.DataSource = this.tLMDataSet4;
            // 
            // tLMDataSet4
            // 
            this.tLMDataSet4.DataSetName = "TLMDataSet4";
            this.tLMDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lect_2
            // 
            this.lect_2.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lect_2.DataSource = this.lectureBindingSource1;
            this.lect_2.DisplayMember = "lecturerName";
            this.lect_2.Dock = System.Windows.Forms.DockStyle.Top;
            this.lect_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lect_2.FormattingEnabled = true;
            this.lect_2.Location = new System.Drawing.Point(183, 77);
            this.lect_2.Name = "lect_2";
            this.lect_2.Size = new System.Drawing.Size(232, 39);
            this.lect_2.TabIndex = 52;
            this.lect_2.ValueMember = "lecturerName";
            this.lect_2.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // group
            // 
            this.group.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.group.DataSource = this.studentGroupBindingSource;
            this.group.DisplayMember = "SubGroupID";
            this.group.Dock = System.Windows.Forms.DockStyle.Top;
            this.group.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group.FormattingEnabled = true;
            this.group.Location = new System.Drawing.Point(183, 146);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(232, 39);
            this.group.TabIndex = 51;
            this.group.ValueMember = "SubGroupID";
            this.group.SelectedIndexChanged += new System.EventHandler(this.lec_Faculty_SelectedIndexChanged);
            // 
            // studentGroupBindingSource
            // 
            this.studentGroupBindingSource.DataMember = "StudentGroup";
            this.studentGroupBindingSource.DataSource = this.tLMDataSet2;
            // 
            // tLMDataSet2
            // 
            this.tLMDataSet2.DataSetName = "TLMDataSet2";
            this.tLMDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(85)))), ((int)(((byte)(145)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(278, 570);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(241, 58);
            this.button1.TabIndex = 50;
            this.button1.Text = "SUBMIT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // no_of_student
            // 
            this.no_of_student.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.no_of_student.Dock = System.Windows.Forms.DockStyle.Top;
            this.no_of_student.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no_of_student.Location = new System.Drawing.Point(630, 77);
            this.no_of_student.Name = "no_of_student";
            this.no_of_student.Size = new System.Drawing.Size(204, 38);
            this.no_of_student.TabIndex = 49;
            this.no_of_student.TextChanged += new System.EventHandler(this.lec_Id_TextChanged);
            // 
            // label4
            // 
            this.label4.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.label4.Location = new System.Drawing.Point(3, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 29);
            this.label4.TabIndex = 48;
            this.label4.Text = "Select Subject";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.label3.Location = new System.Drawing.Point(3, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 29);
            this.label3.TabIndex = 47;
            this.label3.Text = "Select Group";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tLMDataSet
            // 
            this.tLMDataSet.DataSetName = "TLMDataSet";
            this.tLMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tLMDataSetBindingSource
            // 
            this.tLMDataSetBindingSource.DataSource = this.tLMDataSet;
            this.tLMDataSetBindingSource.Position = 0;
            // 
            // lectureTableAdapter
            // 
            this.lectureTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(986, 65);
            this.panel2.TabIndex = 65;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 114);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(79, 526);
            this.flowLayoutPanel1.TabIndex = 66;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(79, 114);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(907, 46);
            this.panel3.TabIndex = 67;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(916, 160);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(70, 480);
            this.panel4.TabIndex = 68;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.56398F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.43602F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lect_1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label8, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lec1_tag, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lect_2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.selected_lec, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.subject, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.duration, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.no_of_student, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.group, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(79, 160);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.67114F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.32886F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(837, 362);
            this.tableLayoutPanel1.TabIndex = 69;
            // 
            // studentGroupTableAdapter
            // 
            this.studentGroupTableAdapter.ClearBeforeFill = true;
            // 
            // tagTBTableAdapter
            // 
            this.tagTBTableAdapter.ClearBeforeFill = true;
            // 
            // subjectTableAdapter
            // 
            this.subjectTableAdapter.ClearBeforeFill = true;
            // 
            // lectureBindingSource1
            // 
            this.lectureBindingSource1.DataMember = "lecture";
            this.lectureBindingSource1.DataSource = this.tLMDataSet1;
            // 
            // addSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 640);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "addSession";
            this.Text = "addSession";
            this.Load += new System.EventHandler(this.addSession_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tagTBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tLMDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectureBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tLMDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tLMDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentGroupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tLMDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tLMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tLMDataSetBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lectureBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox selected_lec;
        private System.Windows.Forms.TextBox duration;
        private System.Windows.Forms.ComboBox lec1_tag;
        private System.Windows.Forms.ComboBox lect_1;
        private System.Windows.Forms.ComboBox subject;
        private System.Windows.Forms.ComboBox lect_2;
        private System.Windows.Forms.ComboBox group;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox no_of_student;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private TLMDataSet tLMDataSet;
        private System.Windows.Forms.BindingSource tLMDataSetBindingSource;
        private TLMDataSet1 tLMDataSet1;
        private System.Windows.Forms.BindingSource lectureBindingSource;
        private TLMDataSet1TableAdapters.lectureTableAdapter lectureTableAdapter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private TLMDataSet2 tLMDataSet2;
        private System.Windows.Forms.BindingSource studentGroupBindingSource;
        private TLMDataSet2TableAdapters.StudentGroupTableAdapter studentGroupTableAdapter;
        private TLMDataSet3 tLMDataSet3;
        private System.Windows.Forms.BindingSource tagTBBindingSource;
        private TLMDataSet3TableAdapters.TagTBTableAdapter tagTBTableAdapter;
        private TLMDataSet4 tLMDataSet4;
        private System.Windows.Forms.BindingSource subjectBindingSource;
        private TLMDataSet4TableAdapters.subjectTableAdapter subjectTableAdapter;
        private System.Windows.Forms.BindingSource lectureBindingSource1;
    }
}