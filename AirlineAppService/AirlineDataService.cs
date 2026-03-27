using System;
using System.Collections.Generic;
using System.Linq;
using AirlineModels;

namespace AirlineDataService
{
    public class LoyaltyDataService
    {
        private readonly JSON _jsonPersistence;

        public LoyaltyDataService()
        {
            _jsonPersistence = new JSON();
        }

        public void AddPoints(int points, string code)
        {
            List<LoyaltyAccount> history = _jsonPersistence.LoadData();

            LoyaltyAccount newEntry = new LoyaltyAccount
            {
                Points = points,
                RedeemedCode = code
            };

            history.Add(newEntry);
            _jsonPersistence.SaveData(history);
        }

        public bool HasCodeBeenUsed(string code)
        {
            var history = _jsonPersistence.LoadData();
            return history.Any(x => x.RedeemedCode == code);
        }

        public int GetPoints()
        {
            var history = _jsonPersistence.LoadData();
            return history.Sum(x => x.Points);
        }

        public void UpdatePoints(int points) => AddPoints(points, "MANUAL_EDIT");

        public void DeductPoints(int pointsToDeduct) => AddPoints(-pointsToDeduct, "DEDUCTION");
    }
}