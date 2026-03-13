using AirlineModels;
using AirlineDataService;

namespace AirlineManagementAppService
{
    public class LoyaltyManager
    {
        private LoyaltyDataService dataService = new LoyaltyDataService();

        public void RedeemPoints(string name, string code)
        {
            var acc = dataService.GetAccount(name);
            if (acc != null && code == "1234567")
            {
                acc.Points += 50;
            }
        }

        public LoyaltyAccount CreateAccount(string name)
        {
            var acc = new LoyaltyAccount { Name = name, Points = 0 };
            dataService.AddAccount(acc);
            return acc;
        }

        public LoyaltyAccount ViewAccount(string name)
        {
            return dataService.GetAccount(name);
        }

        public void EditPoints(string name, int points)
        {
            dataService.UpdatePoints(name, points);
        }

        public void DeleteAccount(string name)
        {
            dataService.DeleteAccount(name);
        }
    }
}