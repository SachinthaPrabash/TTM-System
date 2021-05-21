
namespace Time_Table_Management_System
{
    partial class Assign_rooms_for_Subject
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.enterSubject = new System.Windows.Forms.ComboBox();
            this.subjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tLMDataSet4 = new Time_Table_Management_System.TLMDataSet4();
            this.selectRoom = new System.Windows.Forms.ComboBox();
            this.roomTBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tLMDataSet7 = new Time_Table_Management_System.TLMDataSet7();
            this.subjectTableAdapter = new Time_Table_Management_System.TLMDataSet4TableAdapters.subjectTableAdapter();
            this.roomTBTableAdapter = new Time_Table_Management_System.TLMDataSet7TableAdapters.roomTBTableAdapter();
            this.roomForSubjectID = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.assignForSubjectRoom = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tLMDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomTBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tLMDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignForSubjectRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(31, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Assign a rooms for Subject";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(986, 45);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(986, 87);
            this.panel2.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.95011F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.04989F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.enterSubject, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.selectRoom, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(37, 232);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.86705F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.13295F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(461, 173);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.label3.Location = new System.Drawing.Point(3, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 41);
            this.label3.TabIndex = 3;
            this.label3.Text = "Select Room";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 41);
            this.label2.TabIndex = 2;
            this.label2.Text = "Subject";
            // 
            // enterSubject
            // 
            this.enterSubject.DataSource = this.subjectBindingSource;
            this.enterSubject.DisplayMember = "sub_name";
            this.enterSubject.FormattingEnabled = true;
            this.enterSubject.Location = new System.Drawing.Point(201, 3);
            this.enterSubject.Name = "enterSubject";
            this.enterSubject.Size = new System.Drawing.Size(257, 24);
            this.enterSubject.TabIndex = 43;
            this.enterSubject.ValueMember = "sub_name";
            this.enterSubject.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            // selectRoom
            // 
            this.selectRoom.DataSource = this.roomTBBindingSource;
            this.selectRoom.DisplayMember = "roomName";
            this.selectRoom.FormattingEnabled = true;
            this.selectRoom.Location = new System.Drawing.Point(201, 80);
            this.selectRoom.Name = "selectRoom";
            this.selectRoom.Size = new System.Drawing.Size(257, 24);
            this.selectRoom.TabIndex = 44;
            this.selectRoom.ValueMember = "roomName";
            // 
            // roomTBBindingSource
            // 
            this.roomTBBindingSource.DataMember = "roomTB";
            this.roomTBBindingSource.DataSource = this.tLMDataSet7;
            // 
            // tLMDataSet7
            // 
            this.tLMDataSet7.DataSetName = "TLMDataSet7";
            this.tLMDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // subjectTableAdapter
            // 
            this.subjectTableAdapter.ClearBeforeFill = true;
            // 
            // roomTBTableAdapter
            // 
            this.roomTBTableAdapter.ClearBeforeFill = true;
            // 
            // roomForSubjectID
            // 
            this.roomForSubjectID.Location = new System.Drawing.Point(235, 164);
            this.roomForSubjectID.Name = "roomForSubjectID";
            this.roomForSubjectID.Size = new System.Drawing.Size(260, 31);
            this.roomForSubjectID.TabIndex = 41;
            this.roomForSubjectID.Text = "";
            this.roomForSubjectID.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(85)))), ((int)(((byte)(145)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(74, 477);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 51);
            this.button1.TabIndex = 42;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(220)))), ((int)(((byte)(235)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(285, 477);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 51);
            this.button2.TabIndex = 43;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(186)))), ((int)(((byte)(247)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(74, 556);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 43);
            this.button3.TabIndex = 44;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(145)))), ((int)(((byte)(231)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(285, 556);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(144, 43);
            this.button4.TabIndex = 45;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // assignForSubjectRoom
            // 
            this.assignForSubjectRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.assignForSubjectRoom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.assignForSubjectRoom.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.assignForSubjectRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.assignForSubjectRoom.Location = new System.Drawing.Point(526, 186);
            this.assignForSubjectRoom.Name = "assignForSubjectRoom";
            this.assignForSubjectRoom.RowHeadersWidth = 51;
            this.assignForSubjectRoom.RowTemplate.Height = 24;
            this.assignForSubjectRoom.Size = new System.Drawing.Size(448, 432);
            this.assignForSubjectRoom.TabIndex = 46;
            this.assignForSubjectRoom.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Assign_rooms_for_Subject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 640);
            this.Controls.Add(this.assignForSubjectRoom);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.roomForSubjectID);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Assign_rooms_for_Subject";
            this.Text = "Assign_rooms_for_Subject";
            this.Load += new System.EventHandler(this.Assign_rooms_for_Subject_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tLMDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomTBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tLMDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignForSubjectRoom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private TLMDataSet4 tLMDataSet4;
        private System.Windows.Forms.BindingSource subjectBindingSource;
        private TLMDataSet4TableAdapters.subjectTableAdapter subjectTableAdapter;
        private TLMDataSet7 tLMDataSet7;
        private System.Windows.Forms.BindingSource roomTBBindingSource;
        private TLMDataSet7TableAdapters.roomTBTableAdapter roomTBTableAdapter;
        private System.Windows.Forms.ComboBox enterSubject;
        private System.Windows.Forms.RichTextBox roomForSubjectID;
        private System.Windows.Forms.ComboBox selectRoom;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView assignForSubjectRoom;
    }
}