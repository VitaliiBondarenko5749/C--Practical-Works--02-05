namespace P03_SalesDatabase.Data.Models
{
    public class Store
    {
        public Guid StoreId { get; set; }
        public string? Name { get; set; }
        public ICollection<Sale>? Sales { get; set; }
    }
}