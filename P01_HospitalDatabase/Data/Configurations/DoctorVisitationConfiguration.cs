using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P01_HospitalDatabase.Data.Models;

namespace P01_HospitalDatabase.Data.Configurations
{
    public class DoctorVisitationConfiguration : IEntityTypeConfiguration<DoctorVisitation>
    {
        public void Configure(EntityTypeBuilder<DoctorVisitation> builder)
        {
            builder.HasKey(dv => new { dv.DoctorId, dv.VisitationId });

            builder.HasOne(dv => dv.Doctor)
                .WithMany(d => d.DoctorVisitations)
                .HasForeignKey(d => d.DoctorId);

            builder.HasOne(dv => dv.Visitation)
                .WithMany(d => d.DoctorVisitations)
                .HasForeignKey(d => d.VisitationId);

            builder.ToTable("DoctorVisitation");
        }
    }
}