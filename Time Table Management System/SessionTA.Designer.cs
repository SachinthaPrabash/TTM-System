
namespace Time_Table_Management_System
{
    partial class SessionTA
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
            this.NObtn = new System.Windows.Forms.Button();
            this.cnt = new System.Windows.Forms.Button();
            this.Pbtn = new System.Windows.Forms.Button();
            this.SessionTB = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sessionsId = new System.Windows.Forms.TextBox();
            this.clear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.SessionTB)).BeginInit();
            this.SuspendLayout();
            // 
            // NObtn
            // 
            this.NObtn.BackColor = System.Drawing.Color.Navy;
            this.NObtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NObtn.ForeColor = System.Drawing.SystemColors.Control;
            this.NObtn.Location = new System.Drawing.Point(704, 478);
            this.NObtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NObtn.Name = "NObtn";
            this.NObtn.Size = new System.Drawing.Size(180, 48);
            this.NObtn.TabIndex = 46;
            this.NObtn.Text = "Non Overlapping";
            this.NObtn.UseVisualStyleBackColor = false;
            this.NObtn.Click += new System.EventHandler(this.NObtn_Click);
            // 
            // cnt
            // 
            this.cnt.BackColor = System.Drawing.Color.Navy;
            this.cnt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cnt.ForeColor = System.Drawing.SystemColors.Control;
            this.cnt.Location = new System.Drawing.Point(83, 478);
            this.cnt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cnt.Name = "cnt";
            this.cnt.Size = new System.Drawing.Size(180, 48);
            this.cnt.TabIndex = 44;
            this.cnt.Text = "Consecutive";
            this.cnt.UseVisualStyleBackColor = false;
            this.cnt.Click += new System.EventHandler(this.cnt_Click);
            // 
            // Pbtn
            // 
            this.Pbtn.BackColor = System.Drawing.Color.Navy;
            this.Pbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pbtn.ForeColor = System.Drawing.SystemColors.Control;
            this.Pbtn.Location = new System.Drawing.Point(392, 478);
            this.Pbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Pbtn.Name = "Pbtn";
            this.Pbtn.Size = new System.Drawing.Size(180, 48);
            this.Pbtn.TabIndex = 43;
            this.Pbtn.Text = "Parallel";
            this.Pbtn.UseVisualStyleBackColor = false;
            this.Pbtn.Click += new System.EventHandler(this.Pbtn_Click);
            // 
            // SessionTB
            // 
            this.SessionTB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SessionTB.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SessionTB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SessionTB.Location = new System.Drawing.Point(16, 224);
            this.SessionTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SessionTB.Name = "SessionTB";
            this.SessionTB.RowHeadersWidth = 51;
            this.SessionTB.Size = new System.Drawing.Size(919, 230);
            this.SessionTB.TabIndex = 42;
            this.SessionTB.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SessionTB_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(145, 95);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(639, 36);
            this.label7.TabIndex = 47;
            this.label7.Text = "Session And Not Available Times Allocation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 185);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 52;
            this.label1.Text = "Session ID";
            // 
            // sessionsId
            // 
            this.sessionsId.Location = new System.Drawing.Point(201, 181);
            this.sessionsId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sessionsId.Name = "sessionsId";
            this.sessionsId.Size = new System.Drawing.Size(203, 22);
            this.sessionsId.TabIndex = 51;
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(202)))), ((int)(((byte)(228)))));
            this.clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear.Location = new System.Drawing.Point(704, 169);
            this.clear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(180, 48);
            this.clear.TabIndex = 61;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
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
            // SessionTA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 559);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sessionsId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NObtn);
            this.Controls.Add(this.cnt);
            this.Controls.Add(this.Pbtn);
            this.Controls.Add(this.SessionTB);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SessionTA";
            this.Text = "SessionTA";
            this.Load += new System.EventHandler(this.SessionTA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SessionTB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NObtn;
        private System.Windows.Forms.Button cnt;
        private System.Windows.Forms.Button Pbtn;
        private System.Windows.Forms.DataGridView SessionTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sessionsId;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Panel panel1;
    }
}