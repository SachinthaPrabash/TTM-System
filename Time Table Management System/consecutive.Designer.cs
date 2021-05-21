
namespace Time_Table_Management_System
{
    partial class consecutive
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
            this.label7 = new System.Windows.Forms.Label();
            this.consecTb = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.consecID = new System.Windows.Forms.TextBox();
            this.dlt = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.consecTb)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(300, 97);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(329, 36);
            this.label7.TabIndex = 49;
            this.label7.Text = "Consecutive Sessions";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // consecTb
            // 
            this.consecTb.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.consecTb.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.consecTb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.consecTb.Location = new System.Drawing.Point(24, 161);
            this.consecTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.consecTb.Name = "consecTb";
            this.consecTb.RowHeadersWidth = 51;
            this.consecTb.Size = new System.Drawing.Size(901, 271);
            this.consecTb.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 486);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 58;
            this.label1.Text = "Consecutive ID";
            // 
            // consecID
            // 
            this.consecID.Location = new System.Drawing.Point(208, 482);
            this.consecID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.consecID.Name = "consecID";
            this.consecID.Size = new System.Drawing.Size(179, 22);
            this.consecID.TabIndex = 57;
            // 
            // dlt
            // 
            this.dlt.BackColor = System.Drawing.Color.Navy;
            this.dlt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dlt.ForeColor = System.Drawing.SystemColors.Control;
            this.dlt.Location = new System.Drawing.Point(723, 470);
            this.dlt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dlt.Name = "dlt";
            this.dlt.Size = new System.Drawing.Size(180, 48);
            this.dlt.TabIndex = 56;
            this.dlt.Text = "Delete";
            this.dlt.UseVisualStyleBackColor = false;
            this.dlt.Click += new System.EventHandler(this.dlt_Click);
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
            // consecutive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 533);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.consecID);
            this.Controls.Add(this.dlt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.consecTb);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "consecutive";
            this.Text = "consecutive";
            this.Load += new System.EventHandler(this.consecutive_Load);
            ((System.ComponentModel.ISupportInitialize)(this.consecTb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView consecTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox consecID;
        private System.Windows.Forms.Button dlt;
        private System.Windows.Forms.Panel panel1;
    }
}