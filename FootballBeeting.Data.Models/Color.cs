namespace FootballBeeting.Data.Models
{
    public class Color
    {
        public Guid ColorId { get; set; }
        public string? Name { get; set; }

        public ICollection<Team>? PrimaryColorTeams { get; set; }
        public ICollection<Team>? SecondaryColorTeams { get; set; }
    }
}