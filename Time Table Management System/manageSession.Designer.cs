
namespace Time_Table_Management_System
{
    partial class manageSession
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
            this.label10 = new System.Windows.Forms.Label();
            this.subjectView = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.duration = new System.Windows.Forms.TextBox();
            this.lec1_tag = new System.Windows.Forms.ComboBox();
            this.lec_1 = new System.Windows.Forms.ComboBox();
            this.subject = new System.Windows.Forms.ComboBox();
            this.lec_2 = new System.Windows.Forms.ComboBox();
            this.group = new System.Windows.Forms.ComboBox();
            this.no_of_student = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.sessionId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.session_search = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tLMDataSet1 = new Time_Table_Management_System.TLMDataSet1();
            this.lectureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lectureTableAdapter = new Time_Table_Management_System.TLMDataSet1TableAdapters.lectureTableAdapter();
            this.tLMDataSet2 = new Time_Table_Management_System.TLMDataSet2();
            this.studentGroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentGroupTableAdapter = new Time_Table_Management_System.TLMDataSet2TableAdapters.StudentGroupTableAdapter();
            this.tLMDataSet3 = new Time_Table_Management_System.TLMDataSet3();
            this.tagTBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tagTBTableAdapter = new Time_Table_Management_System.TLMDataSet3TableAdapters.TagTBTableAdapter();
            this.tLMDataSet4 = new Time_Table_Management_System.TLMDataSet4();
            this.subjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subjectTableAdapter = new Time_Table_Management_System.TLMDataSet4TableAdapters.subjectTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.subjectView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tLMDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectureBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tLMDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentGroupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tLMDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagTBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tLMDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(986, 49);
            this.panel1.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(63, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(341, 39);
            this.label10.TabIndex = 47;
            this.label10.Text = "MANAGE SESSION";
            // 
            // subjectView
            // 
            this.subjectView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.subjectView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subjectView.Location = new System.Drawing.Point(12, 147);
            this.subjectView.Name = "subjectView";
            this.subjectView.RowHeadersWidth = 51;
            this.subjectView.RowTemplate.Height = 24;
            this.subjectView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.subjectView.Size = new System.Drawing.Size(732, 269);
            this.subjectView.TabIndex = 72;
            this.subjectView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.subjectView_CellContentClick);
            // 
            // label8
            // 
            this.label8.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label8.Location = new System.Drawing.Point(495, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 28);
            this.label8.TabIndex = 87;
            this.label8.Text = "Select Tag";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label7.Location = new System.Drawing.Point(3, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 28);
            this.label7.TabIndex = 86;
            this.label7.Text = "Select Lecturer2";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label6.Location = new System.Drawing.Point(495, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 28);
            this.label6.TabIndex = 85;
            this.label6.Text = "Duration";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.Location = new System.Drawing.Point(495, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 28);
            this.label5.TabIndex = 84;
            this.label5.Text = "No. of  student";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 28);
            this.label2.TabIndex = 83;
            this.label2.Text = "Select Lecturer1";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // duration
            // 
            this.duration.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.duration.Dock = System.Windows.Forms.DockStyle.Top;
            this.duration.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duration.Location = new System.Drawing.Point(741, 111);
            this.duration.Name = "duration";
            this.duration.Size = new System.Drawing.Size(242, 38);
            this.duration.TabIndex = 81;
            this.duration.TextChanged += new System.EventHandler(this.duration_TextChanged);
            // 
            // lec1_tag
            // 
            this.lec1_tag.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lec1_tag.DataSource = this.tagTBBindingSource;
            this.lec1_tag.DisplayMember = "TagName";
            this.lec1_tag.Dock = System.Windows.Forms.DockStyle.Top;
            this.lec1_tag.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lec1_tag.FormattingEnabled = true;
            this.lec1_tag.Location = new System.Drawing.Point(741, 3);
            this.lec1_tag.Name = "lec1_tag";
            this.lec1_tag.Size = new System.Drawing.Size(242, 39);
            this.lec1_tag.TabIndex = 80;
            this.lec1_tag.ValueMember = "TagName";
            this.lec1_tag.SelectedIndexChanged += new System.EventHandler(this.lec1_tag_SelectedIndexChanged);
            // 
            // lec_1
            // 
            this.lec_1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lec_1.DataSource = this.lectureBindingSource;
            this.lec_1.DisplayMember = "lecturerName";
            this.lec_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lec_1.FormattingEnabled = true;
            this.lec_1.Location = new System.Drawing.Point(212, 3);
            this.lec_1.Name = "lec_1";
            this.lec_1.Size = new System.Drawing.Size(277, 39);
            this.lec_1.TabIndex = 79;
            this.lec_1.ValueMember = "lecturerName";
            this.lec_1.SelectedIndexChanged += new System.EventHandler(this.lec_1_SelectedIndexChanged);
            // 
            // subject
            // 
            this.subject.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.subject.DataSource = this.subjectBindingSource;
            this.subject.DisplayMember = "sub_name";
            this.subject.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subject.FormattingEnabled = true;
            this.subject.Location = new System.Drawing.Point(212, 160);
            this.subject.Name = "subject";
            this.subject.Size = new System.Drawing.Size(277, 39);
            this.subject.TabIndex = 78;
            this.subject.ValueMember = "sub_name";
            this.subject.SelectedIndexChanged += new System.EventHandler(this.subject_SelectedIndexChanged);
            // 
            // lec_2
            // 
            this.lec_2.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lec_2.DataSource = this.lectureBindingSource;
            this.lec_2.DisplayMember = "lecturerName";
            this.lec_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lec_2.FormattingEnabled = true;
            this.lec_2.Location = new System.Drawing.Point(212, 59);
            this.lec_2.Name = "lec_2";
            this.lec_2.Size = new System.Drawing.Size(277, 39);
            this.lec_2.TabIndex = 77;
            this.lec_2.ValueMember = "lecturerName";
            this.lec_2.SelectedIndexChanged += new System.EventHandler(this.lec_2_SelectedIndexChanged);
            // 
            // group
            // 
            this.group.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.group.DataSource = this.studentGroupBindingSource;
            this.group.DisplayMember = "SubGroupID";
            this.group.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group.FormattingEnabled = true;
            this.group.Location = new System.Drawing.Point(212, 111);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(277, 39);
            this.group.TabIndex = 76;
            this.group.ValueMember = "SubGroupID";
            this.group.SelectedIndexChanged += new System.EventHandler(this.group_SelectedIndexChanged);
            // 
            // no_of_student
            // 
            this.no_of_student.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.no_of_student.Dock = System.Windows.Forms.DockStyle.Top;
            this.no_of_student.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no_of_student.Location = new System.Drawing.Point(741, 59);
            this.no_of_student.Name = "no_of_student";
            this.no_of_student.Size = new System.Drawing.Size(242, 38);
            this.no_of_student.TabIndex = 75;
            this.no_of_student.TextChanged += new System.EventHandler(this.no_of_student_TextChanged);
            // 
            // label4
            // 
            this.label4.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(3, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 28);
            this.label4.TabIndex = 74;
            this.label4.Text = "Select Subject";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(3, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 28);
            this.label3.TabIndex = 73;
            this.label3.Text = "Select Group";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button3.BackColor = System.Drawing.Color.Cyan;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(766, 253);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(192, 47);
            this.button3.TabIndex = 93;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(145)))), ((int)(((byte)(231)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(766, 200);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 47);
            this.button2.TabIndex = 92;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(186)))), ((int)(((byte)(247)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(766, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 47);
            this.button1.TabIndex = 91;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(766, 316);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(192, 47);
            this.button4.TabIndex = 94;
            this.button4.Text = "ADD SEESION";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // sessionId
            // 
            this.sessionId.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.sessionId.Dock = System.Windows.Forms.DockStyle.Top;
            this.sessionId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sessionId.Location = new System.Drawing.Point(741, 160);
            this.sessionId.Name = "sessionId";
            this.sessionId.Size = new System.Drawing.Size(242, 38);
            this.sessionId.TabIndex = 95;
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(495, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 28);
            this.label1.TabIndex = 96;
            this.label1.Text = "Session";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // session_search
            // 
            this.session_search.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.session_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.session_search.Location = new System.Drawing.Point(463, 70);
            this.session_search.Name = "session_search";
            this.session_search.Size = new System.Drawing.Size(255, 38);
            this.session_search.TabIndex = 97;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(213)))), ((int)(((byte)(69)))));
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(766, 67);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(170, 41);
            this.button5.TabIndex = 98;
            this.button5.Text = "Search";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.26949F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.73051F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.sessionId, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lec_1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lec_2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.group, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.subject, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label8, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.duration, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lec1_tag, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.no_of_student, 3, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 443);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.21239F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.78761F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(986, 197);
            this.tableLayoutPanel1.TabIndex = 99;
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
            // tLMDataSet3
            // 
            this.tLMDataSet3.DataSetName = "TLMDataSet3";
            this.tLMDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tagTBBindingSource
            // 
            this.tagTBBindingSource.DataMember = "TagTB";
            this.tagTBBindingSource.DataSource = this.tLMDataSet3;
            // 
            // tagTBTableAdapter
            // 
            this.tagTBTableAdapter.ClearBeforeFill = true;
            // 
            // tLMDataSet4
            // 
            this.tLMDataSet4.DataSetName = "TLMDataSet4";
            this.tLMDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // subjectBindingSource
            // 
            this.subjectBindingSource.DataMember = "subject";
            this.subjectBindingSource.DataSource = this.tLMDataSet4;
            // 
            // subjectTableAdapter
            // 
            this.subjectTableAdapter.ClearBeforeFill = true;
            // 
            // manageSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 640);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.session_search);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.subjectView);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel1);
            this.Name = "manageSession";
            this.Text = "manageSession";
            this.Load += new System.EventHandler(this.manageSession_Load);
            ((System.ComponentModel.ISupportInitialize)(this.subjectView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tLMDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectureBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tLMDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentGroupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tLMDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagTBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tLMDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView subjectView;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox duration;
        private System.Windows.Forms.ComboBox lec1_tag;
        private System.Windows.Forms.ComboBox lec_1;
        private System.Windows.Forms.ComboBox subject;
        private System.Windows.Forms.ComboBox lec_2;
        private System.Windows.Forms.ComboBox group;
        private System.Windows.Forms.TextBox no_of_student;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox sessionId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox session_search;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private TLMDataSet1 tLMDataSet1;
        private System.Windows.Forms.BindingSource lectureBindingSource;
        private TLMDataSet1TableAdapters.lectureTableAdapter lectureTableAdapter;
        private TLMDataSet2 tLMDataSet2;
        private System.Windows.Forms.BindingSource studentGroupBindingSource;
        private TLMDataSet2TableAdapters.StudentGroupTableAdapter studentGroupTableAdapter;
        private TLMDataSet3 tLMDataSet3;
        private System.Windows.Forms.BindingSource tagTBBindingSource;
        private TLMDataSet3TableAdapters.TagTBTableAdapter tagTBTableAdapter;
        private TLMDataSet4 tLMDataSet4;
        private System.Windows.Forms.BindingSource subjectBindingSource;
        private TLMDataSet4TableAdapters.subjectTableAdapter subjectTableAdapter;
    }
}