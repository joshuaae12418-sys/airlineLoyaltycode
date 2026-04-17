using Microsoft.Data.SqlClient;

namespace AirlineDataService
{
    public class DataBase
    {
        
        private string connectionString =
           @"Server=localhost\SQLEXPRESS; Database=AccountManagement; Integrated Security=True; TrustServerCertificate=True; Encrypt=False";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}