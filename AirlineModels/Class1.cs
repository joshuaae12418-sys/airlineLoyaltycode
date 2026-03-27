namespace AirlineModels
{
    public class LoyaltyAccount
    {
        public int Points { get; set; }
        public string RedeemedCode { get; set; }
        public string Date { get; set; }

        public LoyaltyAccount()
        {
            Date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }
}
