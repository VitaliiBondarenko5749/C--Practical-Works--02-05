using Microsoft.EntityFrameworkCore;
using P01_HospitalDatabase.Data;
using P01_HospitalDatabase.Data.Models;

namespace HospitalDb_ConsoleApp_.Functionalities;

public static class HospitalService
{
    public static async Task AddPatientAsync()
    {
        Patient patient = new() { PatientId = Guid.NewGuid() };

        Console.Write("\nFirst Name: ");

        patient.FirstName = Console.ReadLine();

        Console.Write("Last Name: ");

        patient.LastName = Console.ReadLine();

        Console.Write("Address: ");

        patient.Address = Console.ReadLine();

        Console.Write("Email: ");

        patient.Email = Console.ReadLine();

        Console.Write("Has insurance? (y/n): ");

        patient.HasInsurance = Console.ReadKey().KeyChar == 'y';

        using (HospitalContext hospitalDb = new())
        {
            await hospitalDb.Patients.AddAsync(patient);

            await hospitalDb.SaveChangesAsync();
        }

        Console.WriteLine("\nPatient has been added successfully!");
    }

    public static async Task ViewPatientInfoAsync()
    {
        Console.Write("\nId: ");

        bool isGuid = Guid.TryParse(Console.ReadLine(), out Guid patientId);

        if (!isGuid)
        {
            Console.WriteLine("Error: You have enterend a wrong symbols, that are not \"Guid\" type!");

            return;
        }

        Patient? patient = null;

        using (HospitalContext hospitalDb = new())
        {
#pragma warning disable CS8620 // Argument cannot be used for parameter due to differences in the nullability of reference types.
            patient = await hospitalDb.Patients
    .Include(p => p.Diagnoses)
    .Include(p => p.Prescriptions)
        .ThenInclude(pr => pr.Medicament)
    .Include(p => p.Visitations)
    .SingleOrDefaultAsync(p => p.PatientId == patientId);
#pragma warning restore CS8620 // Argument cannot be used for parameter due to differences in the nullability of reference types.

            if (patient is null)
            {
                Console.WriteLine($"Patient with id: {patientId} does not exist.");

                return;
            }
        }

        Console.WriteLine($"[\nFull name: {patient.FirstName + " " + patient.LastName}\n" +
            $"Address: {patient.Address}\n" +
            $"Email: {patient.Email}\n" +
            $"Has insurance: {patient.HasInsurance}");

        if (patient.Diagnoses != null && patient.Diagnoses.Count > 0)
        {
            Console.WriteLine("\nDiagnoses: ");

            foreach (Diagnose diagnose in patient.Diagnoses)
            {
                Console.WriteLine($"Diagnose: {diagnose.Name}\n" +
                    $"Comments: {diagnose.Comments}");
            }
        }

        if (patient.Visitations != null && patient.Visitations.Count > 0)
        {
            Console.WriteLine("\nVisitations: ");

            foreach (Visitation visitation in patient.Visitations)
            {
                Console.WriteLine($"Date: {visitation.Date.Day}.{visitation.Date.Month}.{visitation.Date.Year}\n" +
                    $"Comments: {visitation.Comments}");
            }
        }

        if (patient.Prescriptions != null && patient.Prescriptions.Count > 0)
        {
            Console.WriteLine("\nMedicaments: ");

            foreach (PatientMedicament patientMedicament in patient.Prescriptions)
            {
                if (patientMedicament.Medicament is not null)
                {
                    Console.WriteLine($"Name: {patientMedicament.Medicament.Name}");
                }
            }
        }

        Console.WriteLine("]");
    }

    public static async Task AddVisitationForPatientAsync(Doctor doctor)
    {
        Console.Write("\nId: ");

        bool isGuid = Guid.TryParse(Console.ReadLine(), out Guid patientId);

        if (!isGuid)
        {
            Console.WriteLine("Error: You have enterend a wrong symbols, that are not \"Guid\" type!");

            return;
        }

        using (HospitalContext hospitalDb = new())
        {
            Patient? patient = await hospitalDb.Patients.AsNoTracking()
                .SingleOrDefaultAsync(p => p.PatientId == patientId);

            if (patient is null)
            {
                Console.WriteLine($"Patient with id: {patientId} does not exist.");

                return;
            }

            Visitation visitation = new()
            {
                VisitationId = Guid.NewGuid(),
                PatientId = patientId,
                Date = DateTime.Now,
            };

            Console.WriteLine("Your comment: ");

            visitation.Comments = Console.ReadLine();

            await hospitalDb.Visitations.AddAsync(visitation);

            DoctorVisitation doctorVisitation = new()
            {
                DoctorId = doctor.DoctorId,
                VisitationId = visitation.VisitationId
            };

            await hospitalDb.DoctorVisitations.AddAsync(doctorVisitation);

            await hospitalDb.SaveChangesAsync();
        }

        Console.WriteLine("Visitation has been added.");
    }

