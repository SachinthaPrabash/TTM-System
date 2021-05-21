
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
            this.dlt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ParallelId = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.parallelTB)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(308, 101);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(261, 36);
            this.label7.TabIndex = 49;
            this.label7.Text = "Parallel Sessions";
            // 
            // parallelTB
            // 
            this.parallelTB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.parallelTB.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.parallelTB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.parallelTB.Location = new System.Drawing.Point(24, 155);
            this.parallelTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.parallelTB.Name = "parallelTB";
            this.parallelTB.RowHeadersWidth = 51;
            this.parallelTB.Size = new System.Drawing.Size(897, 286);
            this.parallelTB.TabIndex = 48;
            // 
            // dlt
            // 
            this.dlt.BackColor = System.Drawing.Color.Navy;
            this.dlt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dlt.ForeColor = System.Drawing.SystemColors.Control;
            this.dlt.Location = new System.Drawing.Point(741, 470);
            this.dlt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dlt.Name = "dlt";
            this.dlt.Size = new System.Drawing.Size(180, 48);
            this.dlt.TabIndex = 52;
            this.dlt.Text = "Delete";
            this.dlt.UseVisualStyleBackColor = false;
            this.dlt.Click += new System.EventHandler(this.dlt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 486);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 54;
            this.label1.Text = "Parallel ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ParallelId
            // 
            this.ParallelId.Location = new System.Drawing.Point(213, 482);
            this.ParallelId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ParallelId.Name = "ParallelId";
            this.ParallelId.Size = new System.Drawing.Size(179, 22);
            this.ParallelId.TabIndex = 53;
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
            // parallel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 533);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ParallelId);
            this.Controls.Add(this.dlt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.parallelTB);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button dlt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ParallelId;
        private System.Windows.Forms.Panel panel1;
    }
}