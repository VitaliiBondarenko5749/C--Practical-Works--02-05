using BookShop.Seeding;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookShop.Models.Configurations
{
    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasKey(a => a.AuthorId);

            builder.Property(a => a.FirstName)
                .HasMaxLength(50)
                .IsUnicode()
                .IsRequired(false);

            builder.Property(a => a.LastName)
                .HasMaxLength(50)
                .IsUnicode();

            builder.HasData(DataSeeder.Authors);
        }
    }
}