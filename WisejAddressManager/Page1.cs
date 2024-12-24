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
        // Layout Contants
        private const int PANEL_TOP_MARGIN = 50;
        private const int LONG_SHORT_THRESHOLD = 940;
        private const float LONG_MAX_PANEL_VW = 70;
        private const float SHORT_MAX_PANEL_VW = 85;

        private const int LONG_ADD_WIDTH = 150;
        private const int LONG_DELETE_WIDTH = 200;
        private const int LONG_SHOW_WIDTH = 270;
        private const int LONG_BUTTON_MARGIN = 20;

        private const string LONG_EMPLOYEE_ADD = "Add Employee";
        private const string LONG_EMPLOYEE_DELETE = "Delete Selected Employees";
        private const string LONG_SHOW_ORGANIZATION = "Show Organizations";

        private const string LONG_ORGANIZATION_ADD = "Add Organization";
        private const string LONG_ORGANIZATION_DELETE = "Delete Selected Organization";
        private const string LONG_SHOW_EMPLOYEE = "Show Employees of Selected Organization";

        private const int SHORT_ADD_WIDTH = 40;
        private const int SHORT_DELETE_WIDTH = 40;
        private const int SHORT_SHOW_WIDTH = 150;
        private const int SHORT_BUTTON_MARGIN = 10;

        private const string SHORT_EMPLOYEE_ADD = "+";
        private const string SHORT_EMPLOYEE_DELETE = "-";
        private const string SHORT_SHOW_ORGANIZATION = "Organizations";

        private const string SHORT_ORGANIZATION_ADD = "+";
        private const string SHORT_ORGANIZATION_DELETE = "-";
        private const string SHORT_SHOW_EMPLOYEE = "Employees";

        // Fields to store an organization cell data
        private object editOrgCellValue = default;
        private int editOrgCellId = default;
        private string editOrgCellCol = default;

        // Currently selected organizaion for the Employee Table
        private int currentOrgId = default;

        // Fields to store employee cell data
        private object editEmployeeCellValue = default;
        private int editEmployeeCellId = default;
        private string editEmployeeCellCol = default;

        public Page1()
        {
            InitializeComponent();
        }

        private void Page1_Load(object sender, EventArgs e)
        {
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
                MessageBox.Show("Cell can't be blank.",
                                "Invalid Data",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button1,
                                true);
                OrganizationTable.Rows[e.RowIndex][editOrgCellCol].Value = editOrgCellValue;
                return;
            }

            string sql = @"UPDATE 'Organizations' SET @Column = @Data WHERE Id = @Id";
            sql = sql.Replace("@Column", OrganizationTable.Columns[editOrgCellCol].DataPropertyName);

            using (SQLiteCommand command = DB.GetCommand(sql))
            {
                command.Parameters.AddWithValue("@Id", editOrgCellId);
                command.Parameters.AddWithValue("@Data", DB.CleanInput(insertedData.ToString()));

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
            using (AddOrganizationForm orgForm = new AddOrganizationForm())
            {
                DialogResult result = orgForm.ShowDialog();
                if (result == DialogResult.OK)
                    UpdateOrgGrid();
            }
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
                MessageBox.Show("An organization must be selected for deletion.",
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

            string sql = "DELETE FROM 'Organizations' WHERE Id = @OrgId";
            using (SQLiteCommand command = DB.GetCommand(sql))
            {
                command.Parameters.AddWithValue("@OrgId", orgIdToDelete);
                command.ExecuteNonQuery();
            }

            sql = "DELETE FROM 'Employees' WHERE OrganizationId = @OrgId";
            using (SQLiteCommand command = DB.GetCommand(sql))
            {
                command.Parameters.AddWithValue("@OrgId", orgIdToDelete);
                command.ExecuteNonQuery();
            }

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
                MessageBox.Show("Cell can't be blank.",
                                "Invalid Data",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button1,
                                true);
                EmployeeTable.Rows[e.RowIndex][editEmployeeCellCol].Value = editEmployeeCellValue;
                return;
            }

            string sql = "UPDATE 'Employees' SET @Column = @Data WHERE Id = @Id";
            sql = sql.Replace("@Column", EmployeeTable.Columns[editEmployeeCellCol].DataPropertyName);

            using (SQLiteCommand command = DB.GetCommand(sql))
            {
                command.Parameters.AddWithValue("@Id", editEmployeeCellId);
                command.Parameters.AddWithValue("@Data", DB.CleanInput(insertedData.ToString()));

                command.ExecuteNonQuery();
            }
            editEmployeeCellId = default;
            editEmployeeCellCol = default;
            editEmployeeCellValue = default;
        }

        // Employee View Buttons
        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            using (AddEmployeeForm orgForm = new AddEmployeeForm(currentOrgId))
            {
                DialogResult result = orgForm.ShowDialog();
                if (result == DialogResult.OK)
                    UpdateEmployeeGrid();
            }
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
                MessageBox.Show("Atleast one employee must be selected for deletion.",
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

            // Constructs a sql command with places for all selected employees
            string sql = "DELETE FROM 'Employees' WHERE Id IN (";
            for (int i = 0; i < employeeIdsToDelete.Count; i++)
                sql += $"@EmployeeId{i},";
            sql = sql.Remove(sql.Length - 1, 1) + ")";

            using (SQLiteCommand command = DB.GetCommand(sql))
            {
                // Loops through list of employee ids and adds their value into the command
                for (int i = 0; i < employeeIdsToDelete.Count; i++)
                    command.Parameters.AddWithValue($"@EmployeeId{i}", employeeIdsToDelete[i]);

                command.ExecuteNonQuery();
            }

            UpdateEmployeeGrid();
        }

        // Style Methods
        /// <summary>
        /// Changes elements on the page based on width of the viewport
        /// </summary>
        /// <param name="sender">Page1</param>
        private void Page1_Resize(object sender, EventArgs e)
        {
            Size screenSize = ((Control)sender).Size;

            // Decides on the width of content
            int newPanelWidth = VW(screenSize, 
                screenSize.Width > LONG_SHORT_THRESHOLD ? 
                LONG_MAX_PANEL_VW : 
                SHORT_MAX_PANEL_VW);

            ResizeAllWidth(OrganizationPanel, newPanelWidth);
            ResizeAllWidth(OrganizationTable, newPanelWidth);
            RelocatePanelToCenter(OrganizationPanel, PANEL_TOP_MARGIN);

            ResizeAllWidth(EmployeePanel, newPanelWidth);
            ResizeAllWidth(EmployeeTable, newPanelWidth);
            RelocatePanelToCenter(EmployeePanel, PANEL_TOP_MARGIN);

            int buttonMargin;
            if (screenSize.Width > LONG_SHORT_THRESHOLD) // Wide viewport
            {
                ResizeAllWidth(AddOrgButton, LONG_ADD_WIDTH);
                ResizeAllWidth(DeleteOrgButton, LONG_DELETE_WIDTH);
                ResizeAllWidth(EmployeeTableButton, LONG_SHOW_WIDTH);

                AddOrgButton.Text = LONG_ORGANIZATION_ADD;
                DeleteOrgButton.Text = LONG_ORGANIZATION_DELETE;
                EmployeeTableButton.Text = LONG_SHOW_EMPLOYEE;

                ResizeAllWidth(AddEmployeeButton, LONG_ADD_WIDTH);
                ResizeAllWidth(DeleteEmployeeButton, LONG_DELETE_WIDTH);
                ResizeAllWidth(OrganizationTableButton, LONG_SHOW_WIDTH);

                AddEmployeeButton.Text = LONG_EMPLOYEE_ADD;
                DeleteEmployeeButton.Text = LONG_EMPLOYEE_DELETE;
                OrganizationTableButton.Text = LONG_SHOW_ORGANIZATION;

                buttonMargin = LONG_BUTTON_MARGIN;
            }
            else // Thin viewport
            {
                ResizeAllWidth(AddOrgButton, SHORT_ADD_WIDTH);
                ResizeAllWidth(DeleteOrgButton, SHORT_DELETE_WIDTH);
                ResizeAllWidth(EmployeeTableButton, SHORT_SHOW_WIDTH);

                AddOrgButton.Text = SHORT_ORGANIZATION_ADD;
                DeleteOrgButton.Text = SHORT_ORGANIZATION_DELETE;
                EmployeeTableButton.Text = SHORT_SHOW_EMPLOYEE;

                ResizeAllWidth(AddEmployeeButton, SHORT_ADD_WIDTH);
                ResizeAllWidth(DeleteEmployeeButton, SHORT_DELETE_WIDTH);
                ResizeAllWidth(OrganizationTableButton, SHORT_SHOW_WIDTH);

                AddEmployeeButton.Text = SHORT_EMPLOYEE_ADD;
                DeleteEmployeeButton.Text = SHORT_EMPLOYEE_DELETE;
                OrganizationTableButton.Text = SHORT_SHOW_ORGANIZATION;

                buttonMargin = SHORT_BUTTON_MARGIN;
            }
            DeleteOrgButton.Location = new Point(AddOrgButton.Size.Width + buttonMargin, 0);
            EmployeeTableButton.Location = new Point(
                OrganizationPanel.Size.Width - EmployeeTableButton.Size.Width, 0);

            DeleteEmployeeButton.Location = new Point(AddEmployeeButton.Size.Width + buttonMargin, 0);
            OrganizationTableButton.Location = new Point(
                EmployeePanel.Size.Width - OrganizationTableButton.Size.Width, 0);
        }
        /// <summary>
        /// Relocates a control, centered horizontally, at a given vertical length
        /// </summary>
        /// <param name="panelToMove">Control to be moved</param>
        /// <param name="topMargin">Length in pixels</param>
        private static void RelocatePanelToCenter(Panel panelToMove, int topMargin)
        {
            panelToMove.Location = new Point(
                panelToMove.Parent.Width / 2 - panelToMove.Size.Width / 2,
                topMargin);
            panelToMove.Anchor = AnchorStyles.Top;
        }

        // Helper Methods
        private void ToggleOrganizationEmployeeView()
        {
            EmployeePanel.Visible = !EmployeePanel.Visible;
            OrganizationPanel.Visible = !OrganizationPanel.Visible;

            if (OrganizationTable.Visible) UpdateOrgGrid();
            else if (EmployeeTable.Visible) UpdateEmployeeGrid();
        }
        private void UpdateOrgGrid()
        {
            using (var conn = DB.GetConnection())
                OrganizationTable.DataSource = conn.Query<OragnizationModel>(
                    "SELECT * FROM 'Organizations'");
        }
        private void UpdateEmployeeGrid()
        {
            using (var conn = DB.GetConnection())
                EmployeeTable.DataSource = conn.Query<EmployeeModel>(
                    $"SELECT * FROM 'Employees' WHERE OrganizationId = {currentOrgId}");
        }
        /// <summary>
        /// Sets the min, max, and target widths
        /// </summary>
        /// <param name="newWidth">Width to set</param>
        private static void ResizeAllWidth(Control control, int newWidth)
        {
            control.MaximumSize = new Size(newWidth, 0);
            control.Size = new Size(newWidth, control.Size.Height);
            control.MinimumSize = new Size(newWidth, control.MinimumSize.Height);
        }

        /// <summary>
        /// Converts a viewport width measurement to pixel
        /// </summary>
        /// <param name="vwSize">Ratio of viewport width</param>
        /// <returns></returns>
        private static int VW(Size viewportSize, float vwSize) => (int)(viewportSize.Width * (vwSize * .01));
    }
}