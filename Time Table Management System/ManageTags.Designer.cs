
namespace Time_Table_Management_System
{
    partial class ManageTags
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
            this.label1 = new System.Windows.Forms.Label();
            this.Tagid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tagC = new System.Windows.Forms.TextBox();
            this.relatedT = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tagN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.clearMT = new System.Windows.Forms.Button();
            this.deleteMT = new System.Windows.Forms.Button();
            this.updateMT = new System.Windows.Forms.Button();
            this.tagTB = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.tagTB)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(828, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 50;
            this.label1.Text = "Tag ID";
            // 
            // Tagid
            // 
            this.Tagid.Location = new System.Drawing.Point(763, 114);
            this.Tagid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Tagid.Name = "Tagid";
            this.Tagid.Size = new System.Drawing.Size(179, 22);
            this.Tagid.TabIndex = 49;
            this.Tagid.TextChanged += new System.EventHandler(this.Tagid_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(632, 490);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 48;
            this.label5.Text = "Related Tag";
            // 
            // tagC
            // 
            this.tagC.Location = new System.Drawing.Point(739, 436);
            this.tagC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tagC.Name = "tagC";
            this.tagC.Size = new System.Drawing.Size(188, 22);
            this.tagC.TabIndex = 47;
            // 
            // relatedT
            // 
            this.relatedT.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.relatedT.FormattingEnabled = true;
            this.relatedT.Items.AddRange(new object[] {
            "",
            "Lecture",
            "Tutorial",
            "Practical"});
            this.relatedT.Location = new System.Drawing.Point(739, 480);
            this.relatedT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.relatedT.Name = "relatedT";
            this.relatedT.Size = new System.Drawing.Size(188, 24);
            this.relatedT.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(632, 389);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 17);
            this.label8.TabIndex = 45;
            this.label8.Text = "Tag Name";
            // 
            // tagN
            // 
            this.tagN.Location = new System.Drawing.Point(739, 385);
            this.tagN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tagN.Name = "tagN";
            this.tagN.Size = new System.Drawing.Size(188, 22);
            this.tagN.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(632, 436);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 43;
            this.label2.Text = "Tag Code";
            // 
            // clearMT
            // 
            this.clearMT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(202)))), ((int)(((byte)(228)))));
            this.clearMT.Location = new System.Drawing.Point(763, 313);
            this.clearMT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clearMT.Name = "clearMT";
            this.clearMT.Size = new System.Drawing.Size(180, 48);
            this.clearMT.TabIndex = 42;
            this.clearMT.Text = "Clear";
            this.clearMT.UseVisualStyleBackColor = false;
            this.clearMT.Click += new System.EventHandler(this.clearMT_Click);
            // 
            // deleteMT
            // 
            this.deleteMT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.deleteMT.Location = new System.Drawing.Point(636, 257);
            this.deleteMT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteMT.Name = "deleteMT";
            this.deleteMT.Size = new System.Drawing.Size(180, 48);
            this.deleteMT.TabIndex = 41;
            this.deleteMT.Text = "Delete";
            this.deleteMT.UseVisualStyleBackColor = false;
            this.deleteMT.Click += new System.EventHandler(this.deleteMT_Click);
            // 
            // updateMT
            // 
            this.updateMT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.updateMT.ForeColor = System.Drawing.SystemColors.Desktop;
            this.updateMT.Location = new System.Drawing.Point(763, 202);
            this.updateMT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.updateMT.Name = "updateMT";
            this.updateMT.Size = new System.Drawing.Size(180, 48);
            this.updateMT.TabIndex = 40;
            this.updateMT.Text = "Update";
            this.updateMT.UseVisualStyleBackColor = false;
            this.updateMT.Click += new System.EventHandler(this.updateMT_Click);
            // 
            // tagTB
            // 
            this.tagTB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tagTB.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tagTB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tagTB.Location = new System.Drawing.Point(16, 114);
            this.tagTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tagTB.Name = "tagTB";
            this.tagTB.RowHeadersWidth = 51;
            this.tagTB.Size = new System.Drawing.Size(597, 404);
            this.tagTB.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(288, 68);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(207, 36);
            this.label7.TabIndex = 51;
            this.label7.Text = "Manage Tags";
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.Teal;
            this.search.ForeColor = System.Drawing.SystemColors.Desktop;
            this.search.Location = new System.Drawing.Point(636, 146);
            this.search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(180, 48);
            this.search.TabIndex = 52;
            this.search.Text = "Select";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
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
            // ManageTags
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 533);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tagid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tagC);
            this.Controls.Add(this.relatedT);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tagN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clearMT);
            this.Controls.Add(this.deleteMT);
            this.Controls.Add(this.updateMT);
            this.Controls.Add(this.tagTB);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ManageTags";
            this.Text = "ManageTags";
            this.Load += new System.EventHandler(this.ManageTags_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tagTB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tagid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tagC;
        private System.Windows.Forms.ComboBox relatedT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tagN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button clearMT;
        private System.Windows.Forms.Button deleteMT;
        private System.Windows.Forms.Button updateMT;
        private System.Windows.Forms.DataGridView tagTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Panel panel1;
    }
}