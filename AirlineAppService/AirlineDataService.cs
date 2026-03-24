using System.Collections.Generic;
using AirlineModels;
using Microsoft.VisualBasic;

namespace AirlineDataService
{
    public class LoyaltyDataService
    {

        private LoyaltyAccount account;

        public LoyaltyDataService()
        {
            account = new LoyaltyAccount();
        }
        public void AddPoints(int points)
        {
            account.Points += points;
        }

        public int GetPoints()
        {
            return account.Points;
        }
    }

}