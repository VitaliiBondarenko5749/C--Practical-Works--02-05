using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P01_StudentSystem.Data.Models;
using P01_StudentSystem.Seeding;

namespace P01_StudentSystem.Data.Configurations
{
    public class ResourceConfiguration : IEntityTypeConfiguration<Resource>
    {
        public void Configure(EntityTypeBuilder<Resource> builder)
        {
            builder.HasKey(r => r.ResourceId);

            builder.Property(r => r.Name)
                .HasMaxLength(50)
                .IsUnicode();

            builder.Property(r => r.Url)
                .IsUnicode(false);

            builder.HasData(DataSeeder.Resources);
        }
    }
}