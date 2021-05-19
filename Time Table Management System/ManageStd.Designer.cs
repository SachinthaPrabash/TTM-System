
namespace Time_Table_Management_System
{
    partial class ManageStd
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
            this.program = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.subId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpId = new System.Windows.Forms.TextBox();
            this.academicYS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.stdTB = new System.Windows.Forms.DataGridView();
            this.StdID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.grpNum = new System.Windows.Forms.ComboBox();
            this.subGrpNum = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.stdTB)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // program
            // 
            this.program.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.program.Dock = System.Windows.Forms.DockStyle.Top;
            this.program.FormattingEnabled = true;
            this.program.Items.AddRange(new object[] {
            "",
            "IT",
            "IM",
            "CSSE",
            "CSE"});
            this.program.Location = new System.Drawing.Point(213, 69);
            this.program.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.program.Name = "program";
            this.program.Size = new System.Drawing.Size(279, 24);
            this.program.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(199, 20);
            this.label8.TabIndex = 36;
            this.label8.Text = "Academic Year Semester";
            // 
            // clear
            // 
            this.clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(202)))), ((int)(((byte)(228)))));
            this.clear.Location = new System.Drawing.Point(772, 387);
            this.clear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(180, 48);
            this.clear.TabIndex = 35;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // delete
            // 
            this.delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.delete.Location = new System.Drawing.Point(772, 320);
            this.delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(180, 48);
            this.delete.TabIndex = 34;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.update.ForeColor = System.Drawing.SystemColors.Desktop;
            this.update.Location = new System.Drawing.Point(772, 254);
            this.update.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(180, 48);
            this.update.TabIndex = 33;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // subId
            // 
            this.subId.Dock = System.Windows.Forms.DockStyle.Top;
            this.subId.Location = new System.Drawing.Point(666, 121);
            this.subId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.subId.Name = "subId";
            this.subId.Size = new System.Drawing.Size(316, 22);
            this.subId.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label6.Location = new System.Drawing.Point(500, 117);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "Sub Group ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label5.Location = new System.Drawing.Point(500, 65);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Group ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(500, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Sub Group Number";
            // 
            // grpId
            // 
            this.grpId.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpId.Location = new System.Drawing.Point(666, 69);
            this.grpId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpId.Name = "grpId";
            this.grpId.Size = new System.Drawing.Size(316, 22);
            this.grpId.TabIndex = 26;
            // 
            // academicYS
            // 
            this.academicYS.Dock = System.Windows.Forms.DockStyle.Top;
            this.academicYS.Location = new System.Drawing.Point(213, 4);
            this.academicYS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.academicYS.Name = "academicYS";
            this.academicYS.Size = new System.Drawing.Size(279, 22);
            this.academicYS.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Group Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = " Programme";
            // 
            // stdTB
            // 
            this.stdTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stdTB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stdTB.Location = new System.Drawing.Point(13, 186);
            this.stdTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.stdTB.Name = "stdTB";
            this.stdTB.RowHeadersWidth = 51;
            this.stdTB.Size = new System.Drawing.Size(717, 249);
            this.stdTB.TabIndex = 22;
            this.stdTB.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stdTB_CellContentClick);
            // 
            // StdID
            // 
            this.StdID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StdID.Location = new System.Drawing.Point(705, 137);
            this.StdID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StdID.Name = "StdID";
            this.StdID.Size = new System.Drawing.Size(186, 22);
            this.StdID.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(606, 140);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 17);
            this.label9.TabIndex = 39;
            this.label9.Text = "Student ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(98, 16);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(239, 36);
            this.label7.TabIndex = 38;
            this.label7.Text = "Student Groups";
            // 
            // search
            // 
            this.search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search.BackColor = System.Drawing.Color.Teal;
            this.search.ForeColor = System.Drawing.SystemColors.Desktop;
            this.search.Location = new System.Drawing.Point(772, 186);
            this.search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(180, 48);
            this.search.TabIndex = 41;
            this.search.Text = "Select";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click_1);
            // 
            // grpNum
            // 
            this.grpNum.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.grpNum.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpNum.FormattingEnabled = true;
            this.grpNum.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05"});
            this.grpNum.Location = new System.Drawing.Point(213, 121);
            this.grpNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpNum.Name = "grpNum";
            this.grpNum.Size = new System.Drawing.Size(279, 24);
            this.grpNum.TabIndex = 42;
            // 
            // subGrpNum
            // 
            this.subGrpNum.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.subGrpNum.Dock = System.Windows.Forms.DockStyle.Top;
            this.subGrpNum.FormattingEnabled = true;
            this.subGrpNum.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05"});
            this.subGrpNum.Location = new System.Drawing.Point(666, 4);
            this.subGrpNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.subGrpNum.Name = "subGrpNum";
            this.subGrpNum.Size = new System.Drawing.Size(316, 24);
            this.subGrpNum.TabIndex = 43;
            this.subGrpNum.SelectedIndexChanged += new System.EventHandler(this.subGrpNum_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(986, 49);
            this.panel1.TabIndex = 76;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(986, 68);
            this.panel2.TabIndex = 77;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.26437F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.10751F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.8357F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.75862F));
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.subGrpNum, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.academicYS, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.grpNum, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.program, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.subId, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.grpId, 3, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 462);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.03704F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.62963F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(986, 178);
            this.tableLayoutPanel1.TabIndex = 78;
            // 
            // ManageStd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 640);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.StdID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.stdTB);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ManageStd";
            this.Text = "ManageStd";
            this.Load += new System.EventHandler(this.ManageStd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stdTB)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox program;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.TextBox subId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox grpId;
        private System.Windows.Forms.TextBox academicYS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView stdTB;
        private System.Windows.Forms.TextBox StdID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.ComboBox grpNum;
        private System.Windows.Forms.ComboBox subGrpNum;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}