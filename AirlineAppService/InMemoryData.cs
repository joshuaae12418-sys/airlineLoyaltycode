using System;
using System.Collections.Generic;
using System.Linq;
using AirlineModels;

namespace AirlineDataService
{
    public class InMemoryDataService : ILoyaltyDataService
    {
        private static List<LoyaltyAccount> _data = new List<LoyaltyAccount>();

        public void AddPoints(int points, string code)
        {
            _data.Add(new LoyaltyAccount
            {
                Points = points,
                RedeemedCode = code,
                CreatedAt = DateTime.Now
            });
        }

        public bool HasCodeBeenUsed(string code) => _data.Any(x => x.RedeemedCode == code);

        public int GetPoints() => _data.Sum(x => x.Points);

        public void UpdatePoints(int points) => AddPoints(points, "MANUAL_EDIT");

        public void DeductPoints(int points) => AddPoints(-points, "DEDUCTION");
    }
}