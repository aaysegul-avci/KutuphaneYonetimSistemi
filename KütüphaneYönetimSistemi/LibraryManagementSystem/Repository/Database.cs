using Microsoft.Data.SqlClient;

namespace Odev12.Repository
{
    public class Database
    {
        private static SqlConnection _connection;

        public static string connectionString =
            "Server=DESKTOP-5I18A08;Database=LibraryDatabase;Trusted_Connection=True;TrustServerCertificate=True;";

        public static SqlConnection GetConnection()
        {
            if (_connection == null)
            {
                _connection = new SqlConnection(connectionString);
            }

            if (_connection.State != System.Data.ConnectionState.Open)
            {
                _connection.Open();
            }

            return _connection;
        }
    }
}
