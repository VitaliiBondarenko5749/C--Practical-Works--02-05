using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P01_HospitalDatabase.Data.Models;

namespace P01_HospitalDatabase.Data.Configurations
{
    public class VisitationConfiguration : IEntityTypeConfiguration<Visitation>
    {
        public void Configure(EntityTypeBuilder<Visitation> builder)
        {
            builder.HasKey(visitation => visitation.VisitationId);

            builder.Property(visitation => visitation.Date)
                .IsRequired(true);

            builder.Property(visitation => visitation.Comments)
                .HasMaxLength(250)
                .IsUnicode(true)
                .IsRequired(false);

            builder.HasOne(visitation => visitation.Patient)
                .WithMany(patient => patient.Visitations)
                .HasForeignKey(visitation => visitation.PatientId);
        }
    }
}