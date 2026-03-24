using System;
using AirlineManagementAppService;

namespace AirlineLoyaltyCode
{
    class Program
    {

        static void Main(string[] args)
        {
            LoyaltyService loyaltyService = new LoyaltyService();

            Console.WriteLine("Welcome to Airline Loyalty Program!");
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Redeem Points");
                Console.WriteLine("2. Check Points");
                Console.WriteLine("3. Exit");

                Console.WriteLine("Enter your choice:");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Enter your redeem code:");
                        string code = Console.ReadLine();
                        loyaltyService.Redeem(code);
                        break;

                    case "2":
                        int points = loyaltyService.GetPoints();
                        Console.WriteLine($"You have {points} points.");
                        break;
                    case "3":
                        Console.WriteLine("Exitingg program");
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;

                }

            }
        }
    }
}   