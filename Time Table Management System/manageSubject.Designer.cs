
namespace Time_Table_Management_System
{
    partial class manageSubject
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
            this.button3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.subject_id = new System.Windows.Forms.TextBox();
            this.subjectView = new System.Windows.Forms.DataGridView();
            this.offered_year = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.no_of_evalu = new System.Windows.Forms.ComboBox();
            this.subject_code = new System.Windows.Forms.TextBox();
            this.subject_name = new System.Windows.Forms.TextBox();
            this.no_of_lab = new System.Windows.Forms.ComboBox();
            this.no_of_tute = new System.Windows.Forms.ComboBox();
            this.no_of_lec = new System.Windows.Forms.ComboBox();
            this.offered_sem = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjectView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button3.BackColor = System.Drawing.Color.Cyan;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(771, 301);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(202, 47);
            this.button3.TabIndex = 27;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.subjectView);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(986, 640);
            this.panel2.TabIndex = 14;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(26, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(345, 39);
            this.label10.TabIndex = 76;
            this.label10.Text = "MANAGE SUBJECT";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(986, 49);
            this.panel1.TabIndex = 74;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 28);
            this.label1.TabIndex = 73;
            this.label1.Text = "Subject ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // subject_id
            // 
            this.subject_id.Dock = System.Windows.Forms.DockStyle.Top;
            this.subject_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subject_id.Location = new System.Drawing.Point(193, 3);
            this.subject_id.Name = "subject_id";
            this.subject_id.Size = new System.Drawing.Size(295, 34);
            this.subject_id.TabIndex = 72;
            // 
            // subjectView
            // 
            this.subjectView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.subjectView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subjectView.Location = new System.Drawing.Point(24, 120);
            this.subjectView.Name = "subjectView";
            this.subjectView.RowHeadersWidth = 51;
            this.subjectView.RowTemplate.Height = 24;
            this.subjectView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.subjectView.Size = new System.Drawing.Size(706, 245);
            this.subjectView.TabIndex = 71;
            this.subjectView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.subjectView_CellContentClick_1);
            // 
            // offered_year
            // 
            this.offered_year.Dock = System.Windows.Forms.DockStyle.Top;
            this.offered_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.offered_year.Location = new System.Drawing.Point(193, 52);
            this.offered_year.Name = "offered_year";
            this.offered_year.Size = new System.Drawing.Size(295, 34);
            this.offered_year.TabIndex = 70;
            this.offered_year.TextChanged += new System.EventHandler(this.offered_year_TextChanged);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(145)))), ((int)(((byte)(231)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(771, 216);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(202, 47);
            this.button2.TabIndex = 25;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // no_of_evalu
            // 
            this.no_of_evalu.Dock = System.Windows.Forms.DockStyle.Top;
            this.no_of_evalu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no_of_evalu.FormattingEnabled = true;
            this.no_of_evalu.Items.AddRange(new object[] {
            "1.00",
            "2.00",
            "3.00"});
            this.no_of_evalu.Location = new System.Drawing.Point(736, 199);
            this.no_of_evalu.Name = "no_of_evalu";
            this.no_of_evalu.Size = new System.Drawing.Size(247, 37);
            this.no_of_evalu.TabIndex = 24;
            // 
            // subject_code
            // 
            this.subject_code.Dock = System.Windows.Forms.DockStyle.Top;
            this.subject_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subject_code.Location = new System.Drawing.Point(193, 199);
            this.subject_code.Name = "subject_code";
            this.subject_code.Size = new System.Drawing.Size(295, 34);
            this.subject_code.TabIndex = 23;
            // 
            // subject_name
            // 
            this.subject_name.Dock = System.Windows.Forms.DockStyle.Top;
            this.subject_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subject_name.Location = new System.Drawing.Point(193, 149);
            this.subject_name.Name = "subject_name";
            this.subject_name.Size = new System.Drawing.Size(295, 34);
            this.subject_name.TabIndex = 22;
            // 
            // no_of_lab
            // 
            this.no_of_lab.Dock = System.Windows.Forms.DockStyle.Top;
            this.no_of_lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no_of_lab.FormattingEnabled = true;
            this.no_of_lab.Items.AddRange(new object[] {
            "2.00",
            "3.00"});
            this.no_of_lab.Location = new System.Drawing.Point(736, 149);
            this.no_of_lab.Name = "no_of_lab";
            this.no_of_lab.Size = new System.Drawing.Size(247, 37);
            this.no_of_lab.TabIndex = 21;
            // 
            // no_of_tute
            // 
            this.no_of_tute.Dock = System.Windows.Forms.DockStyle.Top;
            this.no_of_tute.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no_of_tute.FormattingEnabled = true;
            this.no_of_tute.Items.AddRange(new object[] {
            "1.00",
            "2.00"});
            this.no_of_tute.Location = new System.Drawing.Point(736, 100);
            this.no_of_tute.Name = "no_of_tute";
            this.no_of_tute.Size = new System.Drawing.Size(247, 37);
            this.no_of_tute.TabIndex = 20;
            // 
            // no_of_lec
            // 
            this.no_of_lec.Dock = System.Windows.Forms.DockStyle.Top;
            this.no_of_lec.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no_of_lec.FormattingEnabled = true;
            this.no_of_lec.Items.AddRange(new object[] {
            "1.00",
            "2.00",
            "3.00",
            "4.00"});
            this.no_of_lec.Location = new System.Drawing.Point(736, 52);
            this.no_of_lec.Name = "no_of_lec";
            this.no_of_lec.Size = new System.Drawing.Size(247, 37);
            this.no_of_lec.TabIndex = 19;
            // 
            // offered_sem
            // 
            this.offered_sem.Dock = System.Windows.Forms.DockStyle.Top;
            this.offered_sem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.offered_sem.FormattingEnabled = true;
            this.offered_sem.Items.AddRange(new object[] {
            "1 st semester",
            "2 nd semester"});
            this.offered_sem.Location = new System.Drawing.Point(193, 100);
            this.offered_sem.Name = "offered_sem";
            this.offered_sem.Size = new System.Drawing.Size(295, 37);
            this.offered_sem.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(186)))), ((int)(((byte)(247)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(771, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 47);
            this.button1.TabIndex = 16;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label9.Location = new System.Drawing.Point(494, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(216, 28);
            this.label9.TabIndex = 7;
            this.label9.Text = "No. of evaluation hours";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label8.Location = new System.Drawing.Point(494, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 28);
            this.label8.TabIndex = 6;
            this.label8.Text = "No. of lab hours";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label7.Location = new System.Drawing.Point(494, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 28);
            this.label7.TabIndex = 5;
            this.label7.Text = "No. of tut. hours";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label6.Location = new System.Drawing.Point(494, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 28);
            this.label6.TabIndex = 4;
            this.label6.Text = "No. of lect. hours";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.Location = new System.Drawing.Point(3, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 28);
            this.label5.TabIndex = 3;
            this.label5.Text = "Subject code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(3, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 28);
            this.label4.TabIndex = 2;
            this.label4.Text = "Subject name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(3, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Offered semester";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(3, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Offered year";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.26978F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.52738F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.54361F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.55781F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.subject_id, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.offered_year, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.offered_sem, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.no_of_evalu, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.no_of_lab, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.subject_code, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.no_of_tute, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.subject_name, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.no_of_lec, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label9, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label7, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label8, 2, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 395);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.54945F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.45055F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(986, 245);
            this.tableLayoutPanel1.TabIndex = 77;
            // 
            // manageSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 640);
            this.Controls.Add(this.panel2);
            this.Name = "manageSubject";
            this.Text = "manageSubject";
            this.Load += new System.EventHandler(this.manageSubject_Load_1);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjectView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox no_of_evalu;
        private System.Windows.Forms.TextBox subject_code;
        private System.Windows.Forms.TextBox subject_name;
        private System.Windows.Forms.ComboBox no_of_lab;
        private System.Windows.Forms.ComboBox no_of_tute;
        private System.Windows.Forms.ComboBox no_of_lec;
        private System.Windows.Forms.ComboBox offered_sem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox offered_year;
        private System.Windows.Forms.DataGridView subjectView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox subject_id;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}