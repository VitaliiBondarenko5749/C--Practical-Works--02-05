using Microsoft.EntityFrameworkCore;
using P01_HospitalDatabase.Data.Configurations;
using P01_HospitalDatabase.Data.Models;

namespace P01_HospitalDatabase.Data
{
    public class HospitalContext : DbContext
    {
        public DbSet<Patient> Patients => Set<Patient>();
        public DbSet<Visitation> Visitations => Set<Visitation>();
        public DbSet<Diagnose> Diagnoses => Set<Diagnose>();
        public DbSet<Medicament> Medicaments => Set<Medicament>();
        public DbSet<PatientMedicament> Prescriptions => Set<PatientMedicament>();
        public DbSet<Doctor> Doctors => Set<Doctor>();
        public DbSet<DoctorVisitation> DoctorVisitations => Set<DoctorVisitation>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=VITALII-PC;Initial Catalog=HospitalDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DiagnoseConfiguration());
            modelBuilder.ApplyConfiguration(new MedicamentConfiguration());
            modelBuilder.ApplyConfiguration(new PatientConfiguration());
            modelBuilder.ApplyConfiguration(new PatientMedicamentConfiguration());
            modelBuilder.ApplyConfiguration(new VisitationConfiguration());
            modelBuilder.ApplyConfiguration(new DoctorVisitationConfiguration());
            modelBuilder.ApplyConfiguration(new DoctorConfiguration());
        }
    }
}