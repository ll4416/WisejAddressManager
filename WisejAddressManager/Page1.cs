using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using Wisej.Web;

namespace WisejAddressManager
{
    public partial class Page1 : Page
    {
        // Fields to store an organization cell data
        private object editOrgCellValue = default;
        private int editOrgCellId = default;
        private string editOrgCellCol = default;

        // Currently selected organizaion for the Employee Table
        private int currentOrgId = default;
        // Fields to store an employee cell data
        private object editEmployeeCellValue = default;
        private int editEmployeeCellId = default;
        private string editEmployeeCellCol = default;

        public Page1()
        {
            InitializeComponent();
        }

        private void Page1_Load(object sender, System.EventArgs e)
        {
            RelocateControlToCenter(OrganizationPanel);
            RelocateControlToCenter(EmployeePanel);
            RelocateControlToCenter(AddEmployeeForm);
            RelocateControlToCenter(AddOrgForm);

            AddOrgForm.Visible = false;
            OrgInvalidLabel.Visible = false;

            AddEmployeeForm.Visible = false;
            EmployeeInvalidLabel.Visible = false;

            EmployeePanel.Visible = false;

            UpdateOrgGrid();
        }

        // Organization Table Editing
        /// <summary>
        /// Saves current cell data in the case of invalid input
        /// </summary>
        private void OrganizationTable_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            editOrgCellId = (int)(OrganizationTable.Rows[e.RowIndex]["OIdCol"].Value);
            editOrgCellCol = OrganizationTable.Columns[e.ColumnIndex].Name;
            editOrgCellValue = OrganizationTable.Rows[e.RowIndex][editOrgCellCol].Value;
        }
        /// <summary>
        /// Verifies the incoming change and applies it to the database if valid
        /// If the new data is not valid, the cell will be reverted to its original data
        /// and the user will be informed that the data is invalid.
        /// </summary>
        private void OrganizationTable_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var insertedData = OrganizationTable.Rows[e.RowIndex][e.ColumnIndex].Value;

            if (insertedData is null || insertedData.ToString() == string.Empty)
            {
                OrganizationTable.Rows[e.RowIndex][editOrgCellCol].Value = editOrgCellValue;
                MessageBox.Show("Cell can't be blank.",
                                "Invalid Data",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button1,
                                true);
                return;
            }

            string sql = "UPDATE \"Organizations\" SET @Column = @Data WHERE Id = @Id";
            sql = sql.Replace("@Column", OrganizationTable.Columns[editOrgCellCol].DataPropertyName);

