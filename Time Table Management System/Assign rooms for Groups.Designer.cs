
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Assign_rooms_for_Groups));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges7 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges8 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuButton2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.groupforRoomGridView = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.bunifuButton3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuButton4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.groupaForID = new Bunifu.UI.WinForms.BunifuTextBox();
            this.selectGroup = new Bunifu.UI.WinForms.BunifuDropdown();
            this.tLMDataSet2 = new Time_Table_Management_System.TLMDataSet2();
            this.studentGroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentGroupTableAdapter = new Time_Table_Management_System.TLMDataSet2TableAdapters.StudentGroupTableAdapter();
            this.selectRoom = new Bunifu.UI.WinForms.BunifuDropdown();
            this.tLMDataSet7 = new Time_Table_Management_System.TLMDataSet7();
            this.roomTBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomTBTableAdapter = new Time_Table_Management_System.TLMDataSet7TableAdapters.roomTBTableAdapter();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupforRoomGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tLMDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentGroupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tLMDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomTBBindingSource)).BeginInit();
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
            this.tableLayoutPanel1.Controls.Add(this.selectGroup, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.selectRoom, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(39, 256);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.07895F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.92105F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(432, 199);
            this.tableLayoutPanel1.TabIndex = 4;
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
            // bunifuButton2
            // 
            this.bunifuButton2.AllowAnimations = true;
            this.bunifuButton2.AllowMouseEffects = true;
            this.bunifuButton2.AllowToggling = false;
            this.bunifuButton2.AnimationSpeed = 200;
            this.bunifuButton2.AutoGenerateColors = false;
            this.bunifuButton2.AutoRoundBorders = false;
            this.bunifuButton2.AutoSizeLeftIcon = true;
            this.bunifuButton2.AutoSizeRightIcon = true;
            this.bunifuButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton2.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.bunifuButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton2.BackgroundImage")));
            this.bunifuButton2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton2.ButtonText = "Save";
            this.bunifuButton2.ButtonTextMarginLeft = 0;
            this.bunifuButton2.ColorContrastOnClick = 45;
            this.bunifuButton2.ColorContrastOnHover = 45;
            this.bunifuButton2.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.bunifuButton2.CustomizableEdges = borderEdges5;
            this.bunifuButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton2.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton2.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton2.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuButton2.ForeColor = System.Drawing.Color.White;
            this.bunifuButton2.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton2.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton2.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButton2.IconMarginLeft = 11;
            this.bunifuButton2.IconPadding = 10;
            this.bunifuButton2.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButton2.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton2.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButton2.IconSize = 25;
            this.bunifuButton2.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton2.IdleBorderRadius = 20;
            this.bunifuButton2.IdleBorderThickness = 1;
            this.bunifuButton2.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton2.IdleIconLeftImage = null;
            this.bunifuButton2.IdleIconRightImage = null;
            this.bunifuButton2.IndicateFocus = false;
            this.bunifuButton2.Location = new System.Drawing.Point(76, 496);
            this.bunifuButton2.Name = "bunifuButton2";
            this.bunifuButton2.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton2.OnDisabledState.BorderRadius = 20;
            this.bunifuButton2.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton2.OnDisabledState.BorderThickness = 1;
            this.bunifuButton2.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton2.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton2.OnDisabledState.IconLeftImage = null;
            this.bunifuButton2.OnDisabledState.IconRightImage = null;
            this.bunifuButton2.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton2.onHoverState.BorderRadius = 20;
            this.bunifuButton2.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton2.onHoverState.BorderThickness = 1;
            this.bunifuButton2.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton2.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton2.onHoverState.IconLeftImage = null;
            this.bunifuButton2.onHoverState.IconRightImage = null;
            this.bunifuButton2.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton2.OnIdleState.BorderRadius = 20;
            this.bunifuButton2.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton2.OnIdleState.BorderThickness = 1;
            this.bunifuButton2.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton2.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton2.OnIdleState.IconLeftImage = null;
            this.bunifuButton2.OnIdleState.IconRightImage = null;
            this.bunifuButton2.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton2.OnPressedState.BorderRadius = 20;
            this.bunifuButton2.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton2.OnPressedState.BorderThickness = 1;
            this.bunifuButton2.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton2.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton2.OnPressedState.IconLeftImage = null;
            this.bunifuButton2.OnPressedState.IconRightImage = null;
            this.bunifuButton2.Size = new System.Drawing.Size(150, 39);
            this.bunifuButton2.TabIndex = 35;
            this.bunifuButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton2.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton2.TextMarginLeft = 0;
            this.bunifuButton2.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButton2.UseDefaultRadiusAndThickness = true;
            this.bunifuButton2.Click += new System.EventHandler(this.bunifuButton2_Click);
            // 
            // bunifuButton1
            // 
            this.bunifuButton1.AllowAnimations = true;
            this.bunifuButton1.AllowMouseEffects = true;
            this.bunifuButton1.AllowToggling = false;
            this.bunifuButton1.AnimationSpeed = 200;
            this.bunifuButton1.AutoGenerateColors = false;
            this.bunifuButton1.AutoRoundBorders = false;
            this.bunifuButton1.AutoSizeLeftIcon = true;
            this.bunifuButton1.AutoSizeRightIcon = true;
            this.bunifuButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.bunifuButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton1.BackgroundImage")));
            this.bunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.ButtonText = "Clear";
            this.bunifuButton1.ButtonTextMarginLeft = 0;
            this.bunifuButton1.ColorContrastOnClick = 45;
            this.bunifuButton1.ColorContrastOnHover = 45;
            this.bunifuButton1.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges6.BottomLeft = true;
            borderEdges6.BottomRight = true;
            borderEdges6.TopLeft = true;
            borderEdges6.TopRight = true;
            this.bunifuButton1.CustomizableEdges = borderEdges6;
            this.bunifuButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton1.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton1.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton1.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButton1.IconMarginLeft = 11;
            this.bunifuButton1.IconPadding = 10;
            this.bunifuButton1.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButton1.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButton1.IconSize = 25;
            this.bunifuButton1.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton1.IdleBorderRadius = 20;
            this.bunifuButton1.IdleBorderThickness = 1;
            this.bunifuButton1.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton1.IdleIconLeftImage = null;
            this.bunifuButton1.IdleIconRightImage = null;
            this.bunifuButton1.IndicateFocus = false;
            this.bunifuButton1.Location = new System.Drawing.Point(261, 496);
            this.bunifuButton1.Name = "bunifuButton1";
            this.bunifuButton1.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton1.OnDisabledState.BorderRadius = 20;
            this.bunifuButton1.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnDisabledState.BorderThickness = 1;
            this.bunifuButton1.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton1.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton1.OnDisabledState.IconLeftImage = null;
            this.bunifuButton1.OnDisabledState.IconRightImage = null;
            this.bunifuButton1.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton1.onHoverState.BorderRadius = 20;
            this.bunifuButton1.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.onHoverState.BorderThickness = 1;
            this.bunifuButton1.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton1.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.onHoverState.IconLeftImage = null;
            this.bunifuButton1.onHoverState.IconRightImage = null;
            this.bunifuButton1.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton1.OnIdleState.BorderRadius = 20;
            this.bunifuButton1.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnIdleState.BorderThickness = 1;
            this.bunifuButton1.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton1.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.OnIdleState.IconLeftImage = null;
            this.bunifuButton1.OnIdleState.IconRightImage = null;
            this.bunifuButton1.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton1.OnPressedState.BorderRadius = 20;
            this.bunifuButton1.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnPressedState.BorderThickness = 1;
            this.bunifuButton1.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton1.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.OnPressedState.IconLeftImage = null;
            this.bunifuButton1.OnPressedState.IconRightImage = null;
            this.bunifuButton1.Size = new System.Drawing.Size(150, 39);
            this.bunifuButton1.TabIndex = 34;
            this.bunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton1.TextMarginLeft = 0;
            this.bunifuButton1.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButton1.UseDefaultRadiusAndThickness = true;
            this.bunifuButton1.Click += new System.EventHandler(this.bunifuButton1_Click);
            // 
            // groupforRoomGridView
            // 
            this.groupforRoomGridView.AllowCustomTheming = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.groupforRoomGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.groupforRoomGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupforRoomGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.groupforRoomGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.groupforRoomGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.groupforRoomGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.groupforRoomGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.groupforRoomGridView.ColumnHeadersHeight = 40;
            this.groupforRoomGridView.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.groupforRoomGridView.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupforRoomGridView.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.groupforRoomGridView.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.groupforRoomGridView.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.groupforRoomGridView.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.groupforRoomGridView.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.groupforRoomGridView.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupforRoomGridView.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.groupforRoomGridView.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.groupforRoomGridView.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.groupforRoomGridView.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.groupforRoomGridView.CurrentTheme.Name = null;
            this.groupforRoomGridView.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.groupforRoomGridView.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupforRoomGridView.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.groupforRoomGridView.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.groupforRoomGridView.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.groupforRoomGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.groupforRoomGridView.EnableHeadersVisualStyles = false;
            this.groupforRoomGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.groupforRoomGridView.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.groupforRoomGridView.HeaderBgColor = System.Drawing.Color.Empty;
            this.groupforRoomGridView.HeaderForeColor = System.Drawing.Color.White;
            this.groupforRoomGridView.Location = new System.Drawing.Point(521, 165);
            this.groupforRoomGridView.Name = "groupforRoomGridView";
            this.groupforRoomGridView.RowHeadersVisible = false;
            this.groupforRoomGridView.RowHeadersWidth = 51;
            this.groupforRoomGridView.RowTemplate.Height = 40;
            this.groupforRoomGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.groupforRoomGridView.Size = new System.Drawing.Size(420, 415);
            this.groupforRoomGridView.TabIndex = 36;
            this.groupforRoomGridView.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.groupforRoomGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.groupforRoomGridView_CellContentClick);
            // 
            // bunifuButton3
            // 
            this.bunifuButton3.AllowAnimations = true;
            this.bunifuButton3.AllowMouseEffects = true;
            this.bunifuButton3.AllowToggling = false;
            this.bunifuButton3.AnimationSpeed = 200;
            this.bunifuButton3.AutoGenerateColors = false;
            this.bunifuButton3.AutoRoundBorders = false;
            this.bunifuButton3.AutoSizeLeftIcon = true;
            this.bunifuButton3.AutoSizeRightIcon = true;
            this.bunifuButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton3.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.bunifuButton3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton3.BackgroundImage")));
            this.bunifuButton3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton3.ButtonText = "Delete";
            this.bunifuButton3.ButtonTextMarginLeft = 0;
            this.bunifuButton3.ColorContrastOnClick = 45;
            this.bunifuButton3.ColorContrastOnHover = 45;
            this.bunifuButton3.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges7.BottomLeft = true;
            borderEdges7.BottomRight = true;
            borderEdges7.TopLeft = true;
            borderEdges7.TopRight = true;
            this.bunifuButton3.CustomizableEdges = borderEdges7;
            this.bunifuButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton3.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton3.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton3.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton3.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButton3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuButton3.ForeColor = System.Drawing.Color.White;
            this.bunifuButton3.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton3.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton3.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButton3.IconMarginLeft = 11;
            this.bunifuButton3.IconPadding = 10;
            this.bunifuButton3.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButton3.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton3.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButton3.IconSize = 25;
            this.bunifuButton3.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton3.IdleBorderRadius = 20;
            this.bunifuButton3.IdleBorderThickness = 1;
            this.bunifuButton3.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton3.IdleIconLeftImage = null;
            this.bunifuButton3.IdleIconRightImage = null;
            this.bunifuButton3.IndicateFocus = false;
            this.bunifuButton3.Location = new System.Drawing.Point(261, 565);
            this.bunifuButton3.Name = "bunifuButton3";
            this.bunifuButton3.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton3.OnDisabledState.BorderRadius = 20;
            this.bunifuButton3.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton3.OnDisabledState.BorderThickness = 1;
            this.bunifuButton3.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton3.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton3.OnDisabledState.IconLeftImage = null;
            this.bunifuButton3.OnDisabledState.IconRightImage = null;
            this.bunifuButton3.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton3.onHoverState.BorderRadius = 20;
            this.bunifuButton3.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton3.onHoverState.BorderThickness = 1;
            this.bunifuButton3.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton3.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton3.onHoverState.IconLeftImage = null;
            this.bunifuButton3.onHoverState.IconRightImage = null;
            this.bunifuButton3.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton3.OnIdleState.BorderRadius = 20;
            this.bunifuButton3.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton3.OnIdleState.BorderThickness = 1;
            this.bunifuButton3.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton3.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton3.OnIdleState.IconLeftImage = null;
            this.bunifuButton3.OnIdleState.IconRightImage = null;
            this.bunifuButton3.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton3.OnPressedState.BorderRadius = 20;
            this.bunifuButton3.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton3.OnPressedState.BorderThickness = 1;
            this.bunifuButton3.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton3.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton3.OnPressedState.IconLeftImage = null;
            this.bunifuButton3.OnPressedState.IconRightImage = null;
            this.bunifuButton3.Size = new System.Drawing.Size(150, 39);
            this.bunifuButton3.TabIndex = 38;
            this.bunifuButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton3.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton3.TextMarginLeft = 0;
            this.bunifuButton3.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButton3.UseDefaultRadiusAndThickness = true;
            this.bunifuButton3.Click += new System.EventHandler(this.bunifuButton3_Click);
            // 
            // bunifuButton4
            // 
            this.bunifuButton4.AllowAnimations = true;
            this.bunifuButton4.AllowMouseEffects = true;
            this.bunifuButton4.AllowToggling = false;
            this.bunifuButton4.AnimationSpeed = 200;
            this.bunifuButton4.AutoGenerateColors = false;
            this.bunifuButton4.AutoRoundBorders = false;
            this.bunifuButton4.AutoSizeLeftIcon = true;
            this.bunifuButton4.AutoSizeRightIcon = true;
            this.bunifuButton4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton4.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.bunifuButton4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton4.BackgroundImage")));
            this.bunifuButton4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton4.ButtonText = "Update";
            this.bunifuButton4.ButtonTextMarginLeft = 0;
            this.bunifuButton4.ColorContrastOnClick = 45;
            this.bunifuButton4.ColorContrastOnHover = 45;
            this.bunifuButton4.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges8.BottomLeft = true;
            borderEdges8.BottomRight = true;
            borderEdges8.TopLeft = true;
            borderEdges8.TopRight = true;
            this.bunifuButton4.CustomizableEdges = borderEdges8;
            this.bunifuButton4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton4.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton4.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton4.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton4.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButton4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuButton4.ForeColor = System.Drawing.Color.White;
            this.bunifuButton4.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton4.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton4.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButton4.IconMarginLeft = 11;
            this.bunifuButton4.IconPadding = 10;
            this.bunifuButton4.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButton4.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton4.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButton4.IconSize = 25;
            this.bunifuButton4.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton4.IdleBorderRadius = 20;
            this.bunifuButton4.IdleBorderThickness = 1;
            this.bunifuButton4.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton4.IdleIconLeftImage = null;
            this.bunifuButton4.IdleIconRightImage = null;
            this.bunifuButton4.IndicateFocus = false;
            this.bunifuButton4.Location = new System.Drawing.Point(76, 565);
            this.bunifuButton4.Name = "bunifuButton4";
            this.bunifuButton4.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton4.OnDisabledState.BorderRadius = 20;
            this.bunifuButton4.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton4.OnDisabledState.BorderThickness = 1;
            this.bunifuButton4.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton4.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton4.OnDisabledState.IconLeftImage = null;
            this.bunifuButton4.OnDisabledState.IconRightImage = null;
            this.bunifuButton4.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton4.onHoverState.BorderRadius = 20;
            this.bunifuButton4.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton4.onHoverState.BorderThickness = 1;
            this.bunifuButton4.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton4.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton4.onHoverState.IconLeftImage = null;
            this.bunifuButton4.onHoverState.IconRightImage = null;
            this.bunifuButton4.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton4.OnIdleState.BorderRadius = 20;
            this.bunifuButton4.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton4.OnIdleState.BorderThickness = 1;
            this.bunifuButton4.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton4.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton4.OnIdleState.IconLeftImage = null;
            this.bunifuButton4.OnIdleState.IconRightImage = null;
            this.bunifuButton4.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton4.OnPressedState.BorderRadius = 20;
            this.bunifuButton4.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton4.OnPressedState.BorderThickness = 1;
            this.bunifuButton4.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton4.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton4.OnPressedState.IconLeftImage = null;
            this.bunifuButton4.OnPressedState.IconRightImage = null;
            this.bunifuButton4.Size = new System.Drawing.Size(150, 39);
            this.bunifuButton4.TabIndex = 37;
            this.bunifuButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton4.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton4.TextMarginLeft = 0;
            this.bunifuButton4.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButton4.UseDefaultRadiusAndThickness = true;
            this.bunifuButton4.Click += new System.EventHandler(this.bunifuButton4_Click);
            // 
            // groupaForID
            // 
            this.groupaForID.AcceptsReturn = false;
            this.groupaForID.AcceptsTab = false;
            this.groupaForID.AnimationSpeed = 200;
            this.groupaForID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.groupaForID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.groupaForID.BackColor = System.Drawing.Color.Transparent;
            this.groupaForID.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupaForID.BackgroundImage")));
            this.groupaForID.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.groupaForID.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.groupaForID.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.groupaForID.BorderColorIdle = System.Drawing.Color.Silver;
            this.groupaForID.BorderRadius = 1;
            this.groupaForID.BorderThickness = 1;
            this.groupaForID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.groupaForID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.groupaForID.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.groupaForID.DefaultText = "";
            this.groupaForID.FillColor = System.Drawing.Color.White;
            this.groupaForID.HideSelection = true;
            this.groupaForID.IconLeft = null;
            this.groupaForID.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.groupaForID.IconPadding = 10;
            this.groupaForID.IconRight = null;
            this.groupaForID.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.groupaForID.Lines = new string[0];
            this.groupaForID.Location = new System.Drawing.Point(219, 191);
            this.groupaForID.MaxLength = 32767;
            this.groupaForID.MinimumSize = new System.Drawing.Size(1, 1);
            this.groupaForID.Modified = false;
            this.groupaForID.Multiline = false;
            this.groupaForID.Name = "groupaForID";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.groupaForID.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.groupaForID.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.groupaForID.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.groupaForID.OnIdleState = stateProperties8;
            this.groupaForID.Padding = new System.Windows.Forms.Padding(3);
            this.groupaForID.PasswordChar = '\0';
            this.groupaForID.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.groupaForID.PlaceholderText = "Enter text";
            this.groupaForID.ReadOnly = false;
            this.groupaForID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.groupaForID.SelectedText = "";
            this.groupaForID.SelectionLength = 0;
            this.groupaForID.SelectionStart = 0;
            this.groupaForID.ShortcutsEnabled = true;
            this.groupaForID.Size = new System.Drawing.Size(231, 41);
            this.groupaForID.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.groupaForID.TabIndex = 39;
            this.groupaForID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.groupaForID.TextMarginBottom = 0;
            this.groupaForID.TextMarginLeft = 3;
            this.groupaForID.TextMarginTop = 0;
            this.groupaForID.TextPlaceholder = "Enter text";
            this.groupaForID.UseSystemPasswordChar = false;
            this.groupaForID.Visible = false;
            this.groupaForID.WordWrap = true;
            // 
            // selectGroup
            // 
            this.selectGroup.BackColor = System.Drawing.Color.Transparent;
            this.selectGroup.BackgroundColor = System.Drawing.Color.White;
            this.selectGroup.BorderColor = System.Drawing.Color.Silver;
            this.selectGroup.BorderRadius = 1;
            this.selectGroup.Color = System.Drawing.Color.Silver;
            this.selectGroup.DataSource = this.studentGroupBindingSource;
            this.selectGroup.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.selectGroup.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.selectGroup.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.selectGroup.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.selectGroup.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.selectGroup.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.selectGroup.DisplayMember = "SubGroupID";
            this.selectGroup.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.selectGroup.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.selectGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectGroup.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.selectGroup.FillDropDown = true;
            this.selectGroup.FillIndicator = false;
            this.selectGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectGroup.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.selectGroup.ForeColor = System.Drawing.Color.Black;
            this.selectGroup.FormattingEnabled = true;
            this.selectGroup.Icon = null;
            this.selectGroup.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.selectGroup.IndicatorColor = System.Drawing.Color.Gray;
            this.selectGroup.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.selectGroup.ItemBackColor = System.Drawing.Color.White;
            this.selectGroup.ItemBorderColor = System.Drawing.Color.White;
            this.selectGroup.ItemForeColor = System.Drawing.Color.Black;
            this.selectGroup.ItemHeight = 26;
            this.selectGroup.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.selectGroup.ItemHighLightForeColor = System.Drawing.Color.White;
            this.selectGroup.ItemTopMargin = 3;
            this.selectGroup.Location = new System.Drawing.Point(198, 3);
            this.selectGroup.Name = "selectGroup";
            this.selectGroup.Size = new System.Drawing.Size(231, 32);
            this.selectGroup.TabIndex = 40;
            this.selectGroup.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.selectGroup.TextLeftMargin = 5;
            this.selectGroup.ValueMember = "SubGroupID";
            // 
            // tLMDataSet2
            // 
            this.tLMDataSet2.DataSetName = "TLMDataSet2";
            this.tLMDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentGroupBindingSource
            // 
            this.studentGroupBindingSource.DataMember = "StudentGroup";
            this.studentGroupBindingSource.DataSource = this.tLMDataSet2;
            // 
            // studentGroupTableAdapter
            // 
            this.studentGroupTableAdapter.ClearBeforeFill = true;
            // 
            // selectRoom
            // 
            this.selectRoom.BackColor = System.Drawing.Color.Transparent;
            this.selectRoom.BackgroundColor = System.Drawing.Color.White;
            this.selectRoom.BorderColor = System.Drawing.Color.Silver;
            this.selectRoom.BorderRadius = 1;
            this.selectRoom.Color = System.Drawing.Color.Silver;
            this.selectRoom.DataSource = this.roomTBBindingSource;
            this.selectRoom.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.selectRoom.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.selectRoom.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.selectRoom.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.selectRoom.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.selectRoom.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.selectRoom.DisplayMember = "roomName";
            this.selectRoom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.selectRoom.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.selectRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectRoom.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.selectRoom.FillDropDown = true;
            this.selectRoom.FillIndicator = false;
            this.selectRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectRoom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.selectRoom.ForeColor = System.Drawing.Color.Black;
            this.selectRoom.FormattingEnabled = true;
            this.selectRoom.Icon = null;
            this.selectRoom.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.selectRoom.IndicatorColor = System.Drawing.Color.Gray;
            this.selectRoom.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.selectRoom.ItemBackColor = System.Drawing.Color.White;
            this.selectRoom.ItemBorderColor = System.Drawing.Color.White;
            this.selectRoom.ItemForeColor = System.Drawing.Color.Black;
            this.selectRoom.ItemHeight = 26;
            this.selectRoom.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.selectRoom.ItemHighLightForeColor = System.Drawing.Color.White;
            this.selectRoom.ItemTopMargin = 3;
            this.selectRoom.Location = new System.Drawing.Point(198, 90);
            this.selectRoom.Name = "selectRoom";
            this.selectRoom.Size = new System.Drawing.Size(231, 32);
            this.selectRoom.TabIndex = 41;
            this.selectRoom.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.selectRoom.TextLeftMargin = 5;
            this.selectRoom.ValueMember = "roomName";
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
            // Assign_rooms_for_Groups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 640);
            this.Controls.Add(this.groupaForID);
            this.Controls.Add(this.bunifuButton3);
            this.Controls.Add(this.bunifuButton4);
            this.Controls.Add(this.groupforRoomGridView);
            this.Controls.Add(this.bunifuButton2);
            this.Controls.Add(this.bunifuButton1);
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
            ((System.ComponentModel.ISupportInitialize)(this.groupforRoomGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tLMDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentGroupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tLMDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomTBBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
        private Bunifu.UI.WinForms.BunifuDataGridView groupforRoomGridView;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton3;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton4;
        private Bunifu.UI.WinForms.BunifuTextBox groupaForID;
        private Bunifu.UI.WinForms.BunifuDropdown selectGroup;
        private TLMDataSet2 tLMDataSet2;
        private System.Windows.Forms.BindingSource studentGroupBindingSource;
        private TLMDataSet2TableAdapters.StudentGroupTableAdapter studentGroupTableAdapter;
        private Bunifu.UI.WinForms.BunifuDropdown selectRoom;
        private TLMDataSet7 tLMDataSet7;
        private System.Windows.Forms.BindingSource roomTBBindingSource;
        private TLMDataSet7TableAdapters.roomTBTableAdapter roomTBTableAdapter;
    }
}