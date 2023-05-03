// Task 2. Hospital Database Modification

namespace P01_HospitalDatabase.Data.Models
{
    public class Doctor
    {
        public Guid DoctorId { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Specialty { get; set; }
        public ICollection<DoctorVisitation>? DoctorVisitations { get; set; }
    }
}