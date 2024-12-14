namespace WisejAddressManager
{
    partial class Page1
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

        #region Wisej.NET Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle1 = new Wisej.Web.DataGridViewCellStyle();
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle2 = new Wisej.Web.DataGridViewCellStyle();
            this.OrganizationTable = new Wisej.Web.DataGridView();
            this.OIdCol = new Wisej.Web.DataGridViewTextBoxColumn();
            this.ONameCol = new Wisej.Web.DataGridViewTextBoxColumn();
            this.OStreetCol = new Wisej.Web.DataGridViewTextBoxColumn();
            this.OZipCol = new Wisej.Web.DataGridViewTextBoxColumn();
            this.OCityCol = new Wisej.Web.DataGridViewTextBoxColumn();
            this.OCountryCol = new Wisej.Web.DataGridViewTextBoxColumn();
            this.AddOrgButton = new Wisej.Web.Button();
            this.AddOrgForm = new Wisej.Web.GroupBox();
            this.OrgInvalidLabel = new Wisej.Web.Label();
            this.OrgConfirm = new Wisej.Web.Button();
            this.OrgCancel = new Wisej.Web.Button();
            this.NameBox = new Wisej.Web.TextBox();
            this.StreetBox = new Wisej.Web.TextBox();
            this.ZipBox = new Wisej.Web.TextBox();
            this.CityBox = new Wisej.Web.TextBox();
            this.CountryBox = new Wisej.Web.TextBox();
            this.EmployeeTableButton = new Wisej.Web.Button();
            this.DeleteOrgButton = new Wisej.Web.Button();
            this.EmployeeTable = new Wisej.Web.DataGridView();
            this.EIdCol = new Wisej.Web.DataGridViewTextBoxColumn();
            this.ETitleCol = new Wisej.Web.DataGridViewTextBoxColumn();
            this.EFirstNameCol = new Wisej.Web.DataGridViewTextBoxColumn();
            this.ELastNameCol = new Wisej.Web.DataGridViewTextBoxColumn();
            this.EPhoneNumberCol = new Wisej.Web.DataGridViewTextBoxColumn();
            this.EEmailCol = new Wisej.Web.DataGridViewTextBoxColumn();
            this.EOrgIdCol = new Wisej.Web.DataGridViewTextBoxColumn();
            this.AddEmployeeButton = new Wisej.Web.Button();
            this.DeleteEmployeeButton = new Wisej.Web.Button();
            this.OrganizationTableButton = new Wisej.Web.Button();
            this.AddEmployeeForm = new Wisej.Web.GroupBox();
            this.EmployeeInvalidLabel = new Wisej.Web.Label();
            this.EmployeeConfirm = new Wisej.Web.Button();
            this.EmployeeCancel = new Wisej.Web.Button();
            this.TitleBox = new Wisej.Web.TextBox();
            this.FirstNameBox = new Wisej.Web.TextBox();
            this.LastNameBox = new Wisej.Web.TextBox();
            this.PhoneNumberBox = new Wisej.Web.TextBox();
            this.EmailBox = new Wisej.Web.TextBox();
            this.EmployeePanel = new Wisej.Web.Panel();
            this.OrganizationPanel = new Wisej.Web.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.OrganizationTable)).BeginInit();
            this.AddOrgForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeTable)).BeginInit();
            this.AddEmployeeForm.SuspendLayout();
            this.EmployeePanel.SuspendLayout();
            this.OrganizationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrganizationTable
            // 
            this.OrganizationTable.AutoSize = true;
            this.OrganizationTable.AutoSizeColumnsMode = Wisej.Web.DataGridViewAutoSizeColumnsMode.AllCells;
            this.OrganizationTable.BackColor = System.Drawing.Color.FromName("@window");
            dataGridViewCellStyle1.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleLeft;
            this.OrganizationTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.OrganizationTable.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.OIdCol,
            this.ONameCol,
            this.OStreetCol,
            this.OZipCol,
            this.OCityCol,
            this.OCountryCol});
            this.OrganizationTable.Location = new System.Drawing.Point(0, 45);
            this.OrganizationTable.MinimumSize = new System.Drawing.Size(750, 0);
            this.OrganizationTable.MultiSelect = false;
            this.OrganizationTable.Name = "OrganizationTable";
            this.OrganizationTable.ShowColumnVisibilityMenu = false;
            this.OrganizationTable.Size = new System.Drawing.Size(750, 36);
            this.OrganizationTable.TabIndex = 0;
            this.OrganizationTable.CellBeginEdit += new Wisej.Web.DataGridViewCellCancelEventHandler(this.OrganizationTable_CellBeginEdit);
            this.OrganizationTable.CellEndEdit += new Wisej.Web.DataGridViewCellEventHandler(this.OrganizationTable_CellEndEdit);
            // 
            // OIdCol
            // 
            this.OIdCol.DataPropertyName = "Id";
            this.OIdCol.HeaderText = "#";
            this.OIdCol.Name = "OIdCol";
            this.OIdCol.ReadOnly = true;
            this.OIdCol.Visible = false;
            this.OIdCol.Width = 40;
            // 
            // ONameCol
            // 
            this.ONameCol.DataPropertyName = "Name";
            this.ONameCol.HeaderText = "Name";
            this.ONameCol.Name = "ONameCol";
            // 
            // OStreetCol
            // 
            this.OStreetCol.DataPropertyName = "Street";
            this.OStreetCol.HeaderText = "Street";
            this.OStreetCol.Name = "OStreetCol";
            // 
            // OZipCol
            // 
            this.OZipCol.DataPropertyName = "Zip";
            this.OZipCol.HeaderText = "Zip";
            this.OZipCol.Name = "OZipCol";
            // 
            // OCityCol
            // 
            this.OCityCol.DataPropertyName = "City";
            this.OCityCol.HeaderText = "City";
            this.OCityCol.Name = "OCityCol";
            // 
            // OCountryCol
            // 
            this.OCountryCol.DataPropertyName = "Country";
            this.OCountryCol.HeaderText = "Country";
            this.OCountryCol.Name = "OCountryCol";
            // 
            // AddOrgButton
            // 
            this.AddOrgButton.AutoSize = true;
            this.AddOrgButton.BackColor = System.Drawing.Color.LightGreen;
            this.AddOrgButton.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.AddOrgButton.Location = new System.Drawing.Point(0, 0);
            this.AddOrgButton.Name = "AddOrgButton";
            this.AddOrgButton.Size = new System.Drawing.Size(150, 40);
            this.AddOrgButton.TabIndex = 2;
            this.AddOrgButton.Text = "Add Organization";
            this.AddOrgButton.Click += new System.EventHandler(this.AddOrgButton_Click);
            // 
            // AddOrgForm
            // 
            this.AddOrgForm.BackColor = System.Drawing.Color.FromName("@table-row-background-focused");
            this.AddOrgForm.Controls.Add(this.OrgInvalidLabel);
            this.AddOrgForm.Controls.Add(this.OrgConfirm);
            this.AddOrgForm.Controls.Add(this.OrgCancel);
            this.AddOrgForm.Controls.Add(this.NameBox);
            this.AddOrgForm.Controls.Add(this.StreetBox);
            this.AddOrgForm.Controls.Add(this.ZipBox);
            this.AddOrgForm.Controls.Add(this.CityBox);
            this.AddOrgForm.Controls.Add(this.CountryBox);
            this.AddOrgForm.Location = new System.Drawing.Point(200, 90);
            this.AddOrgForm.Name = "AddOrgForm";
            this.AddOrgForm.Size = new System.Drawing.Size(420, 250);
            this.AddOrgForm.TabIndex = 3;
            this.AddOrgForm.Text = "Add Organization";
            this.AddOrgForm.Visible = false;
            this.AddOrgForm.ResponsiveProfileChanged += new Wisej.Web.ResponsiveProfileChangedEventHandler(this.RelocateControlToCenter);
            // 
            // OrgInvalidLabel
            // 
            this.OrgInvalidLabel.AutoSize = true;
            this.OrgInvalidLabel.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.OrgInvalidLabel.ForeColor = System.Drawing.Color.FromName("@danger");
            this.OrgInvalidLabel.Location = new System.Drawing.Point(6, 211);
            this.OrgInvalidLabel.Name = "OrgInvalidLabel";
            this.OrgInvalidLabel.Size = new System.Drawing.Size(150, 18);
            this.OrgInvalidLabel.TabIndex = 6;
            this.OrgInvalidLabel.Text = "All Fields Must Be Filled";
            this.OrgInvalidLabel.Visible = false;
            // 
            // OrgConfirm
            // 
            this.OrgConfirm.BackColor = System.Drawing.Color.LightGreen;
            this.OrgConfirm.Location = new System.Drawing.Point(183, 202);
            this.OrgConfirm.Name = "OrgConfirm";
            this.OrgConfirm.Size = new System.Drawing.Size(125, 40);
            this.OrgConfirm.TabIndex = 5;
            this.OrgConfirm.Text = "Add Organization";
            this.OrgConfirm.Click += new System.EventHandler(this.OrgConfirm_Click);
            // 
            // OrgCancel
            // 
            this.OrgCancel.BackColor = System.Drawing.Color.LightCoral;
            this.OrgCancel.Location = new System.Drawing.Point(320, 202);
            this.OrgCancel.Name = "OrgCancel";
            this.OrgCancel.Size = new System.Drawing.Size(100, 40);
            this.OrgCancel.TabIndex = 4;
            this.OrgCancel.Text = "Cancel";
            this.OrgCancel.Click += new System.EventHandler(this.OrgCancel_Click);
            // 
            // NameBox
            // 
            this.NameBox.AutoSize = false;
            this.NameBox.Label.Position = Wisej.Web.LabelPosition.Inside;
            this.NameBox.LabelText = "Organization Name";
            this.NameBox.Location = new System.Drawing.Point(6, 21);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(408, 30);
            this.NameBox.TabIndex = 0;
            // 
            // StreetBox
            // 
            this.StreetBox.AutoSize = false;
            this.StreetBox.Label.Position = Wisej.Web.LabelPosition.Inside;
            this.StreetBox.LabelText = "Street Address";
            this.StreetBox.Location = new System.Drawing.Point(6, 57);
            this.StreetBox.Name = "StreetBox";
            this.StreetBox.Size = new System.Drawing.Size(408, 30);
            this.StreetBox.TabIndex = 1;
            // 
            // ZipBox
            // 
            this.ZipBox.AutoSize = false;
            this.ZipBox.Label.Position = Wisej.Web.LabelPosition.Inside;
            this.ZipBox.LabelText = "Zip Code";
            this.ZipBox.Location = new System.Drawing.Point(6, 93);
            this.ZipBox.Name = "ZipBox";
            this.ZipBox.Size = new System.Drawing.Size(408, 30);
            this.ZipBox.TabIndex = 2;
            // 
            // CityBox
            // 
            this.CityBox.AutoSize = false;
            this.CityBox.Label.Position = Wisej.Web.LabelPosition.Inside;
            this.CityBox.LabelText = "City";
            this.CityBox.Location = new System.Drawing.Point(6, 129);
            this.CityBox.Name = "CityBox";
            this.CityBox.Size = new System.Drawing.Size(408, 30);
            this.CityBox.TabIndex = 3;
            // 
            // CountryBox
            // 
            this.CountryBox.AutoSize = false;
            this.CountryBox.Label.Position = Wisej.Web.LabelPosition.Inside;
            this.CountryBox.LabelText = "Country";
            this.CountryBox.Location = new System.Drawing.Point(6, 166);
            this.CountryBox.Name = "CountryBox";
            this.CountryBox.Size = new System.Drawing.Size(408, 30);
            this.CountryBox.TabIndex = 4;
            // 
            // EmployeeTableButton
            // 
            this.EmployeeTableButton.BackColor = System.Drawing.Color.LightCyan;
            this.EmployeeTableButton.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.EmployeeTableButton.Location = new System.Drawing.Point(480, 0);
            this.EmployeeTableButton.Name = "EmployeeTableButton";
            this.EmployeeTableButton.Size = new System.Drawing.Size(270, 40);
            this.EmployeeTableButton.TabIndex = 4;
            this.EmployeeTableButton.Text = "Show Employees of Selected Organization";
            this.EmployeeTableButton.Click += new System.EventHandler(this.EmployeeTableButton_Click);
            // 
            // DeleteOrgButton
            // 
            this.DeleteOrgButton.BackColor = System.Drawing.Color.LightCoral;
            this.DeleteOrgButton.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.DeleteOrgButton.Location = new System.Drawing.Point(170, 0);
            this.DeleteOrgButton.Name = "DeleteOrgButton";
            this.DeleteOrgButton.Size = new System.Drawing.Size(200, 40);
            this.DeleteOrgButton.TabIndex = 5;
            this.DeleteOrgButton.Text = "Delete Selected Organization";
            this.DeleteOrgButton.Click += new System.EventHandler(this.DeleteOrgButton_Click);
            // 
            // EmployeeTable
            // 
            this.EmployeeTable.AutoSize = true;
            this.EmployeeTable.AutoSizeColumnsMode = Wisej.Web.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle2.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleLeft;
            this.EmployeeTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.EmployeeTable.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.EIdCol,
            this.ETitleCol,
            this.EFirstNameCol,
            this.ELastNameCol,
            this.EPhoneNumberCol,
            this.EEmailCol,
            this.EOrgIdCol});
            this.EmployeeTable.Location = new System.Drawing.Point(0, 45);
            this.EmployeeTable.MinimumSize = new System.Drawing.Size(750, 0);
            this.EmployeeTable.Name = "EmployeeTable";
            this.EmployeeTable.ShowColumnVisibilityMenu = false;
            this.EmployeeTable.Size = new System.Drawing.Size(750, 36);
            this.EmployeeTable.TabIndex = 6;
            this.EmployeeTable.CellBeginEdit += new Wisej.Web.DataGridViewCellCancelEventHandler(this.EmployeeTable_CellBeginEdit);
            this.EmployeeTable.CellEndEdit += new Wisej.Web.DataGridViewCellEventHandler(this.EmployeeTable_CellEndEdit);
            // 
            // EIdCol
            // 
            this.EIdCol.DataPropertyName = "Id";
            this.EIdCol.HeaderText = "Id";
            this.EIdCol.Name = "EIdCol";
            this.EIdCol.Visible = false;
            this.EIdCol.Width = 150;
            // 
            // ETitleCol
            // 
            this.ETitleCol.DataPropertyName = "Title";
            this.ETitleCol.HeaderText = "Title";
            this.ETitleCol.Name = "ETitleCol";
            // 
            // EFirstNameCol
            // 
            this.EFirstNameCol.DataPropertyName = "FirstName";
            this.EFirstNameCol.HeaderText = "First Name";
            this.EFirstNameCol.Name = "EFirstNameCol";
            // 
            // ELastNameCol
            // 
            this.ELastNameCol.DataPropertyName = "LastName";
            this.ELastNameCol.HeaderText = "Last Name";
            this.ELastNameCol.Name = "ELastNameCol";
            // 
            // EPhoneNumberCol
            // 
            this.EPhoneNumberCol.DataPropertyName = "PhoneNumber";
            this.EPhoneNumberCol.HeaderText = "Phone Number";
            this.EPhoneNumberCol.Name = "EPhoneNumberCol";
            this.EPhoneNumberCol.Width = 200;
            // 
            // EEmailCol
            // 
            this.EEmailCol.DataPropertyName = "Email";
            this.EEmailCol.HeaderText = "Email";
            this.EEmailCol.Name = "EEmailCol";
            this.EEmailCol.Width = 200;
            // 
            // EOrgIdCol
            // 
            this.EOrgIdCol.DataPropertyName = "OrganizationId";
            this.EOrgIdCol.HeaderText = "Organization Id";
            this.EOrgIdCol.Name = "EOrgIdCol";
            this.EOrgIdCol.Visible = false;
            // 
            // AddEmployeeButton
            // 
            this.AddEmployeeButton.BackColor = System.Drawing.Color.LightGreen;
            this.AddEmployeeButton.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.AddEmployeeButton.Location = new System.Drawing.Point(0, 0);
            this.AddEmployeeButton.Name = "AddEmployeeButton";
            this.AddEmployeeButton.Size = new System.Drawing.Size(150, 40);
            this.AddEmployeeButton.TabIndex = 7;
            this.AddEmployeeButton.Text = "Add Employee";
            this.AddEmployeeButton.Click += new System.EventHandler(this.AddEmployeeButton_Click);
            // 
            // DeleteEmployeeButton
            // 
            this.DeleteEmployeeButton.BackColor = System.Drawing.Color.LightCoral;
            this.DeleteEmployeeButton.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.DeleteEmployeeButton.Location = new System.Drawing.Point(170, 0);
            this.DeleteEmployeeButton.Name = "DeleteEmployeeButton";
            this.DeleteEmployeeButton.Size = new System.Drawing.Size(200, 40);
            this.DeleteEmployeeButton.TabIndex = 8;
            this.DeleteEmployeeButton.Text = "Delete Selected Employees";
            this.DeleteEmployeeButton.Click += new System.EventHandler(this.DeleteEmployeeButton_Click);
            // 
            // OrganizationTableButton
            // 
            this.OrganizationTableButton.BackColor = System.Drawing.Color.LightCyan;
            this.OrganizationTableButton.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.OrganizationTableButton.Location = new System.Drawing.Point(480, 0);
            this.OrganizationTableButton.Name = "OrganizationTableButton";
            this.OrganizationTableButton.Size = new System.Drawing.Size(270, 40);
            this.OrganizationTableButton.TabIndex = 9;
            this.OrganizationTableButton.Text = "Show Organizations";
            this.OrganizationTableButton.Click += new System.EventHandler(this.OrganizationTableButton_Click);
            // 
            // AddEmployeeForm
            // 
            this.AddEmployeeForm.BackColor = System.Drawing.Color.FromName("@table-row-background-focused");
            this.AddEmployeeForm.Controls.Add(this.EmployeeInvalidLabel);
            this.AddEmployeeForm.Controls.Add(this.EmployeeConfirm);
            this.AddEmployeeForm.Controls.Add(this.EmployeeCancel);
            this.AddEmployeeForm.Controls.Add(this.TitleBox);
            this.AddEmployeeForm.Controls.Add(this.FirstNameBox);
            this.AddEmployeeForm.Controls.Add(this.LastNameBox);
            this.AddEmployeeForm.Controls.Add(this.PhoneNumberBox);
            this.AddEmployeeForm.Controls.Add(this.EmailBox);
            this.AddEmployeeForm.Location = new System.Drawing.Point(200, 90);
            this.AddEmployeeForm.Name = "AddEmployeeForm";
            this.AddEmployeeForm.Size = new System.Drawing.Size(420, 250);
            this.AddEmployeeForm.TabIndex = 10;
            this.AddEmployeeForm.Text = "Add Employee";
            this.AddEmployeeForm.Visible = false;
            this.AddEmployeeForm.ResponsiveProfileChanged += new Wisej.Web.ResponsiveProfileChangedEventHandler(this.RelocateControlToCenter);
            // 
            // EmployeeInvalidLabel
            // 
            this.EmployeeInvalidLabel.AutoSize = true;
            this.EmployeeInvalidLabel.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.EmployeeInvalidLabel.ForeColor = System.Drawing.Color.FromName("@danger");
            this.EmployeeInvalidLabel.Location = new System.Drawing.Point(20, 211);
            this.EmployeeInvalidLabel.Name = "EmployeeInvalidLabel";
            this.EmployeeInvalidLabel.Size = new System.Drawing.Size(150, 18);
            this.EmployeeInvalidLabel.TabIndex = 6;
            this.EmployeeInvalidLabel.Text = "All Fields Must Be Filled";
            this.EmployeeInvalidLabel.Visible = false;
            // 
            // EmployeeConfirm
            // 
            this.EmployeeConfirm.BackColor = System.Drawing.Color.LightGreen;
            this.EmployeeConfirm.Location = new System.Drawing.Point(183, 202);
            this.EmployeeConfirm.Name = "EmployeeConfirm";
            this.EmployeeConfirm.Size = new System.Drawing.Size(125, 40);
            this.EmployeeConfirm.TabIndex = 5;
            this.EmployeeConfirm.Text = "Add Employee";
            this.EmployeeConfirm.Click += new System.EventHandler(this.EmployeeConfirm_Click);
            // 
            // EmployeeCancel
            // 
            this.EmployeeCancel.BackColor = System.Drawing.Color.LightCoral;
            this.EmployeeCancel.Location = new System.Drawing.Point(314, 202);
            this.EmployeeCancel.Name = "EmployeeCancel";
            this.EmployeeCancel.Size = new System.Drawing.Size(100, 40);
            this.EmployeeCancel.TabIndex = 4;
            this.EmployeeCancel.Text = "Cancel";
            this.EmployeeCancel.Click += new System.EventHandler(this.EmployeeCancel_Click);
            // 
            // TitleBox
            // 
            this.TitleBox.AutoSize = false;
            this.TitleBox.Label.Position = Wisej.Web.LabelPosition.Inside;
            this.TitleBox.LabelText = "Title";
            this.TitleBox.Location = new System.Drawing.Point(6, 21);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(408, 30);
            this.TitleBox.TabIndex = 0;
            // 
            // FirstNameBox
            // 
            this.FirstNameBox.AutoSize = false;
            this.FirstNameBox.Label.Position = Wisej.Web.LabelPosition.Inside;
            this.FirstNameBox.LabelText = "First Name";
            this.FirstNameBox.Location = new System.Drawing.Point(6, 57);
            this.FirstNameBox.Name = "FirstNameBox";
            this.FirstNameBox.Size = new System.Drawing.Size(408, 30);
            this.FirstNameBox.TabIndex = 1;
            // 
            // LastNameBox
            // 
            this.LastNameBox.AutoSize = false;
            this.LastNameBox.Label.Position = Wisej.Web.LabelPosition.Inside;
            this.LastNameBox.LabelText = "Last Name";
            this.LastNameBox.Location = new System.Drawing.Point(6, 93);
            this.LastNameBox.Name = "LastNameBox";
            this.LastNameBox.Size = new System.Drawing.Size(408, 30);
            this.LastNameBox.TabIndex = 2;
            // 
            // PhoneNumberBox
            // 
            this.PhoneNumberBox.AutoSize = false;
            this.PhoneNumberBox.Label.Position = Wisej.Web.LabelPosition.Inside;
            this.PhoneNumberBox.LabelText = "Phone Number";
            this.PhoneNumberBox.Location = new System.Drawing.Point(6, 129);
            this.PhoneNumberBox.Name = "PhoneNumberBox";
            this.PhoneNumberBox.Size = new System.Drawing.Size(408, 30);
            this.PhoneNumberBox.TabIndex = 3;
            // 
            // EmailBox
            // 
            this.EmailBox.AutoSize = false;
            this.EmailBox.Label.Position = Wisej.Web.LabelPosition.Inside;
            this.EmailBox.LabelText = "Email";
            this.EmailBox.Location = new System.Drawing.Point(6, 166);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(408, 30);
            this.EmailBox.TabIndex = 4;
            // 
            // EmployeePanel
            // 
            this.EmployeePanel.AutoScroll = true;
            this.EmployeePanel.AutoSize = true;
            this.EmployeePanel.Controls.Add(this.OrganizationTableButton);
            this.EmployeePanel.Controls.Add(this.AddEmployeeButton);
            this.EmployeePanel.Controls.Add(this.DeleteEmployeeButton);
            this.EmployeePanel.Controls.Add(this.AddEmployeeForm);
            this.EmployeePanel.Controls.Add(this.EmployeeTable);
            this.EmployeePanel.Location = new System.Drawing.Point(150, 50);
            this.EmployeePanel.Name = "EmployeePanel";
            this.EmployeePanel.ShowCloseButton = false;
            this.EmployeePanel.Size = new System.Drawing.Size(753, 835);
            this.EmployeePanel.TabIndex = 11;
            this.EmployeePanel.ResponsiveProfileChanged += new Wisej.Web.ResponsiveProfileChangedEventHandler(this.RelocateControlToCenter);
            // 
            // OrganizationPanel
            // 
            this.OrganizationPanel.AutoScroll = true;
            this.OrganizationPanel.AutoSize = true;
            this.OrganizationPanel.Controls.Add(this.AddOrgButton);
            this.OrganizationPanel.Controls.Add(this.DeleteOrgButton);
            this.OrganizationPanel.Controls.Add(this.EmployeeTableButton);
            this.OrganizationPanel.Controls.Add(this.AddOrgForm);
            this.OrganizationPanel.Controls.Add(this.OrganizationTable);
            this.OrganizationPanel.Location = new System.Drawing.Point(150, 50);
            this.OrganizationPanel.Name = "OrganizationPanel";
            this.OrganizationPanel.Size = new System.Drawing.Size(753, 835);
            this.OrganizationPanel.TabIndex = 12;
            this.OrganizationPanel.ResponsiveProfileChanged += new Wisej.Web.ResponsiveProfileChangedEventHandler(this.RelocateControlToCenter);
            // 
            // Page1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromName("@window");
            this.Controls.Add(this.EmployeePanel);
            this.Controls.Add(this.OrganizationPanel);
            this.Name = "Page1";
            this.Size = new System.Drawing.Size(907, 861);
            this.Load += new System.EventHandler(this.Page1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrganizationTable)).EndInit();
            this.AddOrgForm.ResumeLayout(false);
            this.AddOrgForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeTable)).EndInit();
            this.AddEmployeeForm.ResumeLayout(false);
            this.AddEmployeeForm.PerformLayout();
            this.EmployeePanel.ResumeLayout(false);
            this.EmployeePanel.PerformLayout();
            this.OrganizationPanel.ResumeLayout(false);
            this.OrganizationPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Wisej.Web.DataGridViewTextBoxColumn ONameCol;
        private Wisej.Web.DataGridViewTextBoxColumn OStreetCol;
        private Wisej.Web.DataGridViewTextBoxColumn OZipCol;
        private Wisej.Web.DataGridViewTextBoxColumn OCityCol;
        private Wisej.Web.DataGridViewTextBoxColumn OCountryCol;
        private Wisej.Web.DataGridView OrganizationTable;
        private Wisej.Web.DataGridViewTextBoxColumn OIdCol;
        private Wisej.Web.Button AddOrgButton;
        private Wisej.Web.GroupBox AddOrgForm;
        private Wisej.Web.TextBox CountryBox;
        private Wisej.Web.TextBox CityBox;
        private Wisej.Web.TextBox ZipBox;
        private Wisej.Web.TextBox StreetBox;
        private Wisej.Web.TextBox NameBox;
        private Wisej.Web.Button OrgCancel;
        private Wisej.Web.Button OrgConfirm;
        private Wisej.Web.Label OrgInvalidLabel;
        private Wisej.Web.Button EmployeeTableButton;
        private Wisej.Web.Button DeleteOrgButton;
        private Wisej.Web.DataGridView EmployeeTable;
        private Wisej.Web.DataGridViewTextBoxColumn EIdCol;
        private Wisej.Web.DataGridViewTextBoxColumn ETitleCol;
        private Wisej.Web.DataGridViewTextBoxColumn EFirstNameCol;
        private Wisej.Web.DataGridViewTextBoxColumn ELastNameCol;
        private Wisej.Web.DataGridViewTextBoxColumn EPhoneNumberCol;
        private Wisej.Web.DataGridViewTextBoxColumn EEmailCol;
        private Wisej.Web.DataGridViewTextBoxColumn EOrgIdCol;
        private Wisej.Web.Button AddEmployeeButton;
        private Wisej.Web.Button DeleteEmployeeButton;
        private Wisej.Web.Button OrganizationTableButton;
        private Wisej.Web.GroupBox AddEmployeeForm;
        private Wisej.Web.Label EmployeeInvalidLabel;
        private Wisej.Web.Button EmployeeConfirm;
        private Wisej.Web.Button EmployeeCancel;
        private Wisej.Web.TextBox TitleBox;
        private Wisej.Web.TextBox FirstNameBox;
        private Wisej.Web.TextBox LastNameBox;
        private Wisej.Web.TextBox PhoneNumberBox;
        private Wisej.Web.TextBox EmailBox;
        private Wisej.Web.Panel EmployeePanel;
        private Wisej.Web.Panel OrganizationPanel;
    }
}

