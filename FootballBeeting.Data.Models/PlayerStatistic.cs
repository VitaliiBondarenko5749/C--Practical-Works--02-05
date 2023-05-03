namespace FootballBeeting.Data.Models
{
    public class PlayerStatistic
    {
        public Guid PlayerId { get; set; }
        public Player? Player { get; set; }

        public Guid GameId { get; set; }
        public Game? Game { get; set; }

        public int Assists { get; set; }
        public int MinutesPlayed { get; set; }
        public int ScoredGoals { get; set; }
    }
}