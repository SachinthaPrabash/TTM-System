
namespace Time_Table_Management_System
{
    partial class Assign_rooms_for_Groups
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.selectRoom = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.selectGroup = new System.Windows.Forms.ComboBox();
            this.studentGroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tLMDataSet2 = new Time_Table_Management_System.TLMDataSet2();
            this.roomTBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tLMDataSet7 = new Time_Table_Management_System.TLMDataSet7();
            this.studentGroupTableAdapter = new Time_Table_Management_System.TLMDataSet2TableAdapters.StudentGroupTableAdapter();
            this.roomTBTableAdapter = new Time_Table_Management_System.TLMDataSet7TableAdapters.roomTBTableAdapter();
            this.groupaForID = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupforRoomGridView = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentGroupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tLMDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomTBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tLMDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupforRoomGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(986, 45);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(57, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Manage session";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(986, 104);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.37037F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.62963F));
            this.tableLayoutPanel1.Controls.Add(this.selectRoom, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.selectGroup, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(39, 256);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.07895F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.92105F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(432, 199);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // selectRoom
            // 
            this.selectRoom.DataSource = this.roomTBBindingSource;
            this.selectRoom.DisplayMember = "roomName";
            this.selectRoom.FormattingEnabled = true;
            this.selectRoom.Location = new System.Drawing.Point(198, 90);
            this.selectRoom.Name = "selectRoom";
            this.selectRoom.Size = new System.Drawing.Size(231, 24);
            this.selectRoom.TabIndex = 43;
            this.selectRoom.ValueMember = "roomName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "Group ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.label4.Location = new System.Drawing.Point(3, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 41);
            this.label4.TabIndex = 3;
            this.label4.Text = "Select Room";
            // 
            // selectGroup
            // 
            this.selectGroup.DataSource = this.studentGroupBindingSource;
            this.selectGroup.DisplayMember = "SubGroupID";
            this.selectGroup.FormattingEnabled = true;
            this.selectGroup.Location = new System.Drawing.Point(198, 3);
            this.selectGroup.Name = "selectGroup";
            this.selectGroup.Size = new System.Drawing.Size(231, 24);
            this.selectGroup.TabIndex = 42;
            this.selectGroup.ValueMember = "SubGroupID";
            // 
            // studentGroupBindingSource
            // 
            this.studentGroupBindingSource.DataMember = "StudentGroup";
            this.studentGroupBindingSource.DataSource = this.tLMDataSet2;
            // 
            // tLMDataSet2
            // 
            this.tLMDataSet2.DataSetName = "TLMDataSet2";
            this.tLMDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomTBBindingSource
            // 
            this.roomTBBindingSource.DataMember = "roomTB";
            this.roomTBBindingSource.DataSource = this.tLMDataSet7;
            // 
            // tLMDataSet7
            // 
            this.tLMDataSet7.DataSetName = "TLMDataSet7";
            this.tLMDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentGroupTableAdapter
            // 
            this.studentGroupTableAdapter.ClearBeforeFill = true;
            // 
            // roomTBTableAdapter
            // 
            this.roomTBTableAdapter.ClearBeforeFill = true;
            // 
            // groupaForID
            // 
            this.groupaForID.Location = new System.Drawing.Point(250, 176);
            this.groupaForID.Name = "groupaForID";
            this.groupaForID.Size = new System.Drawing.Size(201, 22);
            this.groupaForID.TabIndex = 39;
            this.groupaForID.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(85)))), ((int)(((byte)(145)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(76, 496);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 49);
            this.button2.TabIndex = 41;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(220)))), ((int)(((byte)(235)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(274, 496);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 49);
            this.button1.TabIndex = 42;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(186)))), ((int)(((byte)(247)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(76, 555);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 49);
            this.button3.TabIndex = 43;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(145)))), ((int)(((byte)(231)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(274, 555);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(150, 49);
            this.button4.TabIndex = 44;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupforRoomGridView
            // 
            this.groupforRoomGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupforRoomGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.groupforRoomGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.groupforRoomGridView.Location = new System.Drawing.Point(490, 189);
            this.groupforRoomGridView.Name = "groupforRoomGridView";
            this.groupforRoomGridView.RowHeadersWidth = 51;
            this.groupforRoomGridView.RowTemplate.Height = 24;
            this.groupforRoomGridView.Size = new System.Drawing.Size(484, 415);
            this.groupforRoomGridView.TabIndex = 45;
            this.groupforRoomGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Assign_rooms_for_Groups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 640);
            this.Controls.Add(this.groupforRoomGridView);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupaForID);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Assign_rooms_for_Groups";
            this.Text = "Assign_rooms_for_Groups";
            this.Load += new System.EventHandler(this.Assign_rooms_for_Groups_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentGroupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tLMDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomTBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tLMDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupforRoomGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private TLMDataSet2 tLMDataSet2;
        private System.Windows.Forms.BindingSource studentGroupBindingSource;
        private TLMDataSet2TableAdapters.StudentGroupTableAdapter studentGroupTableAdapter;
        private TLMDataSet7 tLMDataSet7;
        private System.Windows.Forms.BindingSource roomTBBindingSource;
        private TLMDataSet7TableAdapters.roomTBTableAdapter roomTBTableAdapter;
        private System.Windows.Forms.ComboBox selectRoom;
        private System.Windows.Forms.ComboBox selectGroup;
        private System.Windows.Forms.TextBox groupaForID;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView groupforRoomGridView;
    }
}