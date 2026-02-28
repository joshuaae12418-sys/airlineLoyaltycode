namespace airlineLoyaltycode
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string redeemCode;
            string points;
            string editPoints;
            string viewPoints;
            string deletePoints;


            Console.Write("Write Your Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name + " Welcome!!.");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("\nLOYALTY REDEEM POINTS\n");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("1. REDEEM POINTS");
            Console.WriteLine("2. EDIT POINTS");
            Console.WriteLine("3. VIEW POINTS");
            Console.WriteLine("4. DELETE POINTS");
            Console.WriteLine("5. WHERE TO FIND MY CODE");
            Console.WriteLine("6. EXIT");
            Console.Write("Enter Your Choice: ");
            string choice = Console.ReadLine();


            switch (choice)
            {
                case "1":
                    Console.WriteLine("Enter Redeem Code. Ex.45****7 ");
                    redeemCode = Console.ReadLine();

                    if (redeemCode != "")
                    {
                        Console.WriteLine("Redeem code is valid. Points redeemed successfully.");
                        points = "50";
                    }
                    else
                    {
                        Console.WriteLine("Invalid redeem code. Please try again.");
                    }
                    break;

                case "2":
                    Console.Write("Enter No. of Points: ");
                    points = Console.ReadLine();
                    Console.WriteLine("Points have been edited successfully.");
                    Console.WriteLine("Current Points: " + points);
                    break;
                
                case "3":
                    Console.WriteLine("Current Points: " + points);
                    break;
                
                case "4":
                    Console.WriteLine("Delete No. of Points: ");
                    points = Console.ReadLine();   
                    Console.WriteLine("Points Deleted Successfuly!");
                    Console.WriteLine("Current Points: " + points);
                    break;
               
                case "5":
                    Console.WriteLine(@"________________________________________________
|  AIRLINE TICKET                                  |
|  Name: JOSHUA                [ CODE: 45****7 ] <---|
|__________________________________________________|");
                    Console.WriteLine("");
                    break;

                case "6":
                    Console.WriteLine("Exiting Program...");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;

            }
        }
    }
}