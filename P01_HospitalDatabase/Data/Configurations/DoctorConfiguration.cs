// Task 2. 

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P01_HospitalDatabase.Data.Models;

namespace P01_HospitalDatabase.Data.Configurations
{
    public class DoctorConfiguration : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.HasKey(d => d.DoctorId);

            builder.Property(d => d.Name)
                 .HasMaxLength(100)
              .IsUnicode(true);

            builder.Property(d => d.Specialty)
               .HasMaxLength(100)
               .IsUnicode(true);

            builder.Property(d => d.Password)
                .IsUnicode(true)
                .HasColumnName("PasswordHash");

            builder.Property(d => d.Email)
                .HasMaxLength(30)
                .IsUnicode(true);

            builder.HasIndex(d => d.Email)
                .IsUnique(true);

            builder.ToTable("Doctors");
        }
    }
}