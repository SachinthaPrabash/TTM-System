
namespace Time_Table_Management_System
{
    partial class addSubject
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
            this.subjectClear_btn = new System.Windows.Forms.Button();
            this.evaluation_hours = new System.Windows.Forms.ComboBox();
            this.subject_code = new System.Windows.Forms.TextBox();
            this.Subject_name = new System.Windows.Forms.TextBox();
            this.lab_hours = new System.Windows.Forms.ComboBox();
            this.tute_hours = new System.Windows.Forms.ComboBox();
            this.lec_hours = new System.Windows.Forms.ComboBox();
            this.Offered_sem = new System.Windows.Forms.ComboBox();
            this.subjectSave_btn = new System.Windows.Forms.Button();
            this.offered_year = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // subjectClear_btn
            // 
            this.subjectClear_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.subjectClear_btn.BackColor = System.Drawing.Color.Cyan;
            this.subjectClear_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectClear_btn.Location = new System.Drawing.Point(738, 366);
            this.subjectClear_btn.Name = "subjectClear_btn";
            this.subjectClear_btn.Size = new System.Drawing.Size(197, 58);
            this.subjectClear_btn.TabIndex = 43;
            this.subjectClear_btn.Text = "Clear";
            this.subjectClear_btn.UseVisualStyleBackColor = false;
            this.subjectClear_btn.Click += new System.EventHandler(this.subjectClear_btn_Click);
            // 
            // evaluation_hours
            // 
            this.evaluation_hours.Dock = System.Windows.Forms.DockStyle.Top;
            this.evaluation_hours.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evaluation_hours.FormattingEnabled = true;
            this.evaluation_hours.Items.AddRange(new object[] {
            "1.00",
            "2.00",
            "3.00"});
            this.evaluation_hours.Location = new System.Drawing.Point(330, 409);
            this.evaluation_hours.Name = "evaluation_hours";
            this.evaluation_hours.Size = new System.Drawing.Size(318, 39);
            this.evaluation_hours.TabIndex = 42;
            // 
            // subject_code
            // 
            this.subject_code.Dock = System.Windows.Forms.DockStyle.Top;
            this.subject_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subject_code.Location = new System.Drawing.Point(330, 177);
            this.subject_code.Name = "subject_code";
            this.subject_code.Size = new System.Drawing.Size(318, 38);
            this.subject_code.TabIndex = 41;
            // 
            // Subject_name
            // 
            this.Subject_name.Dock = System.Windows.Forms.DockStyle.Top;
            this.Subject_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subject_name.Location = new System.Drawing.Point(330, 119);
            this.Subject_name.Name = "Subject_name";
            this.Subject_name.Size = new System.Drawing.Size(318, 38);
            this.Subject_name.TabIndex = 40;
            // 
            // lab_hours
            // 
            this.lab_hours.Dock = System.Windows.Forms.DockStyle.Top;
            this.lab_hours.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_hours.FormattingEnabled = true;
            this.lab_hours.Items.AddRange(new object[] {
            "2.00",
            "3.00"});
            this.lab_hours.Location = new System.Drawing.Point(330, 351);
            this.lab_hours.Name = "lab_hours";
            this.lab_hours.Size = new System.Drawing.Size(318, 39);
            this.lab_hours.TabIndex = 39;
            // 
            // tute_hours
            // 
            this.tute_hours.Dock = System.Windows.Forms.DockStyle.Top;
            this.tute_hours.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tute_hours.FormattingEnabled = true;
            this.tute_hours.Items.AddRange(new object[] {
            "1.00",
            "2.00"});
            this.tute_hours.Location = new System.Drawing.Point(330, 293);
            this.tute_hours.Name = "tute_hours";
            this.tute_hours.Size = new System.Drawing.Size(318, 39);
            this.tute_hours.TabIndex = 38;
            // 
            // lec_hours
            // 
            this.lec_hours.Dock = System.Windows.Forms.DockStyle.Top;
            this.lec_hours.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lec_hours.FormattingEnabled = true;
            this.lec_hours.Items.AddRange(new object[] {
            "1.00",
            "2.00",
            "3.00",
            "4.00"});
            this.lec_hours.Location = new System.Drawing.Point(330, 235);
            this.lec_hours.Name = "lec_hours";
            this.lec_hours.Size = new System.Drawing.Size(318, 39);
            this.lec_hours.TabIndex = 37;
            // 
            // Offered_sem
            // 
            this.Offered_sem.Dock = System.Windows.Forms.DockStyle.Top;
            this.Offered_sem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Offered_sem.FormattingEnabled = true;
            this.Offered_sem.Items.AddRange(new object[] {
            "1 st semester",
            "2 nd semester"});
            this.Offered_sem.Location = new System.Drawing.Point(330, 61);
            this.Offered_sem.Name = "Offered_sem";
            this.Offered_sem.Size = new System.Drawing.Size(318, 39);
            this.Offered_sem.TabIndex = 36;
            this.Offered_sem.Validating += new System.ComponentModel.CancelEventHandler(this.Offered_sem_Validating);
            // 
            // subjectSave_btn
            // 
            this.subjectSave_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.subjectSave_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(197)))), ((int)(((byte)(32)))));
            this.subjectSave_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectSave_btn.Location = new System.Drawing.Point(738, 267);
            this.subjectSave_btn.Name = "subjectSave_btn";
            this.subjectSave_btn.Size = new System.Drawing.Size(197, 58);
            this.subjectSave_btn.TabIndex = 35;
            this.subjectSave_btn.Text = "ADD";
            this.subjectSave_btn.UseVisualStyleBackColor = false;
            this.subjectSave_btn.Click += new System.EventHandler(this.subjectSave_btn_Click);
            // 
            // offered_year
            // 
            this.offered_year.Dock = System.Windows.Forms.DockStyle.Top;
            this.offered_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.offered_year.Location = new System.Drawing.Point(330, 3);
            this.offered_year.Name = "offered_year";
            this.offered_year.Size = new System.Drawing.Size(318, 38);
            this.offered_year.TabIndex = 34;
            this.offered_year.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.offered_year.Validating += new System.ComponentModel.CancelEventHandler(this.offered_year_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 406);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(307, 32);
            this.label9.TabIndex = 33;
            this.label9.Text = "No. of evaluation hours";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 348);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(214, 32);
            this.label8.TabIndex = 32;
            this.label8.Text = "No. of lab hours";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(215, 32);
            this.label7.TabIndex = 31;
            this.label7.Text = "No. of tut. hours";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(228, 32);
            this.label6.TabIndex = 30;
            this.label6.Text = "No. of lect. hours";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 32);
            this.label5.TabIndex = 29;
            this.label5.Text = "Subject code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 32);
            this.label4.TabIndex = 28;
            this.label4.Text = "Subject name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 32);
            this.label3.TabIndex = 27;
            this.label3.Text = "Offered semester";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 32);
            this.label2.TabIndex = 26;
            this.label2.Text = "Offered year";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(968, 49);
            this.panel1.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 39);
            this.label1.TabIndex = 45;
            this.label1.Text = "ADD SUBJECT";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(968, 61);
            this.panel2.TabIndex = 46;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 110);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(47, 483);
            this.panel3.TabIndex = 47;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(47, 110);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(921, 18);
            this.panel4.TabIndex = 48;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.23474F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.76526F));
            this.tableLayoutPanel1.Controls.Add(this.offered_year, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Offered_sem, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Subject_name, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.evaluation_hours, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lab_hours, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.subject_code, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tute_hours, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.lec_hours, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(47, 128);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(651, 465);
            this.tableLayoutPanel1.TabIndex = 49;
            // 
            // addSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 593);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.subjectClear_btn);
            this.Controls.Add(this.subjectSave_btn);
            this.Name = "addSubject";
            this.Text = "addSubject";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button subjectClear_btn;
        private System.Windows.Forms.ComboBox evaluation_hours;
        private System.Windows.Forms.TextBox subject_code;
        private System.Windows.Forms.TextBox Subject_name;
        private System.Windows.Forms.ComboBox lab_hours;
        private System.Windows.Forms.ComboBox tute_hours;
        private System.Windows.Forms.ComboBox lec_hours;
        private System.Windows.Forms.ComboBox Offered_sem;
        private System.Windows.Forms.Button subjectSave_btn;
        private System.Windows.Forms.TextBox offered_year;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
    }
}