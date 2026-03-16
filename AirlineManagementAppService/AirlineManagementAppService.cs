using System;
using AirlineManagementAppService;

namespace AirlineLoyaltyCode
{
    class Program
    {
        static void Main()
        {
            Console.Write("Write Your Name: ");
            string name = Console.ReadLine();

            MenuManager menu = new MenuManager();
            menu.Run(name);
        }
    }
}