﻿namespace P01_HospitalDatabase.Data.Models
{
    public class Medicament
    {
        public Guid MedicamentId { get; set; }
        public string? Name { get; set; }
        public ICollection<PatientMedicament>? Prescriptions { get; set; }
    }
}