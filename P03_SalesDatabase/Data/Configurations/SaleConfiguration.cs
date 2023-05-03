using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P03_SalesDatabase.Data.Models;
using P03_SalesDatabase.Seeding;

namespace P03_SalesDatabase.Data.Configurations
{
    public class SaleConfiguration : IEntityTypeConfiguration<Sale>
    {
        public void Configure(EntityTypeBuilder<Sale> builder)
        {
            builder.HasKey(s => s.SaleId);

            builder.Property(s => s.ProductId)
                .HasColumnName("Product");

            builder.Property(s => s.CustomerId)
                .HasColumnName("Customer");

            builder.Property(s => s.StoreId)
                .HasColumnName("Store");

            // Task 5
            builder.Property(s => s.Date)
                .HasDefaultValueSql("GETDATE()");

            builder.HasData(DataSeeder.Sales);
        }
    }
}