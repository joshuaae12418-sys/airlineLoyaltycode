using Microsoft.Data.SqlClient;
using AirlineModels;
using System;

namespace AirlineDataService
{
    public class LoyaltyDataService : ILoyaltyDataService
    {
        DataBase db = new DataBase();

        public void AddPoints(int points, string code)
        {
            try
            {
                using (var conn = db.GetConnection())
                {
                   
                    string query = "INSERT INTO dbo.Accounts (Points, RedeemedCode, CreatedAt) VALUES (@pts, @cd, GETDATE())";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@pts", points);
                    cmd.Parameters.AddWithValue("@cd", code);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    Console.WriteLine($"{rowsAffected} row(s) inserted successfully!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("DATABASE ERROR: " + ex.Message);
            }
        }

        public bool HasCodeBeenUsed(string code)
        {
            try
            {
                using (var conn = db.GetConnection())
                {
                    string query = "SELECT COUNT(1) FROM dbo.Accounts WHERE RedeemedCode = @cd";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@cd", code);
                    conn.Open();
                    return (int)cmd.ExecuteScalar() > 0;
                }
            }
            catch { return false; }
        }

        public int GetPoints()
        {
            try
            {
                using (var conn = db.GetConnection())
                {
                    string query = "SELECT ISNULL(SUM(Points), 0) FROM dbo.Accounts";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    var result = cmd.ExecuteScalar();
                    return result == DBNull.Value ? 0 : Convert.ToInt32(result);
                }
            }
            catch { return 0; }
        }

        public void UpdatePoints(int points) => AddPoints(points, "MANUAL_EDIT");
        public void DeductPoints(int points) => AddPoints(-points, "DEDUCTION");
    }
}