            using (SQLiteCommand command = DB.GetCommand(sql))
            {
                command.Parameters.AddWithValue("@Id", editOrgCellId);
                command.Parameters.AddWithValue("@Data", CleanInput(insertedData.ToString()));

                command.ExecuteNonQuery();
            }
            editOrgCellId = default;
            editOrgCellCol = default;
            editOrgCellValue = default;
        }

        // Organization View Buttons
        /// <summary>
        /// Opens the Add Organization Form
        /// </summary>
        private void AddOrgButton_Click(object sender, EventArgs e)
        {
            OpenAddOrgForm();
        }
        /// <summary>
        /// Checks if the deletion action is valid. If valid, the user will be warned.
        /// The user can back out of the deletion and nothing will change. If deletion is completed,
        /// the selected organizaion and its employees will be deleted.
        /// </summary>
        private void DeleteOrgButton_Click(object sender, EventArgs e)
        {
            if (OrganizationTable.Rows.Count == 0)
            {
                MessageBox.Show("No organizations to select from. Please add an organization.",
                                "Invalid Data",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button1,
                                true);
                return;
            }

            if (OrganizationTable.SelectedRows.Count == 0)
            {
                MessageBox.Show("An organization must be selected for deleteion.",
                                "Invalid Data",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button1,
                                true);
                return;
            }

            if (MessageBox.Show("This will permanently delete the organization and all " +
                "associated employees. Are you sure?",
                "",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2,
                true) == DialogResult.No)
            {
                return;
            }

            int orgIdToDelete = (int)(OrganizationTable.SelectedRows[0]["OIdCol"].Value ?? -1);

            string sql = $"DELETE FROM \"Organizations\" WHERE \"Id\" = {orgIdToDelete}";
            using (SQLiteCommand command = DB.GetCommand(sql)) command.ExecuteNonQuery();

            sql = $"DELETE FROM \"Employees\" WHERE \"OrganizationId\" = {orgIdToDelete}";
            using (SQLiteCommand command = DB.GetCommand(sql)) command.ExecuteNonQuery();

            UpdateOrgGrid();
        }
        /// <summary>
        /// Toggles to the employee table, given that there is a valid organization selected.
        /// </summary>
        private void EmployeeTableButton_Click(object sender, EventArgs e)
        {
            if (OrganizationTable.Rows.Count == 0)
            {
                MessageBox.Show("No organizations to select from. Please add an organization.",
                                "Invalid Data",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button1,
                                true);
                return;
            }

            int selectedOrgId = (int)(OrganizationTable.SelectedRows[0]["OIdCol"].Value ?? -1);

            if (selectedOrgId == -1)
            {
                MessageBox.Show("An organization must be selected to view employees.",
                                "Invalid Data",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button1,
                                true);
                return;
            }
            currentOrgId = selectedOrgId;

            ToggleOrganizationEmployeeView();
        }

        // Add Organization Form
        /// <summary>
        /// Validates incoming data. If data is valid a new organization is added.
        /// </summary>
        private void OrgConfirm_Click(object sender, EventArgs e)
        {
            if (NameBox.Text == string.Empty ||
                StreetBox.Text == string.Empty ||
                ZipBox.Text == string.Empty ||
                CityBox.Text == string.Empty ||
                CountryBox.Text == string.Empty)
            {
                OrgInvalidLabel.Visible = true;
                return;
            }

            string sql = "INSERT INTO \"Organizations\" (Name, Street, Zip, City, Country) " +
                "VALUES (@Name, @Street, @Zip, @City, @Country)";

            using (SQLiteCommand command = DB.GetCommand(sql))
            {
                command.Parameters.AddWithValue("@Name", CleanInput(NameBox.Text));
                command.Parameters.AddWithValue("@Street", CleanInput(StreetBox.Text));
                command.Parameters.AddWithValue("@Zip", CleanInput(ZipBox.Text));
                command.Parameters.AddWithValue("@City", CleanInput(CityBox.Text));
                command.Parameters.AddWithValue("@Country", CleanInput(CountryBox.Text));
                command.ExecuteNonQuery();
            }
            UpdateOrgGrid();
            CloseAddOrgForm();
        }
        /// <summary>
        /// Closes the Add Organizaion Form
        /// </summary>
        private void OrgCancel_Click(object sender, EventArgs e)
        {
            CloseAddOrgForm();
        }

        // Employee Table Editing
        /// <summary>
        /// Saves current cell data in the case of invalid input
        /// </summary>
        private void EmployeeTable_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            editEmployeeCellId = (int)(EmployeeTable.Rows[e.RowIndex]["EIdCol"].Value);
            editEmployeeCellCol = EmployeeTable.Columns[e.ColumnIndex].Name;
            editEmployeeCellValue = EmployeeTable.Rows[e.RowIndex][editEmployeeCellCol].Value;
        }
        /// <summary>
        /// Verifies the incoming change and applies it to the database if valid
        /// If the new data is not valid, the cell will be reverted to its original data
        /// and the user will be informed that the data is invalid.
        /// </summary>
        private void EmployeeTable_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var insertedData = EmployeeTable.Rows[e.RowIndex][e.ColumnIndex].Value;

            if (insertedData is null || insertedData.ToString() == string.Empty)
            {
                EmployeeTable.Rows[e.RowIndex][editOrgCellCol].Value = editEmployeeCellValue;
                MessageBox.Show("Cell can't be blank.",
                                "Invalid Data",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button1,
                                true);
                return;
            }

            string sql = "UPDATE \"Employees\" SET @Column = @Data WHERE Id = @Id";
            sql = sql.Replace("@Column", EmployeeTable.Columns[editEmployeeCellCol].DataPropertyName);

            using (SQLiteCommand command = DB.GetCommand(sql))
            {
                command.Parameters.AddWithValue("@Id", editEmployeeCellId);
                command.Parameters.AddWithValue("@Data", CleanInput(insertedData.ToString()));

                command.ExecuteNonQuery();
            }
            editEmployeeCellId = default;
            editEmployeeCellCol = default;
            editEmployeeCellValue = default;
        }

        // Employee View Buttons
        /// <summary>
        /// Opens the Add Employee Form
        /// </summary>
        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            OpenAddEmployeeForm();
        }
        /// <summary>
        /// Toggles to the Organization table
        /// </summary>
        private void OrganizationTableButton_Click(object sender, EventArgs e)
        {
            ToggleOrganizationEmployeeView();
        }
        /// <summary>
        /// Checks if the deletion action is valid. If valid, the user will be warned.
        /// The user can back out of the deletion and nothing will change. If deletion is completed,
        /// the selected employees will be deleted.
        /// </summary>
        private void DeleteEmployeeButton_Click(object sender, EventArgs e)
        {
            if (EmployeeTable.SelectedRows.Count == 0)
            {
                MessageBox.Show("Atleast one employee must be selected for deleteion.",
                                "Invalid Data",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button1,
                                true);
                return;
            }

            if (MessageBox.Show("This will permanently delete all selected employees. Are you sure?",
                "",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2,
                true) == DialogResult.No)
            {
                return;
            }

            List<int> employeeIdsToDelete = new List<int>();
            foreach (DataGridViewRow row in EmployeeTable.SelectedRows)
            {
                employeeIdsToDelete.Add((int)row["EIdCol"].Value);
            }

            string sql = $"DELETE FROM \"Employees\" WHERE \"Id\" IN (";
            //employeeIdsToDelete.ForEach(id => sql += id);
            foreach (int employeeId in employeeIdsToDelete)
            {
                sql += employeeId + ",";
            }

            sql = $"{sql.Substring(0, sql.Length - 1)})";

            using (SQLiteCommand command = DB.GetCommand(sql)) command.ExecuteNonQuery();

            UpdateEmployeeGrid();
        }

        // Add Employee Form
        /// <summary>
        /// Validates incoming data. If data is valid a new employee is added to the current organization.
        /// </summary>
        private void EmployeeConfirm_Click(object sender, EventArgs e)
        {
            if (TitleBox.Text == string.Empty ||
                FirstNameBox.Text == string.Empty ||
                LastNameBox.Text == string.Empty ||
                PhoneNumberBox.Text == string.Empty ||
                EmailBox.Text == string.Empty)
            {
                EmployeeInvalidLabel.Visible = true;
                return;
            }

            string sql = "INSERT INTO \"Employees\" (Title, FirstName, LastName, PhoneNumber, Email, OrganizationId) " +
                "VALUES (@Title, @FirstName, @LastName, @PhoneNumber, @Email, @OrganizationId)";

            using (SQLiteCommand command = DB.GetCommand(sql))
            {
                command.Parameters.AddWithValue("@Title", CleanInput(TitleBox.Text));
                command.Parameters.AddWithValue("@FirstName", CleanInput(FirstNameBox.Text));
                command.Parameters.AddWithValue("@LastName", CleanInput(LastNameBox.Text));
                command.Parameters.AddWithValue("@PhoneNumber", CleanInput(PhoneNumberBox.Text));
                command.Parameters.AddWithValue("@Email", CleanInput(EmailBox.Text));
                command.Parameters.AddWithValue("@OrganizationId", currentOrgId);
                command.ExecuteNonQuery();
            }
            UpdateEmployeeGrid();
            CloseAddEmployeeForm();
        }
        /// <summary>
        /// Closes the Add Employee Form
        /// </summary>
        private void EmployeeCancel_Click(object sender, EventArgs e)
        {
            CloseAddEmployeeForm();
        }

        // Helper Methods
        private void ToggleOrganizationEmployeeView()
        {
            //AddOrgButton.Visible = !AddOrgButton.Visible;
            //DeleteOrgButton.Visible = !DeleteOrgButton.Visible;
            //EmployeeTableButton.Visible = !EmployeeTableButton.Visible;
            //OrganizationTable.Visible = !OrganizationTable.Visible;

            //AddEmployeeButton.Visible = !AddEmployeeButton.Visible;
            //DeleteEmployeeButton.Visible = !DeleteEmployeeButton.Visible;
            //OrganizationTableButton.Visible = !OrganizationTable.Visible;
            //EmployeeTable.Visible = !EmployeeTable.Visible;

            EmployeePanel.Visible = !EmployeePanel.Visible;
            OrganizationPanel.Visible = !OrganizationPanel.Visible;

            if (OrganizationTable.Visible) UpdateOrgGrid();
            else if (EmployeeTable.Visible) UpdateEmployeeGrid();
        }
        private void UpdateOrgGrid()
        {
            using (var conn = DB.GetConnection())
            {
                var orgs = conn.Query<OragnizationModel>("SELECT * FROM \"Organizations\"");
                OrganizationTable.DataSource = orgs;
            }
        }
        private void UpdateEmployeeGrid()
        {
            using (var conn = DB.GetConnection())
            {
                var employees = conn.Query<EmployeeModel>(
                    $"SELECT * FROM \"Employees\" WHERE \"OrganizationId\" = {currentOrgId}");
                EmployeeTable.DataSource = employees;
            }
        }
        private void OpenAddOrgForm()
        {
            EmployeeTableButton.Enabled = false;
            DeleteOrgButton.Enabled = false;
            AddOrgButton.Enabled = false;
            OrganizationTable.Enabled = false;

            AddOrgForm.Visible = true;
        }
        private void CloseAddOrgForm()
        {
            EmployeeTableButton.Enabled = true;
            DeleteOrgButton.Enabled = true;
            AddOrgButton.Enabled = true;
            OrganizationTable.Enabled = true;

            OrgInvalidLabel.Visible = false;
            AddOrgForm.Visible = false;

            NameBox.Text = string.Empty;
            StreetBox.Text = string.Empty;
            ZipBox.Text = string.Empty;
            CityBox.Text = string.Empty;
            CountryBox.Text = string.Empty;
        }
        private void OpenAddEmployeeForm()
        {
            OrganizationTableButton.Enabled = false;
            DeleteEmployeeButton.Enabled = false;
            AddEmployeeButton.Enabled = false;
            EmployeeTable.Enabled = false;

            AddEmployeeForm.Visible = true;
        }
        private void CloseAddEmployeeForm()
        {
            OrganizationTableButton.Enabled = true;
            DeleteEmployeeButton.Enabled = true;
            AddEmployeeButton.Enabled = true;
            EmployeeTable.Enabled = true;

            EmployeeInvalidLabel.Visible = false;
            AddEmployeeForm.Visible = false;

            TitleBox.Text = string.Empty;
            FirstNameBox.Text = string.Empty;
            LastNameBox.Text = string.Empty;
            PhoneNumberBox.Text = string.Empty;
            EmailBox.Text = string.Empty;
        }
        /// <summary>
        /// Cleans a string for input into a SQLite database
        /// </summary>
        /// <param name="input">String to be cleaned</param>
        /// <returns>Cleaned input</returns>
        private static string CleanInput(string input)
        {
            string cleanedStr = input;
            cleanedStr = cleanedStr.Trim();

            return cleanedStr;
        }
        /// <summary>
        /// Moves Control to the center of its parent
        /// </summary>
        /// <param name="sender">Control to move</param>
        private void RelocateControlToCenter(object sender, ResponsiveProfileChangedEventArgs e)
        {
            RelocateControlToCenter(sender as Control);
        }
        /// <summary>
        /// Moves Control to the center of its parent
        /// </summary>
        /// <param name="controlToMove">Control to move</param>
        private static void RelocateControlToCenter(Control controlToMove)
        {
            controlToMove.Location = new Point(
                controlToMove.Parent.Width / 2 - controlToMove.Size.Width / 2,
                controlToMove.Parent.Height / 2 - controlToMove.Size.Height / 2);
            controlToMove.Anchor = AnchorStyles.None;
        }
    }
}