using System.Configuration;
using System.Data.SQLite;

namespace WisejAddressManager
{
    public static class DB
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
        public static string ConnectionString => connectionString;

        public static SQLiteConnection GetConnection(bool autoOpen = true)
        {
            SQLiteConnection connection = new SQLiteConnection(connectionString);

            if (autoOpen)
                connection.Open();

            return connection;
        }

        public static SQLiteCommand GetCommand(string sql)
        {
            return new SQLiteCommand(sql, GetConnection());
        }

        /// <summary>
        /// Cleans a string for input into a SQLite database
        /// </summary>
        /// <param name="input">String to be cleaned</param>
        /// <returns>Cleaned input</returns>
        public static string CleanInput(string input)
        {
            string cleanedStr = input;
            cleanedStr = cleanedStr.Trim();

            return cleanedStr;
        }
    }
}
