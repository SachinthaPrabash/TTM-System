
namespace Time_Table_Management_System
{
    partial class AddTags
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
            this.label5 = new System.Windows.Forms.Label();
            this.tagC = new System.Windows.Forms.TextBox();
            this.relatedT = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tagN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.clearAT = new System.Windows.Forms.Button();
            this.saveAT = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 138);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 32);
            this.label5.TabIndex = 54;
            this.label5.Text = "Related Tag";
            // 
            // tagC
            // 
            this.tagC.Dock = System.Windows.Forms.DockStyle.Top;
            this.tagC.Location = new System.Drawing.Point(246, 73);
            this.tagC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tagC.Name = "tagC";
            this.tagC.Size = new System.Drawing.Size(416, 22);
            this.tagC.TabIndex = 53;
            // 
            // relatedT
            // 
            this.relatedT.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.relatedT.Dock = System.Windows.Forms.DockStyle.Top;
            this.relatedT.FormattingEnabled = true;
            this.relatedT.Items.AddRange(new object[] {
            "Lecture",
            "Tutorial",
            "Practical"});
            this.relatedT.Location = new System.Drawing.Point(246, 142);
            this.relatedT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.relatedT.Name = "relatedT";
            this.relatedT.Size = new System.Drawing.Size(416, 24);
            this.relatedT.TabIndex = 52;
            this.relatedT.SelectedIndexChanged += new System.EventHandler(this.relatedT_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 32);
            this.label8.TabIndex = 51;
            this.label8.Text = "Tag Name";
            // 
            // tagN
            // 
            this.tagN.Dock = System.Windows.Forms.DockStyle.Top;
            this.tagN.Location = new System.Drawing.Point(246, 4);
            this.tagN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tagN.Name = "tagN";
            this.tagN.Size = new System.Drawing.Size(416, 22);
            this.tagN.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 32);
            this.label2.TabIndex = 49;
            this.label2.Text = "Tag Code";
            // 
            // clearAT
            // 
            this.clearAT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(202)))), ((int)(((byte)(228)))));
            this.clearAT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearAT.Location = new System.Drawing.Point(279, 442);
            this.clearAT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clearAT.Name = "clearAT";
            this.clearAT.Size = new System.Drawing.Size(180, 48);
            this.clearAT.TabIndex = 48;
            this.clearAT.Text = "Clear";
            this.clearAT.UseVisualStyleBackColor = false;
            this.clearAT.Click += new System.EventHandler(this.clearAT_Click);
            // 
            // saveAT
            // 
            this.saveAT.BackColor = System.Drawing.Color.ForestGreen;
            this.saveAT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveAT.Location = new System.Drawing.Point(522, 442);
            this.saveAT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveAT.Name = "saveAT";
            this.saveAT.Size = new System.Drawing.Size(180, 48);
            this.saveAT.TabIndex = 47;
            this.saveAT.Text = "Save";
            this.saveAT.UseVisualStyleBackColor = false;
            this.saveAT.Click += new System.EventHandler(this.saveAT_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(81, 13);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 36);
            this.label7.TabIndex = 46;
            this.label7.Text = "Add Tags";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(959, 49);
            this.panel1.TabIndex = 76;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(959, 61);
            this.panel2.TabIndex = 77;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 110);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(959, 49);
            this.panel3.TabIndex = 78;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 159);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(103, 374);
            this.panel4.TabIndex = 79;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(769, 159);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(190, 374);
            this.panel5.TabIndex = 80;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.33634F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.66366F));
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tagN, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tagC, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.relatedT, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(103, 159);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(666, 208);
            this.tableLayoutPanel1.TabIndex = 81;
            // 
            // AddTags
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 533);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.clearAT);
            this.Controls.Add(this.saveAT);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddTags";
            this.Text = "AddTags";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tagC;
        private System.Windows.Forms.ComboBox relatedT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tagN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button clearAT;
        private System.Windows.Forms.Button saveAT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}