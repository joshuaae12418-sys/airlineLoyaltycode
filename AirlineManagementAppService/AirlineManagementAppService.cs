using System;
using AirlineModels;
using AirlineDataService;

namespace AirlineManagementAppService
{
    public class MenuManager 
    {
        
        public void StartProcess(string name)
        {
            Console.WriteLine($"Service is processing data for: {name}");
            
        }
    }
}
