using System.Collections.Generic;
using AirlineModels;

namespace AirlineDataService
{
    public class LoyaltyDataService
    {
        private List<LoyaltyAccount> accounts = new List<LoyaltyAccount>();

        public void AddAccount(LoyaltyAccount account)
        {
            accounts.Add(account);
        }

        public LoyaltyAccount GetAccount(string name)
        {
            return accounts.Find(a => a.Name == name);
        }

        public void UpdatePoints(string name, int newPoints)
        {
            var acc = GetAccount(name);
            if (acc != null) acc.Points = newPoints;
        }

        public void DeleteAccount(string name)
        {
            var acc = GetAccount(name);
            if (acc != null) accounts.Remove(acc);
        }

        public List<LoyaltyAccount> GetAllAccounts()
        {
            return accounts;
        }
    }
}