namespace P01_HospitalDatabase.Data.Models
{
    public class Diagnose
    {
        public Guid DiagnoseId { get; set; }
        public string? Name { get; set; }
        public string? Comments { get; set; }
        public Guid PatientId { get; set; }
        public Patient? Patient { get; set; }
    }
}