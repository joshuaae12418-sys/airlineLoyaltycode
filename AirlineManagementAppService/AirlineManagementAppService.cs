using System;
using AirlineModels;
using AirlineDataService;
using System.Numerics;

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

        public void EditPoints(int newPoints)
        {
            if (newPoints < 0)
            {
                newPoints = 0; 
            }

            dataService.UpdatePoints(newPoints);

            Console.WriteLine($"Points set successfully. Current Points: {dataService.GetPoints()}");
        }

        public void DeletePoints(int pointsToDeduct)
        {
            if (pointsToDeduct < 0)
            {
                Console.WriteLine("Cannot deduct negative points.");
                return;
            }

            dataService.DeductPoints(pointsToDeduct);
            Console.WriteLine($"Points deducted successfully. Current Points: {dataService.GetPoints()}");
        }
    }
    }


