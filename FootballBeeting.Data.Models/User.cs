namespace FootballBeeting.Data.Models
{
    public class User
    {
        public Guid UserId { get; set; }
        public decimal Balance { get; set; }
        public string? Email { get; set; }
        public string? Name { get; set; }
        public string? Password { get; set; }
        public string? Username { get; set; }

        public ICollection<Bet>? Bets { get; set; }
    }
}