using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P03_SalesDatabase.Data.Models;
using P03_SalesDatabase.Seeding;

namespace P03_SalesDatabase.Data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.ProductId);

            builder.Property(p => p.Name)
                .HasMaxLength(50)
                .IsUnicode();

            builder.HasMany(p => p.Sales)
                .WithOne(s => s.Product)
                .HasForeignKey(p => p.ProductId);

            // Task 4
            builder.Property(p => p.Description)
                .HasMaxLength(250)
                .HasDefaultValue("No description");

            builder.HasData(DataSeeder.Products);
        }
    }
}