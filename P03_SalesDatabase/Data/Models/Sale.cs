namespace P03_SalesDatabase.Data.Models
{
    public class Sale
    {
        public Guid SaleId { get; set; }
        public DateTime Date { get; set; }
        public Guid ProductId { get; set; }
        public Product? Product { get; set; }
        public Guid CustomerId { get; set; }
        public Customer? Customer { get; set; }
        public Guid StoreId { get; set; }
        public Store? Store { get; set; }
    }
}