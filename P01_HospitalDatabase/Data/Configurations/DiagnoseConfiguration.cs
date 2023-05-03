using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P01_HospitalDatabase.Data.Models;

namespace P01_HospitalDatabase.Data.Configurations
{
    public class DiagnoseConfiguration : IEntityTypeConfiguration<Diagnose>
    {
        public void Configure(EntityTypeBuilder<Diagnose> builder)
        {
            builder.HasKey(diagnose => diagnose.DiagnoseId);

            builder.Property(diagnose => diagnose.Name)
                .HasMaxLength(50)
                .IsUnicode(true);

            builder.Property(diagnose => diagnose.Comments)
                .HasMaxLength(250)
                .IsUnicode(true);

            builder.HasOne(diagnose => diagnose.Patient)
                .WithMany(patient => patient.Diagnoses)
                .HasForeignKey(diagnose => diagnose.PatientId);
        }
    }
}