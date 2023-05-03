namespace P03_SalesDatabase.Data.Models
{
    public class Product
    {
        public Guid ProductId { get; set; }
        public string? Name { get; set; }
        public float Quantity { get; set; }
        public decimal Price { get; set; }
        public string? Description { get; set; }
        public ICollection<Sale>? Sales { get; set; }
    }
}