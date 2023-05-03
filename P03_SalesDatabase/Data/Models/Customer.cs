﻿namespace P03_SalesDatabase.Data.Models
{
    public class Customer
    {
        public Guid CustomerId { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? CreditCardNumber { get; set; }
        public ICollection<Sale>? Sales { get; set; }
    }
}