namespace P01_HospitalDatabase.Data.Models
{
    public class DoctorVisitation
    {
        public Guid DoctorId { get; set; }
        public Doctor? Doctor { get; set; }
        public Guid VisitationId { get; set; }
        public Visitation? Visitation { get; set; }
    }
}