using Microsoft.Data.SqlClient;

namespace AirlineDataService
{
    public class DataBase
    {

        private string connectionString = @"Server=.\SQLEXPRESS; Database=AccountManagement; Integrated Security=True; TrustServerCertificate=True;";
        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}