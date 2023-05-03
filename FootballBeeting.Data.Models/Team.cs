namespace FootballBeeting.Data.Models
{
    public class Team
    {
        public Guid TeamId { get; set; }
        public decimal Budget { get; set; }
        public string? Initials { get; set; }
        public string? LogoUrl { get; set; }
        public string? Name { get; set; }

        public Guid PrimaryKitColorId { get; set; }
        public Color? PrimaryKitColor { get; set; }

        public Guid SecondaryKitColorId { get; set; }
        public Color? SecondaryKitColor { get; set; }

        public Guid TownId { get; set; }
        public Town? Town { get; set; }

        public ICollection<Player>? Players { get; set; }
        public ICollection<Game>? AwayTeamGames { get; set; }
        public ICollection<Game>? HomeTeamGames { get; set; }
    }
}