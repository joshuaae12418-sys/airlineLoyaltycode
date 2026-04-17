namespace AirlineModels
{
    public class LoyaltyAccount
    {
       
        public int Id { get; set; }
        public int Points { get; set; }
        public string RedeemedCode { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
