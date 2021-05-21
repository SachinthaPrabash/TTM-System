
namespace Time_Table_Management_System
{
    partial class AddRooms
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.addCapacity = new System.Windows.Forms.RichTextBox();
            this.addRoomName = new System.Windows.Forms.RichTextBox();
            this.bNameDropdown = new System.Windows.Forms.ComboBox();
            this.locationTBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tLMDataSet = new Time_Table_Management_System.TLMDataSet();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.rbLab = new System.Windows.Forms.RadioButton();
            this.rbLecHall = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.clearbtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.locationTBTableAdapter = new Time_Table_Management_System.TLMDataSetTableAdapters.locationTBTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locationTBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tLMDataSet)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.893F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.107F));
            this.tableLayoutPanel1.Controls.Add(this.addCapacity, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.addRoomName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.bNameDropdown, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(91, 147);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(768, 382);
            this.tableLayoutPanel1.TabIndex = 28;
            // 
            // addCapacity
            // 
            this.addCapacity.Dock = System.Windows.Forms.DockStyle.Top;
            this.addCapacity.Location = new System.Drawing.Point(255, 193);
            this.addCapacity.Name = "addCapacity";
            this.addCapacity.Size = new System.Drawing.Size(510, 38);
            this.addCapacity.TabIndex = 31;
            this.addCapacity.Text = "";
            // 
            // addRoomName
            // 
            this.addRoomName.Dock = System.Windows.Forms.DockStyle.Top;
            this.addRoomName.Location = new System.Drawing.Point(255, 98);
            this.addRoomName.Name = "addRoomName";
            this.addRoomName.Size = new System.Drawing.Size(510, 42);
            this.addRoomName.TabIndex = 31;
            this.addRoomName.Text = "";
            // 
            // bNameDropdown
            // 
            this.bNameDropdown.DataSource = this.locationTBBindingSource;
            this.bNameDropdown.DisplayMember = "locationName";
            this.bNameDropdown.Dock = System.Windows.Forms.DockStyle.Top;
            this.bNameDropdown.FormattingEnabled = true;
            this.bNameDropdown.Location = new System.Drawing.Point(255, 3);
            this.bNameDropdown.Name = "bNameDropdown";
            this.bNameDropdown.Size = new System.Drawing.Size(510, 24);
            this.bNameDropdown.TabIndex = 31;
            this.bNameDropdown.ValueMember = "locationName";
            // 
            // locationTBBindingSource
            // 
            this.locationTBBindingSource.DataMember = "locationTB";
            this.locationTBBindingSource.DataSource = this.tLMDataSet;
            // 
            // tLMDataSet
            // 
            this.tLMDataSet.DataSetName = "TLMDataSet";
            this.tLMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 285);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.label5.Size = new System.Drawing.Size(188, 41);
            this.label5.TabIndex = 15;
            this.label5.Text = "Room Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 95);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.label4.Size = new System.Drawing.Size(204, 41);
            this.label4.TabIndex = 14;
            this.label4.Text = "Room Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.label3.Size = new System.Drawing.Size(233, 41);
            this.label3.TabIndex = 13;
            this.label3.Text = "Building Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 190);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.label6.Size = new System.Drawing.Size(151, 41);
            this.label6.TabIndex = 16;
            this.label6.Text = "Capacity";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.rbLab, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.rbLecHall, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(255, 288);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(510, 91);
            this.tableLayoutPanel3.TabIndex = 20;
            // 
            // rbLab
            // 
            this.rbLab.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbLab.AutoSize = true;
            this.rbLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.rbLab.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rbLab.Location = new System.Drawing.Point(258, 3);
            this.rbLab.Name = "rbLab";
            this.rbLab.Size = new System.Drawing.Size(249, 33);
            this.rbLab.TabIndex = 30;
            this.rbLab.TabStop = true;
            this.rbLab.Text = "Laboratory";
            this.rbLab.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rbLab.UseVisualStyleBackColor = true;
            // 
            // rbLecHall
            // 
            this.rbLecHall.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbLecHall.AutoSize = true;
            this.rbLecHall.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.rbLecHall.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rbLecHall.Location = new System.Drawing.Point(3, 3);
            this.rbLecHall.Name = "rbLecHall";
            this.rbLecHall.Size = new System.Drawing.Size(249, 33);
            this.rbLecHall.TabIndex = 29;
            this.rbLecHall.TabStop = true;
            this.rbLecHall.Text = "Lecture Hall";
            this.rbLecHall.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rbLecHall.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(374, 36);
            this.label2.TabIndex = 25;
            this.label2.Text = "Add rooms building wise:";
            // 
            // clearbtn
            // 
            this.clearbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(220)))), ((int)(((byte)(235)))));
            this.clearbtn.FlatAppearance.BorderSize = 0;
            this.clearbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearbtn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearbtn.Location = new System.Drawing.Point(598, 562);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(149, 47);
            this.clearbtn.TabIndex = 27;
            this.clearbtn.Text = "CLEAR";
            this.clearbtn.UseVisualStyleBackColor = false;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // addbtn
            // 
            this.addbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(186)))), ((int)(((byte)(247)))));
            this.addbtn.FlatAppearance.BorderSize = 0;
            this.addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbtn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.Location = new System.Drawing.Point(780, 562);
            this.addbtn.Margin = new System.Windows.Forms.Padding(0);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(149, 47);
            this.addbtn.TabIndex = 29;
            this.addbtn.Text = "ADD";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // locationTBTableAdapter
            // 
            this.locationTBTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(986, 49);
            this.panel1.TabIndex = 30;
            // 
            // AddRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(986, 640);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clearbtn);
            this.Name = "AddRooms";
            this.Text = "AddRooms";
            this.Load += new System.EventHandler(this.AddRooms_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locationTBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tLMDataSet)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.RadioButton rbLecHall;
        private System.Windows.Forms.RadioButton rbLab;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button addbtn;
        private TLMDataSet tLMDataSet;
        private System.Windows.Forms.BindingSource locationTBBindingSource;
        private TLMDataSetTableAdapters.locationTBTableAdapter locationTBTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox addCapacity;
        private System.Windows.Forms.RichTextBox addRoomName;
        private System.Windows.Forms.ComboBox bNameDropdown;
    }
}