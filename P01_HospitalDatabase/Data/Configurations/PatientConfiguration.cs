using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P01_HospitalDatabase.Data.Models;

namespace P01_HospitalDatabase.Data.Configurations
{
    public class PatientConfiguration : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder.HasKey(patient => patient.PatientId);

            builder.Property(patient => patient.FirstName)
                .HasMaxLength(50)
                .IsUnicode(true);

            builder.Property(patient => patient.LastName)
                .HasMaxLength(50)
                .IsUnicode(true);

            builder.Property(patient => patient.Address)
                .HasMaxLength(250)
                .IsUnicode(true);

            builder.Property(patient => patient.Email)
                .HasMaxLength(80)
                .IsUnicode(false);

            builder.Property(patient => patient.HasInsurance)
                .IsRequired(true);
        }
    }
}