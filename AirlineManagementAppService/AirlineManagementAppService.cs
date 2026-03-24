using System;
using AirlineModels;
using AirlineDataService;

namespace AirlineManagementAppService
{
    public class LoyaltyService 
    {
        private LoyaltyDataService dataService;
        
            private Dictionary<string, int> redeemCodes;

        public LoyaltyService()
        {
            dataService = new LoyaltyDataService();

            redeemCodes = new Dictionary<string, int>()
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
            if (redeemCodes.ContainsKey(code))
            {
                int points = redeemCodes[code];
                dataService.AddPoints(points);

                Console.WriteLine($"Code redeemed successfully! You earned {points} points.");
                Console.WriteLine($"Cyrrent Points: {dataService.GetPoints()}");
            }
            else
            {
                Console.WriteLine("Invalid redeem code. Please try again.");
            }
        }

        public int GetPoints()
        {
            return dataService.GetPoints();
        }


    }
}
