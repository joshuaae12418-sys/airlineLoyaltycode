using System.Collections.Generic;
using AirlineModels;

namespace AirlineDataService
{
    public interface ILoyaltyDataService
    {
        void AddPoints(int points, string code);
        bool HasCodeBeenUsed(string code);
        int GetPoints();
        void UpdatePoints(int points);
        void DeductPoints(int points);
    }
}