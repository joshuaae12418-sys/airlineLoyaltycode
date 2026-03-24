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

        public void UpdatePoints(int points)
        {
            account.Points = points;
        }


        public void DeductPoints(int pointsToDeduct)
        {
            int currentPoints = account.Points;
            int newPoints = currentPoints - pointsToDeduct;

            if (newPoints < 0)
            {
                newPoints = 0;
            }

            account.Points = newPoints;
        }
    }

}