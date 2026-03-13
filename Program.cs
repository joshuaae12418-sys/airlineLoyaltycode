using System;
namespace AirlineLoyaltyCode
{
    class Program
    {
        static string redeemCode = "";
        static int Points = 0;
        static bool exit = false;
        static void Main()
        {

            Console.Write("Write Your Name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}, Welcome!!");

            while (!exit)
            {

                Console.WriteLine("-----------------------------------");
                Console.WriteLine("\nLOYALTY REDEEM POINTS\n");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("1. REDEEM");
                Console.WriteLine("2. EDIT");
                Console.WriteLine("3. VIEW"); s
                Console.WriteLine("4. DELETE");
                Console.WriteLine("5. HELP");
                Console.WriteLine("6. EXIT");
                Console.Write("Enter Your Choice: ");
                string choice = Console.ReadLine();


                switch (choice)
                {
                    case "1":
                        Redeem();
                        break;

                    case "2":
                        Edit();
                        break;

                    case "3":
                        ViewPoints();
                        break;

                    case "4":
                        Delete();
                        break;

                    case "5":
                        Help();
                        break;

                    case "6":
                        Exit();
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;

                }
            }

            static void Redeem()
            {
                Console.WriteLine("Enter Redeem Code. Ex.45****7 ");
                redeemCode = Console.ReadLine();

                if (redeemCode == "1234567")
                {
                    Points += 50;
                    Console.WriteLine("Points redeemed successfully!");
                }
                else
                {
                    Console.WriteLine("INVALID CODE!!!");
                }
                Console.WriteLine("Current Points: " + Points);

            }
        }

        static void Edit()
        {
            Console.Write("Enter No. of Points: ");
            Points = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Points have been edited successfully.");
        }
        static void ViewPoints()
        {
            Console.WriteLine($"Current Points: {Points}");
        }
        static void Delete()
        {
            Console.WriteLine("Delete No. of Points: ");
            Points = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Points Deleted Successfuly!");
            Console.WriteLine("Current Points: " + Points);
        }

        static void Help()
        {
            Console.WriteLine(@"________________________________________________
|  AIRLINE TICKET                                  |
|  Name: JOSHUA                [ CODE: 45****7 ] <---|
|__________________________________________________|");
            Console.WriteLine("");
        }
        static void Exit()
        {
            Console.WriteLine("Exiting Program...");
            exit = true;
        }
    }
}