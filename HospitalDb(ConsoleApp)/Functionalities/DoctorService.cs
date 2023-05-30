using HospitalDb_ConsoleApp_.Enums;
using Microsoft.EntityFrameworkCore;
using P01_HospitalDatabase.Data;
using P01_HospitalDatabase.Data.Models;
using System.Security.Cryptography;
using System.Text;

namespace HospitalDb_ConsoleApp_.Functionalities
{
    public static class DoctorService
    {
        public static async Task<Doctor?> Register()
        {
            Doctor doctor = new() { DoctorId = Guid.NewGuid() };

            Console.Write("\n\nEnter ID of your specialty: ");

#nullable disable
            int specialityId = int.Parse(Console.ReadLine());
#nullable enable

            if (DoctorSpecialities.Specialist.Equals((DoctorSpecialities)specialityId))
            {
                doctor.Specialty = DoctorSpecialities.Specialist.ToString();
            }
            else if (DoctorSpecialities.Director.Equals((DoctorSpecialities)specialityId))
            {
                doctor.Specialty = DoctorSpecialities.Director.ToString();
            }
            else
            {
                Console.WriteLine("You've entered the wrong specialty. Access denied!");

                return null;
            }

            Console.Write("Name: ");

            doctor.Name = Console.ReadLine();

            Console.Write("Email: ");

            doctor.Email = Console.ReadLine();

            Console.Write("Password: ");

            string? password = Console.ReadLine();

            if (password is not null)
            {
                CreatePasswordHash(password, out byte[] passwordHash, out byte[] passwordSalt);

                doctor.Password = Convert.ToBase64String(passwordHash) + "|" + Convert.ToBase64String(passwordSalt);

                // Add Role

                using (HospitalContext hospitalDb = new())
                {
                    await hospitalDb.Doctors.AddAsync(doctor);

                    await hospitalDb.SaveChangesAsync();
                }

                Console.WriteLine($"You've registered successfully as {doctor.Specialty}!");

                return doctor;
            }
            else
            {
                Console.WriteLine("Password cannot be empty!");
            }

            return null;
        }

        public static async Task<Doctor?> Login()
        {
            Console.Write("\nEmail: ");

            string? email = Console.ReadLine();

            Console.Write("Password: ");

            string? password = Console.ReadLine();

            if (password is not null)
            {
                using (HospitalContext hospitalDb = new())
                {
                    Doctor? doctor = await hospitalDb.Doctors.SingleOrDefaultAsync(d => d.Email == email);

#nullable disable
                    bool verifiedPassword = VerifyPasswordHash(password, doctor.Password);
#nullable enable

                    if(!verifiedPassword && doctor is null)
                    {
                        Console.WriteLine("Authentication error!");

                        return null;
                    }
                    else 
                    {
                        return doctor;
                    }
                }
            }
            else
            {
                Console.WriteLine("Incorrect password!");
            }

            return null;
        }

        private static bool VerifyPasswordHash(string password, string passwordHashString)
        {
            byte[] passwordHash, passwordSalt;
            GetPasswordHashAndSalt(passwordHashString, out passwordHash, out passwordSalt);

            using (var hmac = new HMACSHA512(passwordSalt))
            {
                byte[] computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != passwordHash[i])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private static void GetPasswordHashAndSalt(string passwordHashString, out byte[] passwordHash, out byte[] passwordSalt)
        {
            string[] hashAndSalt = passwordHashString.Split('|');
            passwordHash = Convert.FromBase64String(hashAndSalt[0]);
            passwordSalt = Convert.FromBase64String(hashAndSalt[1]);
        }

        private static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (HMACSHA512 hmac = new())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }
    }
}