namespace FootballBeeting.Data.Models
{
    public class Town
    {
        public Guid TownId { get; set; }

        public Guid CountryId { get; set; }
        public Country? Country { get; set; }

        public string? Name { get; set; }

        public ICollection<Team>? Teams { get; set; }
    }
}