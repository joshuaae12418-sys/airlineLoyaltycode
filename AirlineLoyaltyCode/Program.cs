using System;
using AirlineManagementAppService;
using AirlineDataService;


namespace AirlineLoyaltyCode
{
    class Program
    {

        static LoyaltyService loyaltyService = new LoyaltyService(new LoyaltyDataService());
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Airline Loyalty Program!");
            bool exit = false;

            while (!exit)
            {
              
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Redeem Points");
                Console.WriteLine("2. Check Points");
                Console.WriteLine("3. Edit Points");
                Console.WriteLine("4. Deduct Points");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        RedeemPoints(); 
                        break;
                    case "2":
                        CheckCurrentBalance(); 
                        break;
                    case "3":
                        UpdatePointsValue(); 
                        break;
                    case "4":
                        DeductPointsValue(); 
                        break;
                    case "5":
                        Console.WriteLine("Exiting program...");
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }


        static void RedeemPoints()
        {
            Console.WriteLine("Enter your redeem code:");
            string code = Console.ReadLine();
            loyaltyService.Redeem(code);
        }

        static void CheckCurrentBalance()
        {
            int points = loyaltyService.GetPoints();
            Console.WriteLine($"You have {points} points.");
        }

        static void UpdatePointsValue()
        {
            Console.WriteLine("Enter the desired points:");
            if (int.TryParse(Console.ReadLine(), out int points))
            {
                loyaltyService.EditPoints(points);
                Console.WriteLine("Points updated.");
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }

        static void DeductPointsValue()
        {
            Console.Write("Enter points to deduct: ");
            if (int.TryParse(Console.ReadLine(), out int pointsToDeduct))
            {
                loyaltyService.DeletePoints(pointsToDeduct);
                Console.WriteLine("Points deducted.");
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
}