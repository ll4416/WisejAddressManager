using System.Data.SQLite;
using Wisej.Web;

namespace WisejAddressManager
{
    public partial class AddOrganizationForm : Form
    {
        public string OrganizationName => NameBox.Text;
        public string StreetAddress => StreetBox.Text;
        public string ZipCode => ZipBox.Text;
        public string City => CityBox.Text;
        public string Country => CountryBox.Text;

        public AddOrganizationForm()
        {
            InitializeComponent();
        }

        private void ConfirmButton_Click(object sender, System.EventArgs e)
        {
            if (NameBox.Text == string.Empty ||
                StreetBox.Text == string.Empty ||
                ZipBox.Text == string.Empty ||
                CityBox.Text == string.Empty ||
                CountryBox.Text == string.Empty)
            {
                InvalidMessage.Visible = true;
                return;
            }

            AddOrganization();

            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelButton_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        private void AddOrganization()
        {
            string sql =
            @"
                INSERT INTO 'Organizations' (Name, Street, Zip, City, Country)
                VALUES (@Name, @Street, @Zip, @City, @Country)
            ";

            using (SQLiteCommand command = DB.GetCommand(sql))
            {
                command.Parameters.AddWithValue("@Name", DB.CleanInput(OrganizationName));
                command.Parameters.AddWithValue("@Street", DB.CleanInput(StreetAddress));
                command.Parameters.AddWithValue("@Zip", DB.CleanInput(ZipCode));
                command.Parameters.AddWithValue("@City", DB.CleanInput(City));
                command.Parameters.AddWithValue("@Country", DB.CleanInput(Country));
                command.ExecuteNonQuery();
            }
        }
    }
}
