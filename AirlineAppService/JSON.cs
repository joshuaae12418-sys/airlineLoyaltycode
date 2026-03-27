using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using AirlineModels;

namespace AirlineDataService
{
    public class JSON
    {
        private const string FileName = "loyalty_data.json";

        public void SaveData(List<LoyaltyAccount> history)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(history, options);
            File.WriteAllText(FileName, jsonString);
        }

        public List<LoyaltyAccount> LoadData()
        {
            try
            {
                if (!File.Exists(FileName)) return new List<LoyaltyAccount>();

                string jsonString = File.ReadAllText(FileName);
                if (string.IsNullOrWhiteSpace(jsonString)) return new List<LoyaltyAccount>();

                return JsonSerializer.Deserialize<List<LoyaltyAccount>>(jsonString) ?? new List<LoyaltyAccount>();
            }
            catch (JsonException)
            {
                
                return new List<LoyaltyAccount>();
            }
        }
    }
}