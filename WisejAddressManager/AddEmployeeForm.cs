using System.Data.SQLite;
using Wisej.Web;

namespace WisejAddressManager
{
    public partial class AddEmployeeForm : Form
    {
        private readonly int currentOrgId = -1;
        public string Title => TitleBox.Text;
        public string FirstName => FirstNameBox.Text;
        public string LastName => LastNameBox.Text;
        public string PhoneNumber => PhoneNumberBox.Text;
        public string Email => EmailBox.Text;

        /// <summary>
        /// Creates a form to add an employee
        /// </summary>
        /// <param name="orgId">Id of current organization</param>
        public AddEmployeeForm(int orgId)
        {
            InitializeComponent();
            currentOrgId = orgId;
        }

        /// <summary>
        /// Verifies valid input then adds the employee into the database
        /// </summary>
        private void ConfirmButton_Click(object sender, System.EventArgs e)
        {
            if (TitleBox.Text == string.Empty ||
                FirstNameBox.Text == string.Empty ||
                LastNameBox.Text == string.Empty ||
                PhoneNumberBox.Text == string.Empty ||
                EmailBox.Text == string.Empty)
            {
                InvalidMessage.Visible = true;
                return;
            }

            AddEmployee();

            DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        /// Closes form
        /// </summary>
        private void CancelButton_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        /// <summary>
        /// Adds employee to the database
        /// </summary>
        private void AddEmployee()
        {
            string sql =
            @"
                INSERT INTO 'Employees' (Title, FirstName, LastName, PhoneNumber, Email, OrganizationId) 
                VALUES (@Title, @FirstName, @LastName, @PhoneNumber, @Email, @OrganizationId)
            ";

            using (SQLiteCommand command = DB.GetCommand(sql))
            {
                command.Parameters.AddWithValue("@Title", DB.CleanInput(Title));
                command.Parameters.AddWithValue("@FirstName", DB.CleanInput(FirstName));
                command.Parameters.AddWithValue("@LastName", DB.CleanInput(LastName));
                command.Parameters.AddWithValue("@PhoneNumber", DB.CleanInput(PhoneNumber));
                command.Parameters.AddWithValue("@Email", DB.CleanInput(Email));
                command.Parameters.AddWithValue("@OrganizationId", currentOrgId);
                command.ExecuteNonQuery();
            }
        }
    }
}