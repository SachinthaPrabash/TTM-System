
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRooms));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties17 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties18 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties19 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties20 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties21 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties22 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties23 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties24 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bNameDropdown = new Bunifu.UI.WinForms.BunifuDropdown();
            this.locationTBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tLMDataSet = new Time_Table_Management_System.TLMDataSet();
            this.addCapacity = new Bunifu.UI.WinForms.BunifuTextBox();
            this.addRoomName = new Bunifu.UI.WinForms.BunifuTextBox();
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
            this.tableLayoutPanel1.Controls.Add(this.bNameDropdown, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.addCapacity, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.addRoomName, 1, 1);
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
            // bNameDropdown
            // 
            this.bNameDropdown.BackColor = System.Drawing.Color.Transparent;
            this.bNameDropdown.BackgroundColor = System.Drawing.Color.White;
            this.bNameDropdown.BorderColor = System.Drawing.Color.Silver;
            this.bNameDropdown.BorderRadius = 1;
            this.bNameDropdown.Color = System.Drawing.Color.Silver;
            this.bNameDropdown.DataSource = this.locationTBBindingSource;
            this.bNameDropdown.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.bNameDropdown.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.bNameDropdown.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bNameDropdown.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.bNameDropdown.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.bNameDropdown.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.bNameDropdown.DisplayMember = "locationName";
            this.bNameDropdown.Dock = System.Windows.Forms.DockStyle.Top;
            this.bNameDropdown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.bNameDropdown.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.bNameDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bNameDropdown.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.bNameDropdown.FillDropDown = true;
            this.bNameDropdown.FillIndicator = false;
            this.bNameDropdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNameDropdown.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bNameDropdown.ForeColor = System.Drawing.Color.Black;
            this.bNameDropdown.FormattingEnabled = true;
            this.bNameDropdown.Icon = null;
            this.bNameDropdown.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.bNameDropdown.IndicatorColor = System.Drawing.Color.Gray;
            this.bNameDropdown.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.bNameDropdown.ItemBackColor = System.Drawing.Color.White;
            this.bNameDropdown.ItemBorderColor = System.Drawing.Color.White;
            this.bNameDropdown.ItemForeColor = System.Drawing.Color.Black;
            this.bNameDropdown.ItemHeight = 26;
            this.bNameDropdown.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.bNameDropdown.ItemHighLightForeColor = System.Drawing.Color.White;
            this.bNameDropdown.ItemTopMargin = 3;
            this.bNameDropdown.Location = new System.Drawing.Point(255, 3);
            this.bNameDropdown.Name = "bNameDropdown";
            this.bNameDropdown.Size = new System.Drawing.Size(510, 32);
            this.bNameDropdown.TabIndex = 30;
            this.bNameDropdown.Text = null;
            this.bNameDropdown.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.bNameDropdown.TextLeftMargin = 5;
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
            // addCapacity
            // 
            this.addCapacity.AcceptsReturn = false;
            this.addCapacity.AcceptsTab = false;
            this.addCapacity.AnimationSpeed = 200;
            this.addCapacity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.addCapacity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.addCapacity.BackColor = System.Drawing.Color.White;
            this.addCapacity.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addCapacity.BackgroundImage")));
            this.addCapacity.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.addCapacity.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.addCapacity.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.addCapacity.BorderColorIdle = System.Drawing.Color.Silver;
            this.addCapacity.BorderRadius = 1;
            this.addCapacity.BorderThickness = 1;
            this.addCapacity.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.addCapacity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addCapacity.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.addCapacity.DefaultText = "";
            this.addCapacity.Dock = System.Windows.Forms.DockStyle.Top;
            this.addCapacity.FillColor = System.Drawing.Color.White;
            this.addCapacity.HideSelection = true;
            this.addCapacity.IconLeft = null;
            this.addCapacity.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.addCapacity.IconPadding = 10;
            this.addCapacity.IconRight = null;
            this.addCapacity.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.addCapacity.Lines = new string[0];
            this.addCapacity.Location = new System.Drawing.Point(255, 193);
            this.addCapacity.MaxLength = 32767;
            this.addCapacity.MinimumSize = new System.Drawing.Size(1, 1);
            this.addCapacity.Modified = false;
            this.addCapacity.Multiline = false;
            this.addCapacity.Name = "addCapacity";
            stateProperties17.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties17.FillColor = System.Drawing.Color.Empty;
            stateProperties17.ForeColor = System.Drawing.Color.Empty;
            stateProperties17.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.addCapacity.OnActiveState = stateProperties17;
            stateProperties18.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties18.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties18.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.addCapacity.OnDisabledState = stateProperties18;
            stateProperties19.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties19.FillColor = System.Drawing.Color.Empty;
            stateProperties19.ForeColor = System.Drawing.Color.Empty;
            stateProperties19.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.addCapacity.OnHoverState = stateProperties19;
            stateProperties20.BorderColor = System.Drawing.Color.Silver;
            stateProperties20.FillColor = System.Drawing.Color.White;
            stateProperties20.ForeColor = System.Drawing.Color.Empty;
            stateProperties20.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.addCapacity.OnIdleState = stateProperties20;
            this.addCapacity.Padding = new System.Windows.Forms.Padding(3);
            this.addCapacity.PasswordChar = '\0';
            this.addCapacity.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.addCapacity.PlaceholderText = "Enter text";
            this.addCapacity.ReadOnly = false;
            this.addCapacity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.addCapacity.SelectedText = "";
            this.addCapacity.SelectionLength = 0;
            this.addCapacity.SelectionStart = 0;
            this.addCapacity.ShortcutsEnabled = true;
            this.addCapacity.Size = new System.Drawing.Size(510, 45);
            this.addCapacity.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.addCapacity.TabIndex = 23;
            this.addCapacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.addCapacity.TextMarginBottom = 0;
            this.addCapacity.TextMarginLeft = 3;
            this.addCapacity.TextMarginTop = 0;
            this.addCapacity.TextPlaceholder = "Enter text";
            this.addCapacity.UseSystemPasswordChar = false;
            this.addCapacity.WordWrap = true;
            // 
            // addRoomName
            // 
            this.addRoomName.AcceptsReturn = false;
            this.addRoomName.AcceptsTab = false;
            this.addRoomName.AnimationSpeed = 200;
            this.addRoomName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.addRoomName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.addRoomName.BackColor = System.Drawing.Color.White;
            this.addRoomName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addRoomName.BackgroundImage")));
            this.addRoomName.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.addRoomName.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.addRoomName.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.addRoomName.BorderColorIdle = System.Drawing.Color.Silver;
            this.addRoomName.BorderRadius = 1;
            this.addRoomName.BorderThickness = 1;
            this.addRoomName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.addRoomName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addRoomName.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.addRoomName.DefaultText = "";
            this.addRoomName.Dock = System.Windows.Forms.DockStyle.Top;
            this.addRoomName.FillColor = System.Drawing.Color.White;
            this.addRoomName.HideSelection = true;
            this.addRoomName.IconLeft = null;
            this.addRoomName.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.addRoomName.IconPadding = 10;
            this.addRoomName.IconRight = null;
            this.addRoomName.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.addRoomName.Lines = new string[0];
            this.addRoomName.Location = new System.Drawing.Point(255, 98);
            this.addRoomName.MaxLength = 32767;
            this.addRoomName.MinimumSize = new System.Drawing.Size(1, 1);
            this.addRoomName.Modified = false;
            this.addRoomName.Multiline = false;
            this.addRoomName.Name = "addRoomName";
            stateProperties21.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties21.FillColor = System.Drawing.Color.Empty;
            stateProperties21.ForeColor = System.Drawing.Color.Empty;
            stateProperties21.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.addRoomName.OnActiveState = stateProperties21;
            stateProperties22.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties22.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties22.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.addRoomName.OnDisabledState = stateProperties22;
            stateProperties23.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties23.FillColor = System.Drawing.Color.Empty;
            stateProperties23.ForeColor = System.Drawing.Color.Empty;
            stateProperties23.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.addRoomName.OnHoverState = stateProperties23;
            stateProperties24.BorderColor = System.Drawing.Color.Silver;
            stateProperties24.FillColor = System.Drawing.Color.White;
            stateProperties24.ForeColor = System.Drawing.Color.Empty;
            stateProperties24.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.addRoomName.OnIdleState = stateProperties24;
            this.addRoomName.Padding = new System.Windows.Forms.Padding(3);
            this.addRoomName.PasswordChar = '\0';
            this.addRoomName.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.addRoomName.PlaceholderText = "Enter text";
            this.addRoomName.ReadOnly = false;
            this.addRoomName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.addRoomName.SelectedText = "";
            this.addRoomName.SelectionLength = 0;
            this.addRoomName.SelectionStart = 0;
            this.addRoomName.ShortcutsEnabled = true;
            this.addRoomName.Size = new System.Drawing.Size(510, 45);
            this.addRoomName.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.addRoomName.TabIndex = 22;
            this.addRoomName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.addRoomName.TextMarginBottom = 0;
            this.addRoomName.TextMarginLeft = 3;
            this.addRoomName.TextMarginTop = 0;
            this.addRoomName.TextPlaceholder = "Enter text";
            this.addRoomName.UseSystemPasswordChar = false;
            this.addRoomName.WordWrap = true;
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
        private Bunifu.UI.WinForms.BunifuTextBox addCapacity;
        private Bunifu.UI.WinForms.BunifuTextBox addRoomName;
        private System.Windows.Forms.Button addbtn;
        private Bunifu.UI.WinForms.BunifuDropdown bNameDropdown;
        private TLMDataSet tLMDataSet;
        private System.Windows.Forms.BindingSource locationTBBindingSource;
        private TLMDataSetTableAdapters.locationTBTableAdapter locationTBTableAdapter;
        private System.Windows.Forms.Panel panel1;
    }
}