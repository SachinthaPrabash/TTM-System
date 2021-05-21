
namespace Time_Table_Management_System
{
    partial class ManageLocation
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdateRoom = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.updateBuildingDropdown = new System.Windows.Forms.ComboBox();
            this.locationTBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tLMDataSet = new Time_Table_Management_System.TLMDataSet();
            this.updCapacity = new System.Windows.Forms.RichTextBox();
            this.updRoomName = new System.Windows.Forms.RichTextBox();
            this.updRoomID = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.updateLabRB = new System.Windows.Forms.RadioButton();
            this.updateLechallRB = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.locationTBTableAdapter = new Time_Table_Management_System.TLMDataSetTableAdapters.locationTBTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuDataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locationTBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tLMDataSet)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Manage Location";
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(220)))), ((int)(((byte)(235)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(792, 310);
            this.btnClear.Margin = new System.Windows.Forms.Padding(0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(149, 47);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(145)))), ((int)(((byte)(231)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(792, 237);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(149, 47);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdateRoom
            // 
            this.btnUpdateRoom.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnUpdateRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(186)))), ((int)(((byte)(247)))));
            this.btnUpdateRoom.FlatAppearance.BorderSize = 0;
            this.btnUpdateRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateRoom.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateRoom.Location = new System.Drawing.Point(792, 157);
            this.btnUpdateRoom.Margin = new System.Windows.Forms.Padding(0);
            this.btnUpdateRoom.Name = "btnUpdateRoom";
            this.btnUpdateRoom.Size = new System.Drawing.Size(149, 47);
            this.btnUpdateRoom.TabIndex = 17;
            this.btnUpdateRoom.Text = "UPDATE";
            this.btnUpdateRoom.UseVisualStyleBackColor = false;
            this.btnUpdateRoom.Click += new System.EventHandler(this.btnUpdateRoom_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(0, 117);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.label4.Size = new System.Drawing.Size(141, 28);
            this.label4.TabIndex = 15;
            this.label4.Text = "Room Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(0, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.label3.Size = new System.Drawing.Size(161, 28);
            this.label3.TabIndex = 14;
            this.label3.Text = "Building Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label6.Location = new System.Drawing.Point(511, 66);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label6.Size = new System.Drawing.Size(97, 28);
            this.label6.TabIndex = 17;
            this.label6.Text = "Capacity";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.87436F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.05025F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.02353F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.05186F));
            this.tableLayoutPanel4.Controls.Add(this.updateBuildingDropdown, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.updCapacity, 3, 1);
            this.tableLayoutPanel4.Controls.Add(this.updRoomName, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.updRoomID, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label6, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 465);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.52174F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.47826F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(986, 175);
            this.tableLayoutPanel4.TabIndex = 25;
            // 
            // updateBuildingDropdown
            // 
            this.updateBuildingDropdown.DataSource = this.locationTBBindingSource;
            this.updateBuildingDropdown.DisplayMember = "locationName";
            this.updateBuildingDropdown.Dock = System.Windows.Forms.DockStyle.Top;
            this.updateBuildingDropdown.FormattingEnabled = true;
            this.updateBuildingDropdown.Location = new System.Drawing.Point(198, 69);
            this.updateBuildingDropdown.Name = "updateBuildingDropdown";
            this.updateBuildingDropdown.Size = new System.Drawing.Size(310, 24);
            this.updateBuildingDropdown.TabIndex = 27;
            this.updateBuildingDropdown.ValueMember = "locationName";
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
            // updCapacity
            // 
            this.updCapacity.Dock = System.Windows.Forms.DockStyle.Top;
            this.updCapacity.Location = new System.Drawing.Point(671, 69);
            this.updCapacity.Name = "updCapacity";
            this.updCapacity.Size = new System.Drawing.Size(312, 38);
            this.updCapacity.TabIndex = 29;
            this.updCapacity.Text = "";
            // 
            // updRoomName
            // 
            this.updRoomName.Dock = System.Windows.Forms.DockStyle.Top;
            this.updRoomName.Location = new System.Drawing.Point(198, 120);
            this.updRoomName.Name = "updRoomName";
            this.updRoomName.Size = new System.Drawing.Size(310, 38);
            this.updRoomName.TabIndex = 28;
            this.updRoomName.Text = "";
            // 
            // updRoomID
            // 
            this.updRoomID.Dock = System.Windows.Forms.DockStyle.Top;
            this.updRoomID.Location = new System.Drawing.Point(198, 3);
            this.updRoomID.Name = "updRoomID";
            this.updRoomID.Size = new System.Drawing.Size(310, 38);
            this.updRoomID.TabIndex = 27;
            this.updRoomID.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(514, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(120, 28);
            this.label1.TabIndex = 19;
            this.label1.Text = "Room Type";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.updateLabRB, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.updateLechallRB, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(671, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(312, 60);
            this.tableLayoutPanel5.TabIndex = 20;
            // 
            // updateLabRB
            // 
            this.updateLabRB.AutoSize = true;
            this.updateLabRB.Dock = System.Windows.Forms.DockStyle.Top;
            this.updateLabRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.updateLabRB.Location = new System.Drawing.Point(159, 3);
            this.updateLabRB.Name = "updateLabRB";
            this.updateLabRB.Size = new System.Drawing.Size(150, 24);
            this.updateLabRB.TabIndex = 32;
            this.updateLabRB.TabStop = true;
            this.updateLabRB.Text = "Laboratory";
            this.updateLabRB.UseVisualStyleBackColor = true;
            // 
            // updateLechallRB
            // 
            this.updateLechallRB.AutoSize = true;
            this.updateLechallRB.Dock = System.Windows.Forms.DockStyle.Top;
            this.updateLechallRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.updateLechallRB.Location = new System.Drawing.Point(3, 3);
            this.updateLechallRB.Name = "updateLechallRB";
            this.updateLechallRB.Size = new System.Drawing.Size(150, 24);
            this.updateLechallRB.TabIndex = 31;
            this.updateLechallRB.TabStop = true;
            this.updateLechallRB.Text = "Lecture Hall";
            this.updateLechallRB.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.label5.Size = new System.Drawing.Size(108, 28);
            this.label5.TabIndex = 25;
            this.label5.Text = "Room ID";
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
            this.panel1.TabIndex = 26;
            // 
            // bunifuDataGridView1
            // 
            this.bunifuDataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuDataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuDataGridView1.Location = new System.Drawing.Point(49, 118);
            this.bunifuDataGridView1.Name = "bunifuDataGridView1";
            this.bunifuDataGridView1.RowHeadersWidth = 51;
            this.bunifuDataGridView1.RowTemplate.Height = 24;
            this.bunifuDataGridView1.Size = new System.Drawing.Size(716, 312);
            this.bunifuDataGridView1.TabIndex = 27;
            this.bunifuDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ManageLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 640);
            this.Controls.Add(this.bunifuDataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdateRoom);
            this.Controls.Add(this.label2);
            this.Name = "ManageLocation";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locationTBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tLMDataSet)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdateRoom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.RadioButton updateLabRB;
        private System.Windows.Forms.RadioButton updateLechallRB;
        private System.Windows.Forms.Label label5;
        private TLMDataSet tLMDataSet;
        private System.Windows.Forms.BindingSource locationTBBindingSource;
        private TLMDataSetTableAdapters.locationTBTableAdapter locationTBTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox updateBuildingDropdown;
        private System.Windows.Forms.RichTextBox updCapacity;
        private System.Windows.Forms.RichTextBox updRoomName;
        private System.Windows.Forms.RichTextBox updRoomID;
        private System.Windows.Forms.DataGridView bunifuDataGridView1;
    }
}