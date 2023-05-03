namespace FootballBeeting.Data.Models
{
    public class Country
    {
        public Guid CountryId { get; set; }
        public string? Name { get; set; }

        public ICollection<Town>? Towns { get; set; }
    }
}