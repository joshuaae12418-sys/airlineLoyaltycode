using System.Data.SqlClient;

namespace AirlineDataService
{
    public class DataBase
    {
        
        private readonly string _connectionString =
            @"Server=localhost\SQLEXPRESS;Database=AccountManagement;Integrated Security=True;";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}