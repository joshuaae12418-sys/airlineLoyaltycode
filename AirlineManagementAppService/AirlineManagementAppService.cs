using System;
using System.Collections.Generic;
using AirlineDataService;

namespace AirlineManagementAppService
{
    public class LoyaltyService
    {
        private readonly LoyaltyDataService dataService;
        private readonly Dictionary<string, int> redeemCodes;

        public LoyaltyService()
        {
            dataService = new LoyaltyDataService();
            redeemCodes = new Dictionary<string, int>
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
            
            if (!redeemCodes.ContainsKey(code))
            {
                Console.WriteLine("Invalid code.");
                return;
            }

           
            if (dataService.HasCodeBeenUsed(code))
            {
                Console.WriteLine($"Error: {code} has already been used.");
                return;
            }

           
            int points = redeemCodes[code];
            dataService.AddPoints(points, code);
            Console.WriteLine($"Successfully Redeemed {code}! Current Total: {GetPoints()}");
        }

        public int GetPoints() => dataService.GetPoints();
        public void EditPoints(int points) => dataService.UpdatePoints(points);
        public void DeletePoints(int points) => dataService.DeductPoints(points);
    }
}