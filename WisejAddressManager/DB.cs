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
    }
}
