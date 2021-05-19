
namespace Time_Table_Management_System
{
    partial class AddStd
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
            this.subGrpNum = new System.Windows.Forms.ComboBox();
            this.grpNum = new System.Windows.Forms.ComboBox();
            this.clearA = new System.Windows.Forms.Button();
            this.saveA = new System.Windows.Forms.Button();
            this.generateA = new System.Windows.Forms.Button();
            this.program = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.subId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpId = new System.Windows.Forms.TextBox();
            this.academicYS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // subGrpNum
            // 
            this.subGrpNum.FormattingEnabled = true;
            this.subGrpNum.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04"});
            this.subGrpNum.Location = new System.Drawing.Point(197, 274);
            this.subGrpNum.Name = "subGrpNum";
            this.subGrpNum.Size = new System.Drawing.Size(154, 21);
            this.subGrpNum.TabIndex = 56;
            // 
            // grpNum
            // 
            this.grpNum.FormattingEnabled = true;
            this.grpNum.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04"});
            this.grpNum.Location = new System.Drawing.Point(197, 221);
            this.grpNum.Name = "grpNum";
            this.grpNum.Size = new System.Drawing.Size(154, 21);
            this.grpNum.TabIndex = 55;
            // 
            // clearA
            // 
            this.clearA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(202)))), ((int)(((byte)(228)))));
            this.clearA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearA.Location = new System.Drawing.Point(70, 356);
            this.clearA.Name = "clearA";
            this.clearA.Size = new System.Drawing.Size(135, 39);
            this.clearA.TabIndex = 54;
            this.clearA.Text = "Clear";
            this.clearA.UseVisualStyleBackColor = false;
            this.clearA.Click += new System.EventHandler(this.clearA_Click);
            // 
            // saveA
            // 
            this.saveA.BackColor = System.Drawing.Color.ForestGreen;
            this.saveA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveA.Location = new System.Drawing.Point(252, 356);
            this.saveA.Name = "saveA";
            this.saveA.Size = new System.Drawing.Size(135, 39);
            this.saveA.TabIndex = 53;
            this.saveA.Text = "Save";
            this.saveA.UseVisualStyleBackColor = false;
            this.saveA.Click += new System.EventHandler(this.saveA_Click);
            // 
            // generateA
            // 
            this.generateA.BackColor = System.Drawing.Color.Teal;
            this.generateA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.generateA.ForeColor = System.Drawing.SystemColors.Desktop;
            this.generateA.Location = new System.Drawing.Point(540, 247);
            this.generateA.Name = "generateA";
            this.generateA.Size = new System.Drawing.Size(135, 39);
            this.generateA.TabIndex = 52;
            this.generateA.Text = "Genarate IDs";
            this.generateA.UseVisualStyleBackColor = false;
            this.generateA.Click += new System.EventHandler(this.generateA_Click);
            // 
            // program
            // 
            this.program.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.program.FormattingEnabled = true;
            this.program.Items.AddRange(new object[] {
            "IT",
            "IM",
            "CSSE",
            "CSE"});
            this.program.Location = new System.Drawing.Point(197, 178);
            this.program.Name = "program";
            this.program.Size = new System.Drawing.Size(154, 21);
            this.program.TabIndex = 51;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 13);
            this.label8.TabIndex = 50;
            this.label8.Text = "Academic Year Semester";
            // 
            // subId
            // 
            this.subId.Location = new System.Drawing.Point(522, 177);
            this.subId.Name = "subId";
            this.subId.Size = new System.Drawing.Size(163, 20);
            this.subId.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(405, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "Sub Group ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(405, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "Group ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Sub Group Number";
            // 
            // grpId
            // 
            this.grpId.Location = new System.Drawing.Point(522, 136);
            this.grpId.Name = "grpId";
            this.grpId.Size = new System.Drawing.Size(163, 20);
            this.grpId.TabIndex = 45;
            // 
            // academicYS
            // 
            this.academicYS.Location = new System.Drawing.Point(197, 136);
            this.academicYS.Name = "academicYS";
            this.academicYS.Size = new System.Drawing.Size(154, 20);
            this.academicYS.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Group Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = " Programme";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(247, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(247, 29);
            this.label7.TabIndex = 57;
            this.label7.Text = "Add Student Groups";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(719, 40);
            this.panel1.TabIndex = 76;
            // 
            // AddStd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 433);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.subGrpNum);
            this.Controls.Add(this.grpNum);
            this.Controls.Add(this.clearA);
            this.Controls.Add(this.saveA);
            this.Controls.Add(this.generateA);
            this.Controls.Add(this.program);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.subId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grpId);
            this.Controls.Add(this.academicYS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "AddStd";
            this.Text = "Add Student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox subGrpNum;
        private System.Windows.Forms.ComboBox grpNum;
        private System.Windows.Forms.Button clearA;
        private System.Windows.Forms.Button saveA;
        private System.Windows.Forms.Button generateA;
        private System.Windows.Forms.ComboBox program;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox subId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox grpId;
        private System.Windows.Forms.TextBox academicYS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
    }
}