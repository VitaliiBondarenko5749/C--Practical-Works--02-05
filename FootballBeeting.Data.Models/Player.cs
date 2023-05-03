namespace FootballBeeting.Data.Models
{
    public class Player
    {
        public Guid PlayerId { get; set; }
        public bool IsInjured { get; set; }
        public string? Name { get; set; }

        public Guid PositionId { get; set; }
        public Position? Position { get; set; }

        public int SquadNumber { get; set; }

        public Guid TeamId { get; set; }
        public Team? Team { get; set; }

        public ICollection<PlayerStatistic>? PlayerStatistics { get; set; } 
    }
}