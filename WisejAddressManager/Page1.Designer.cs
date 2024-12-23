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
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle3 = new Wisej.Web.DataGridViewCellStyle();
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle4 = new Wisej.Web.DataGridViewCellStyle();
            this.OrganizationTable = new Wisej.Web.DataGridView();
            this.OIdCol = new Wisej.Web.DataGridViewTextBoxColumn();
            this.ONameCol = new Wisej.Web.DataGridViewTextBoxColumn();
            this.OStreetCol = new Wisej.Web.DataGridViewTextBoxColumn();
            this.OZipCol = new Wisej.Web.DataGridViewTextBoxColumn();
            this.OCityCol = new Wisej.Web.DataGridViewTextBoxColumn();
            this.OCountryCol = new Wisej.Web.DataGridViewTextBoxColumn();
            this.AddOrgButton = new Wisej.Web.Button();
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
            this.EmployeePanel = new Wisej.Web.Panel();
            this.OrganizationPanel = new Wisej.Web.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.OrganizationTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeTable)).BeginInit();
            this.EmployeePanel.SuspendLayout();
            this.OrganizationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrganizationTable
            // 
            this.OrganizationTable.AutoSize = true;
            this.OrganizationTable.AutoSizeColumnsMode = Wisej.Web.DataGridViewAutoSizeColumnsMode.AllCells;
            this.OrganizationTable.BackColor = System.Drawing.Color.FromName("@window");
            dataGridViewCellStyle3.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleLeft;
            this.OrganizationTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
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
            dataGridViewCellStyle4.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleLeft;
            this.EmployeeTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
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
            // EmployeePanel
            // 
            this.EmployeePanel.AutoScroll = true;
            this.EmployeePanel.AutoSize = true;
            this.EmployeePanel.Controls.Add(this.OrganizationTableButton);
            this.EmployeePanel.Controls.Add(this.AddEmployeeButton);
            this.EmployeePanel.Controls.Add(this.DeleteEmployeeButton);
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
            this.Size = new System.Drawing.Size(873, 827);
            this.Load += new System.EventHandler(this.Page1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrganizationTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeTable)).EndInit();
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
        private Wisej.Web.Panel EmployeePanel;
        private Wisej.Web.Panel OrganizationPanel;
    }
}

