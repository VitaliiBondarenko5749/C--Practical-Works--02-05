using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P01_StudentSystem.Data.Models;
using P01_StudentSystem.Seeding;

namespace P01_StudentSystem.Data.Configurations
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(c => c.CourseId);

            builder.Property(c => c.Name)
                .HasMaxLength(80)
                .IsUnicode();

            builder.Property(c => c.Description)
                .IsUnicode()
                .IsRequired(false);

            builder.HasMany(c => c.HomeworkSubmissions)
                .WithOne(c => c.Course)
                .HasForeignKey(c => c.CourseId);

            builder.HasMany(c => c.Resources)
                .WithOne(c => c.Course)
                .HasForeignKey(c => c.CourseId);

            builder.HasData(DataSeeder.Courses);
        }
    }
}