
namespace Time_Table_Management_System
{
    partial class NotAvailableLoccation
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
            this.selectstart1 = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.selectend = new System.Windows.Forms.TextBox();
            this.dataviewNL = new System.Windows.Forms.DataGridView();
            this.btndeleteNL = new System.Windows.Forms.Button();
            this.btnupdateNL = new System.Windows.Forms.Button();
            this.btnaddNL = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.selectroom = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.selectlocation = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tLMDataSet = new Time_Table_Management_System.TLMDataSet();
            this.locationTBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.locationTBTableAdapter = new Time_Table_Management_System.TLMDataSetTableAdapters.locationTBTableAdapter();
            this.tLMDataSet7 = new Time_Table_Management_System.TLMDataSet7();
            this.roomTBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomTBTableAdapter = new Time_Table_Management_System.TLMDataSet7TableAdapters.roomTBTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataviewNL)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tLMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationTBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tLMDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomTBBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // selectstart1
            // 
            this.selectstart1.Dock = System.Windows.Forms.DockStyle.Top;
            this.selectstart1.Location = new System.Drawing.Point(3, 52);
            this.selectstart1.Name = "selectstart1";
            this.selectstart1.Size = new System.Drawing.Size(105, 22);
            this.selectstart1.TabIndex = 126;
            this.selectstart1.TextChanged += new System.EventHandler(this.selectstart1_TextChanged);
            // 
            // date
            // 
            this.date.CustomFormat = "yyyy--MM--dd";
            this.date.Dock = System.Windows.Forms.DockStyle.Top;
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date.Location = new System.Drawing.Point(126, 77);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(223, 22);
            this.date.TabIndex = 107;
            this.date.ValueChanged += new System.EventHandler(this.date_ValueChanged);
            // 
            // selectend
            // 
            this.selectend.Dock = System.Windows.Forms.DockStyle.Top;
            this.selectend.Location = new System.Drawing.Point(114, 52);
            this.selectend.Name = "selectend";
            this.selectend.Size = new System.Drawing.Size(106, 22);
            this.selectend.TabIndex = 123;
            this.selectend.TextChanged += new System.EventHandler(this.selectend_TextChanged);
            // 
            // dataviewNL
            // 
            this.dataviewNL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataviewNL.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataviewNL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataviewNL.Location = new System.Drawing.Point(459, 177);
            this.dataviewNL.Name = "dataviewNL";
            this.dataviewNL.RowHeadersWidth = 51;
            this.dataviewNL.RowTemplate.Height = 24;
            this.dataviewNL.Size = new System.Drawing.Size(497, 278);
            this.dataviewNL.TabIndex = 122;
            this.dataviewNL.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataviewNA_CellContentClick);
            // 
            // btndeleteNL
            // 
            this.btndeleteNL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btndeleteNL.BackColor = System.Drawing.Color.Red;
            this.btndeleteNL.Location = new System.Drawing.Point(830, 520);
            this.btndeleteNL.Name = "btndeleteNL";
            this.btndeleteNL.Size = new System.Drawing.Size(110, 43);
            this.btndeleteNL.TabIndex = 121;
            this.btndeleteNL.Text = "DELETE";
            this.btndeleteNL.UseVisualStyleBackColor = false;
            this.btndeleteNL.Click += new System.EventHandler(this.btndeleteNL_Click);
            // 
            // btnupdateNL
            // 
            this.btnupdateNL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnupdateNL.BackColor = System.Drawing.Color.Yellow;
            this.btnupdateNL.Location = new System.Drawing.Point(679, 525);
            this.btnupdateNL.Name = "btnupdateNL";
            this.btnupdateNL.Size = new System.Drawing.Size(110, 42);
            this.btnupdateNL.TabIndex = 120;
            this.btnupdateNL.Text = "UPDATE";
            this.btnupdateNL.UseVisualStyleBackColor = false;
            this.btnupdateNL.Click += new System.EventHandler(this.btnupdateNA_Click);
            // 
            // btnaddNL
            // 
            this.btnaddNL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnaddNL.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnaddNL.Location = new System.Drawing.Point(523, 525);
            this.btnaddNL.Name = "btnaddNL";
            this.btnaddNL.Size = new System.Drawing.Size(112, 47);
            this.btnaddNL.TabIndex = 119;
            this.btnaddNL.Text = "ADD";
            this.btnaddNL.UseVisualStyleBackColor = false;
            this.btnaddNL.Click += new System.EventHandler(this.btnaddNA_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(114, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 34);
            this.label16.TabIndex = 118;
            this.label16.Text = "End Time (AM/PM)";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 34);
            this.label15.TabIndex = 117;
            this.label15.Text = "Start Time (AM/PM)";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.label14.Location = new System.Drawing.Point(3, 314);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 32);
            this.label14.TabIndex = 116;
            this.label14.Text = "Time";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // selectroom
            // 
            this.selectroom.DataSource = this.roomTBBindingSource;
            this.selectroom.DisplayMember = "roomName";
            this.selectroom.Dock = System.Windows.Forms.DockStyle.Top;
            this.selectroom.FormattingEnabled = true;
            this.selectroom.Location = new System.Drawing.Point(126, 227);
            this.selectroom.Name = "selectroom";
            this.selectroom.Size = new System.Drawing.Size(223, 24);
            this.selectroom.TabIndex = 111;
            this.selectroom.ValueMember = "roomName";
            this.selectroom.SelectedIndexChanged += new System.EventHandler(this.selectgroup_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.label9.Location = new System.Drawing.Point(3, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 64);
            this.label9.TabIndex = 110;
            this.label9.Text = "Select Room";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // selectlocation
            // 
            this.selectlocation.DataSource = this.locationTBBindingSource;
            this.selectlocation.DisplayMember = "locationName";
            this.selectlocation.Dock = System.Windows.Forms.DockStyle.Top;
            this.selectlocation.FormattingEnabled = true;
            this.selectlocation.Location = new System.Drawing.Point(126, 143);
            this.selectlocation.Name = "selectlocation";
            this.selectlocation.Size = new System.Drawing.Size(223, 24);
            this.selectlocation.TabIndex = 109;
            this.selectlocation.ValueMember = "locationName";
            this.selectlocation.SelectedIndexChanged += new System.EventHandler(this.selectlecure_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.label8.Location = new System.Drawing.Point(3, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 64);
            this.label8.TabIndex = 108;
            this.label8.Text = "Select Location";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 32);
            this.label7.TabIndex = 106;
            this.label7.Text = "Date";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(126, 3);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(100, 22);
            this.id.TabIndex = 127;
            this.id.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(986, 49);
            this.panel1.TabIndex = 128;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(986, 63);
            this.panel2.TabIndex = 129;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(459, 36);
            this.label2.TabIndex = 27;
            this.label2.Text = "Not Available Location";
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 112);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(986, 40);
            this.panel3.TabIndex = 130;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 152);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(54, 488);
            this.panel4.TabIndex = 131;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.22727F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.77273F));
            this.tableLayoutPanel1.Controls.Add(this.id, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.date, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.selectlocation, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.selectroom, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label14, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(54, 152);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.71562F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.85082F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.04662F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.44522F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.94172F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(352, 488);
            this.tableLayoutPanel1.TabIndex = 132;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label15, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label16, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.selectstart1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.selectend, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(126, 317);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(223, 99);
            this.tableLayoutPanel2.TabIndex = 128;
            // 
            // tLMDataSet
            // 
            this.tLMDataSet.DataSetName = "TLMDataSet";
            this.tLMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // locationTBBindingSource
            // 
            this.locationTBBindingSource.DataMember = "locationTB";
            this.locationTBBindingSource.DataSource = this.tLMDataSet;
            // 
            // locationTBTableAdapter
            // 
            this.locationTBTableAdapter.ClearBeforeFill = true;
            // 
            // tLMDataSet7
            // 
            this.tLMDataSet7.DataSetName = "TLMDataSet7";
            this.tLMDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomTBBindingSource
            // 
            this.roomTBBindingSource.DataMember = "roomTB";
            this.roomTBBindingSource.DataSource = this.tLMDataSet7;
            // 
            // roomTBTableAdapter
            // 
            this.roomTBTableAdapter.ClearBeforeFill = true;
            // 
            // NotAvailableLoccation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 640);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataviewNL);
            this.Controls.Add(this.btndeleteNL);
            this.Controls.Add(this.btnupdateNL);
            this.Controls.Add(this.btnaddNL);
            this.Name = "NotAvailableLoccation";
            this.Text = "NotAvailableLoccation";
            this.Load += new System.EventHandler(this.NotAvailableLoccation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataviewNL)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tLMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationTBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tLMDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomTBBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox selectstart1;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.TextBox selectend;
        private System.Windows.Forms.DataGridView dataviewNL;
        private System.Windows.Forms.Button btndeleteNL;
        private System.Windows.Forms.Button btnupdateNL;
        private System.Windows.Forms.Button btnaddNL;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox selectroom;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox selectlocation;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private TLMDataSet tLMDataSet;
        private System.Windows.Forms.BindingSource locationTBBindingSource;
        private TLMDataSetTableAdapters.locationTBTableAdapter locationTBTableAdapter;
        private TLMDataSet7 tLMDataSet7;
        private System.Windows.Forms.BindingSource roomTBBindingSource;
        private TLMDataSet7TableAdapters.roomTBTableAdapter roomTBTableAdapter;
    }
}