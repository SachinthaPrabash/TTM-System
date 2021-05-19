
namespace Time_Table_Management_System
{
    partial class nonOverlap
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
            this.NonTb = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.NOID = new System.Windows.Forms.TextBox();
            this.dlt = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.NonTb)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(184, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(325, 29);
            this.label7.TabIndex = 49;
            this.label7.Text = "Non Overlapping Sessions";
            // 
            // NonTb
            // 
            this.NonTb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NonTb.Location = new System.Drawing.Point(18, 123);
            this.NonTb.Name = "NonTb";
            this.NonTb.Size = new System.Drawing.Size(672, 229);
            this.NonTb.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 58;
            this.label1.Text = "Non Overlap ID";
            // 
            // NOID
            // 
            this.NOID.Location = new System.Drawing.Point(141, 387);
            this.NOID.Name = "NOID";
            this.NOID.Size = new System.Drawing.Size(135, 20);
            this.NOID.TabIndex = 57;
            // 
            // dlt
            // 
            this.dlt.BackColor = System.Drawing.Color.Navy;
            this.dlt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dlt.ForeColor = System.Drawing.SystemColors.Control;
            this.dlt.Location = new System.Drawing.Point(572, 368);
            this.dlt.Name = "dlt";
            this.dlt.Size = new System.Drawing.Size(135, 39);
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
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(719, 40);
            this.panel1.TabIndex = 76;
            // 
            // nonOverlap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 433);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NOID);
            this.Controls.Add(this.dlt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NonTb);
            this.Name = "nonOverlap";
            this.Text = "nonOverlap";
            this.Load += new System.EventHandler(this.nonOverlap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NonTb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView NonTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NOID;
        private System.Windows.Forms.Button dlt;
        private System.Windows.Forms.Panel panel1;
    }
}