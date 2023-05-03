namespace P01_HospitalDatabase.Data.Models
{
    public class PatientMedicament
    {
        public Guid PatientId { get; set; }
        public Patient? Patient { get; set; }
        public Guid MedicamentId { get; set; }
        public Medicament? Medicament { get; set; }
    }
}