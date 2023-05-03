using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P03_SalesDatabase.Data.Models;
using P03_SalesDatabase.Seeding;

namespace P03_SalesDatabase.Data.Configurations
{
    public class StoreConfiguration : IEntityTypeConfiguration<Store>
    {
        public void Configure(EntityTypeBuilder<Store> builder)
        {
            builder.HasKey(s => s.StoreId);

            builder.Property(s => s.Name)
                .HasMaxLength(80)
                .IsUnicode();

            builder.HasMany(s => s.Sales)
                .WithOne(sal => sal.Store)
                .HasForeignKey(sal => sal.StoreId);

            builder.HasData(DataSeeder.Stores);
        }
    }
}