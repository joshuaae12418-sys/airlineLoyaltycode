using System;
using System.Collections.Generic;
using AirlineDataService;

namespace AirlineManagementAppService
{
    public class LoyaltyService
    {
        private readonly ILoyaltyDataService dAtaService;
        private readonly Dictionary<string, int> redeemCodes;

      
        public LoyaltyService(ILoyaltyDataService serviceProvider)
        {
            dAtaService = serviceProvider;
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
           
            if (redeemCodes.ContainsKey(code))
            {
                if (dAtaService.HasCodeBeenUsed(code))
                {
                    Console.WriteLine($"Error: {code} already used.");
                    return;
                }

                int points = redeemCodes[code];
                dAtaService.AddPoints(points, code);
                Console.WriteLine($"Success! Current Total: {GetPoints()}");
            }
            else
            {
                Console.WriteLine("Invalid code.");
            }
        }

        public int GetPoints() => dAtaService.GetPoints();
        public void EditPoints(int points) => dAtaService.UpdatePoints(points);
        public void DeletePoints(int points) => dAtaService.DeductPoints(points);
    }
}