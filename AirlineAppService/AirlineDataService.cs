using System;
using Microsoft.Data.SqlClient;
using AirlineModels;

namespace AirlineDataService
{
    public class LoyaltyDataService
    {
        private readonly DataBase db; 

        public LoyaltyDataService()
        {
            db = new DataBase(); 
        }

        public void AddPoints(int points, string code)
        {
            using (var conn = db.GetConnection())
            {
                string query = "INSERT INTO dbo.Accounts (Points, RedeemedCode) VALUES (@pts, @cd)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@pts", points);
                cmd.Parameters.AddWithValue("@cd", code);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public bool HasCodeBeenUsed(string code)
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

        public int GetPoints()
        {
            using (var conn = db.GetConnection())
            {
                string query = "SELECT ISNULL(SUM(Points), 0) FROM dbo.Accounts";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public void UpdatePoints(int points) => AddPoints(points, "MANUAL_EDIT");
        public void DeductPoints(int points) => AddPoints(-points, "DEDUCTION");
    }
}