namespace FootballBeeting.Data.Models
{
    public class Game
    {
        public Guid GameId { get; set; }
        public decimal AwayTeamBetRate { get; set; }
        public int AwayTeamGoals { get; set; }

        public Guid AwayTeamId { get; set; }
        public Team? AwayTeam { get; set; }

        public decimal DrawBetRate { get; set; }
        public decimal HomeTeamBetRate { get; set; }
        public int HomeTeamGoals { get; set; }

        public Guid HomeTeamId { get; set; }
        public Team? HomeTeam { get; set; }

        public string? Result { get; set; }
        public DateTime DateTime { get; set; }

        public ICollection<PlayerStatistic>? PlayerStatistics { get; set; } 
        public ICollection<Bet>? Bets { get; set; }
    }
}