
namespace Time_Table_Management_System
{
    partial class parallel
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
            this.parallelTB = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ParallelId = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dlt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.parallelTB)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(231, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(217, 29);
            this.label7.TabIndex = 49;
            this.label7.Text = "Parallel Sessions";
            // 
            // parallelTB
            // 
            this.parallelTB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.parallelTB.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.parallelTB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.parallelTB.Location = new System.Drawing.Point(18, 126);
            this.parallelTB.Name = "parallelTB";
            this.parallelTB.RowHeadersWidth = 51;
            this.parallelTB.Size = new System.Drawing.Size(673, 232);
            this.parallelTB.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 395);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "Parallel ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ParallelId
            // 
            this.ParallelId.Location = new System.Drawing.Point(160, 392);
            this.ParallelId.Name = "ParallelId";
            this.ParallelId.Size = new System.Drawing.Size(135, 20);
            this.ParallelId.TabIndex = 53;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(719, 40);
            this.panel1.TabIndex = 76;
            // 
            // dlt
            // 
            this.dlt.BackColor = System.Drawing.Color.Navy;
            this.dlt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dlt.ForeColor = System.Drawing.SystemColors.Control;
            this.dlt.Location = new System.Drawing.Point(543, 382);
            this.dlt.Name = "dlt";
            this.dlt.Size = new System.Drawing.Size(135, 39);
            this.dlt.TabIndex = 77;
            this.dlt.Text = "Delete";
            this.dlt.UseVisualStyleBackColor = false;
            this.dlt.Click += new System.EventHandler(this.dlt_Click_1);
            // 
            // parallel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 433);
            this.Controls.Add(this.dlt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ParallelId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.parallelTB);
            this.Name = "parallel";
            this.Text = "parallel";
            this.Load += new System.EventHandler(this.parallel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.parallelTB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView parallelTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ParallelId;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button dlt;
    }
}