using Bogus;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using P03_SalesDatabase.Data;
using P03_SalesDatabase.Data.Models;

namespace P03_SalesDatabase.Seeding
{
    public static class DataSeeder
    {
        public static List<Store> Stores { get; private set; } = new List<Store>();
        public static List<Customer> Customers { get; private set; } = new List<Customer>();
        public static List<Product> Products { get; private set; } = new List<Product>();
        public static List<Sale> Sales { get; private set; } = new List<Sale>();

        public static void InitializeData()
        {
            Faker<Store> storeFaker = GetStoreGenerator();
            Faker<Customer> customerFaker = GetCustomerGenerator();
            Faker<Product> productFaker = GetProductGenerator();
            Faker<Sale> saleFaker = GetSaleGenerator();

            List<Store> stores = storeFaker.Generate(10);
            List<Customer> customers = customerFaker.Generate(10);
            List<Product> products = productFaker.Generate(20);

            Stores.AddRange(stores);
            Customers.AddRange(customers);
            Products.AddRange(products);

            List<Sale> sales = saleFaker.Generate(15);

            Sales.AddRange(sales);
        }

        private static Faker<Store> GetStoreGenerator()
        {
            return new Faker<Store>()
                .RuleFor(s => s.StoreId, _ => Guid.NewGuid())
                .RuleFor(s => s.Name, f => f.Company.CompanyName());
        }

        private static Faker<Customer> GetCustomerGenerator()
        {
            return new Faker<Customer>()
                .RuleFor(c => c.CustomerId, _ => Guid.NewGuid())
                .RuleFor(c => c.Name, f => f.Person.FullName)
                .RuleFor(c => c.Email, f => f.Person.Email)
                .RuleFor(c => c.CreditCardNumber, f => f.Finance.CreditCardNumber());
        }

        private static Faker<Product> GetProductGenerator()
        {
            return new Faker<Product>()
                .RuleFor(p => p.ProductId, _ => Guid.NewGuid())
                .RuleFor(p => p.Name, f => f.Commerce.ProductName())
                .RuleFor(p => p.Quantity, f => f.Random.Float(0, 1000))
                .RuleFor(p => p.Price, f => f.Random.Decimal(0, 10000));
        }

        private static Faker<Sale> GetSaleGenerator()
        {
            return new Faker<Sale>()
                .RuleFor(s => s.SaleId, f => Guid.NewGuid())
        .RuleFor(s => s.ProductId, f => f.PickRandom(Products).ProductId)
        .RuleFor(s => s.CustomerId, f => f.PickRandom(Customers).CustomerId)
        .RuleFor(s => s.StoreId, f => f.PickRandom(Stores).StoreId);
            // Task 5. Видалив RuleFor для Date
        }
    }
}