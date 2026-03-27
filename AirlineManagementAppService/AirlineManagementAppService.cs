using System;
using System.Collections.Generic;
using AirlineDataService;

namespace AirlineManagementAppService
{
    public class LoyaltyService
    {
        private readonly LoyaltyDataService _dataService;
        private readonly Dictionary<string, int> _redeemCodes;

        public LoyaltyService()
        {
            _dataService = new LoyaltyDataService();
            _redeemCodes = new Dictionary<string, int>
            {
                { "FLYHIGH100", 100 },
                { "SKYBONUS200", 200 },
                { "TRAVEL300", 300 },
                { "STINGLIKEABEE", 50 },
                { "JET2HOLIDAY", 20 }
            };
        }

        public void Redeem(string code)
        {
            if (!_redeemCodes.ContainsKey(code))
            {
                Console.WriteLine("Invalid code.");
                return;
            }

            if (_dataService.HasCodeBeenUsed(code))
            {
                Console.WriteLine($"Error: {code} has already been used.");
                return;
            }

            int points = _redeemCodes[code];
            _dataService.AddPoints(points, code);
            Console.WriteLine($"Redeemed {code}! Current Total Points: {_dataService.GetPoints()}");
        }

        public int GetPoints() => _dataService.GetPoints();
        public void EditPoints(int points) => _dataService.UpdatePoints(points);
        public void DeletePoints(int points) => _dataService.DeductPoints(points);
    }
}