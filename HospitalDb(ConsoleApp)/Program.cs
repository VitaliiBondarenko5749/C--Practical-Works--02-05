using HospitalDb_ConsoleApp_.Enums;
using HospitalDb_ConsoleApp_.Functionalities;
using P01_HospitalDatabase.Data.Models;

namespace HospitalDatabase_ConsoleApplication
{
    internal class Program
    {
        private static readonly Operations[] operations = (Operations[])Enum.GetValues(typeof(Operations));

        private async static Task Main(string[] args)
        {
            Console.Write("To login or to register? (l/r): ");

            char authenticationChoice = Console.ReadKey().KeyChar;

            Doctor? doctor = authenticationChoice.Equals('l') ? await DoctorService.Login()
                : authenticationChoice.Equals('r') ? await DoctorService.Register() : null;

            if (doctor is null)
            {
                return;
            }

            Console.WriteLine($"Welcome {doctor.Name}!\n");

            Menu();

            while (true)
            {
                Console.Write("\nCommand: ");

                bool isNumber = int.TryParse(Console.ReadLine(), out int number);

                if (!isNumber || number < (int)operations.Min() || number > (int)operations.Max())
                {
                    if (!isNumber)
                    {
                        Console.WriteLine("Error: The entered value is not \"int\" type!");
                    }

                    if (number < (int)operations.Min() || number > (int)operations.Max())
                    {
                        Console.WriteLine("Error: The entered number does not exist in the command list!");
                    }

                    await OutputLoading();

                    Console.Clear();

                    Menu();

                    continue;
                }

                Operations operation = (Operations)number;

                if (operation.Equals(Operations.Exit))
                {
                    break;
                }

#nullable disable

                switch (operation)
                {
                    case Operations.AddPatient:
                        {
                            if (!doctor.Specialty.Equals(DoctorSpecialities.Specialist.ToString()))
                            {
                                Console.WriteLine("Access denied!");
                                break;
                            }

                            await HospitalService.AddPatientAsync();
                            break;
                        }
                    case Operations.ViewPatientInfo:
                        {
                            await HospitalService.ViewPatientInfoAsync();
                            break;
                        }
                    case Operations.AddVisitationForPatient:
                        {
                            if (!doctor.Specialty.Equals(DoctorSpecialities.Specialist.ToString()))
                            {
                                Console.WriteLine("Access denied!");
                                break;
                            }

                            await HospitalService.AddVisitationForPatientAsync(doctor);
                            break;
                        }
                    case Operations.AddDiagnosisForPatient:
                        {
                            if (!doctor.Specialty.Equals(DoctorSpecialities.Specialist.ToString()))
                            {
                                Console.WriteLine("Access denied!");
                                break;
                            }

                            await HospitalService.AddDiagnosisForPatientAsync();
                            break;
                        }
                    case Operations.AddMedicamentForPatient:
                        {
                            if (!doctor.Specialty.Equals(DoctorSpecialities.Specialist.ToString()))
                            {
                                Console.WriteLine("Access denied!");
                                break;
                            }

                            await HospitalService.AddMedicamentsForPatientAsync();
                            break;
                        }
                    case Operations.ViewPatients:
                        {
                            await HospitalService.ShowPatientListAsync();
                            break;
                        }
                    case Operations.ViewMedicaments:
                        {
                            await HospitalService.ShowMedicamentListAsync();
                            break;
                        }
                    case Operations.AddMedicament:
                        {
                            if (!doctor.Specialty.Equals(DoctorSpecialities.Specialist.ToString()))
                            {
                                Console.WriteLine("Access denied!");
                                break;
                            }

                            await HospitalService.AddMedicamentAsync();
                            break;
                        }
                    case Operations.ClearTheConsole:
                        {
                            Console.Clear();
                            Menu();
                            break;
                        }
                }
            }

            Console.WriteLine("\nPress one more time to exit!");

            Console.ReadKey();
        }

        private static void Menu()
        {
            foreach (Operations operation in operations)
            {
                Console.WriteLine($"{(int)operation}. {operation}");
            }
        }

        private static async Task OutputLoading()
        {
            Console.Write("\nLOADING");

            for (int i = 0; i < 5; ++i)
            {
                await Task.Delay(1000);

                Console.Write(".");
            }
        }
    }
}