    public static async Task AddDiagnosisForPatientAsync()
    {
        Console.Write("\nId: ");

        bool isGuid = Guid.TryParse(Console.ReadLine(), out Guid patientId);

        if (!isGuid)
        {
            Console.WriteLine("Error: You have enterend a wrong symbols, that are not \"Guid\" type!");

            return;
        }

        using (HospitalContext hospitalDb = new())
        {
            Patient? patient = await hospitalDb.Patients.AsNoTracking()
                .SingleOrDefaultAsync(p => p.PatientId == patientId);

            if (patient is null)
            {
                Console.WriteLine($"Patient with id: {patientId} does not exist.");

                return;
            }

            Diagnose diagnose = new()
            {
                DiagnoseId = Guid.NewGuid(),
                PatientId = patientId
            };

            Console.Write("\nName: ");

            diagnose.Name = Console.ReadLine();

            Console.WriteLine("Your comment: ");

            diagnose.Comments = Console.ReadLine();

            await hospitalDb.Diagnoses.AddAsync(diagnose);

            await hospitalDb.SaveChangesAsync();
        }

        Console.WriteLine("Diagnose has been added.");
    }

    public static async Task AddMedicamentsForPatientAsync()
    {
        Console.Write("\nId: ");

        bool isGuid = Guid.TryParse(Console.ReadLine(), out Guid patientId);

        if (!isGuid)
        {
            Console.WriteLine("Error: You have enterend a wrong symbols, that are not \"Guid\" type!");

            return;
        }

        using (HospitalContext hospitalDb = new())
        {
            Patient? patient = await hospitalDb.Patients.AsNoTracking()
                .SingleOrDefaultAsync(p => p.PatientId == patientId);

            if (patient is null)
            {
                Console.WriteLine($"Patient with id: {patientId} does not exist.");

                return;
            }

            Console.WriteLine("Enter medicament name to add it for patient or \"exit\" to stop finding medicaments!");

            while (true)
            {
                Console.Write("Name: ");

                string? medicamentName = Console.ReadLine();

                if (medicamentName == "exit")
                {
                    break;
                }

                Medicament? medicament = await hospitalDb.Medicaments.AsNoTracking()
                    .SingleOrDefaultAsync(m => m.Name == medicamentName);

                if (medicament is null)
                {
                    Console.WriteLine($"Medicament with name \"{medicamentName}\" does not exist.");
                }
                else
                {
                    PatientMedicament patientMedicament = new()
                    {
                        PatientId = patientId,
                        MedicamentId = medicament.MedicamentId
                    };

                    await hospitalDb.Prescriptions.AddAsync(patientMedicament);

                    Console.WriteLine($"Medicament has been added for patient: {patient.FirstName + " " + patient.LastName}");
                }
            }

            await hospitalDb.SaveChangesAsync();
        }
    }

    public static async Task AddMedicamentAsync()
    {
        Console.Write("Name: ");

        string? medicamentName = Console.ReadLine();

        using (HospitalContext hospitalDb = new())
        {
            Medicament? medicament = await hospitalDb.Medicaments.AsNoTracking()
                .SingleOrDefaultAsync(m => m.Name == medicamentName);

            if (medicament is null)
            {
                medicament = new() { Name = medicamentName, MedicamentId = Guid.NewGuid() };

                await hospitalDb.Medicaments.AddAsync(medicament);

                await hospitalDb.SaveChangesAsync();

                Console.WriteLine($"Medicament \"{medicamentName}\" has been added!");
            }
            else
            {
                Console.WriteLine("Medicament is already exist.");
            }
        }
    }

    public static async Task ShowPatientListAsync()
    {
        using (HospitalContext hospitalDb = new())
        {
            ICollection<Patient> patients = await hospitalDb.Patients.AsNoTracking()
                .ToListAsync();

            if(patients is null)
            {
                Console.WriteLine("Patient list is empty!");

                return;
            }

            Console.WriteLine("\nPatients: ");

            foreach(Patient patient in patients)
            {
                Console.WriteLine(patient.PatientId + " - " + patient.FirstName + " " + patient.LastName);
            }
        }
    }

    public static async Task ShowMedicamentListAsync()
    {
        using (HospitalContext hospitalDb = new())
        {
            ICollection<Medicament> medicaments = await hospitalDb.Medicaments.AsNoTracking()
                .ToListAsync();

            if(medicaments is null)
            {
                Console.WriteLine("Medicament list is empty!");

                return;
            }

            Console.WriteLine("\nMedicaments: ");

            foreach(Medicament medicament in medicaments)
            {
                Console.WriteLine(medicament.Name);
            }
        }
    }
}