using Microsoft.EntityFrameworkCore;
using P01_StudentSystem.Data;
using P01_StudentSystem.Data.Models;

namespace StudentSystem_ConsoleApp_.Services
{
    public class StudentService
    {
        public static async Task ShowAllStudentsAsync()
        {
            using StudentSystemContext studentSystemDb = new();

            List<Student> students = await studentSystemDb.Students.AsNoTracking()
                .Include(s => s.HomeworkSubmissions)
                .ToListAsync();

            students.ForEach(student =>
            {
                Console.WriteLine("{\n" + $"Name: {student.Name}\n" +
                    $"Birthday: {student.Birthday}\n" +
                    $"PhoneNumber: {student.PhoneNumber}\n" +
                    $"RegisteredOn: {student.RegisteredOn}");

                if(student.HomeworkSubmissions is not null)
                {
                    Console.WriteLine("\nHomework Submissions: ");

                    foreach(Homework homeworkSubmission in student.HomeworkSubmissions)
                    {
                        Console.WriteLine("   {\n" + $"   Content: {homeworkSubmission.Content}\n" +
                            $"   ContentType: {homeworkSubmission.ContentType}\n" +
                            $"   SubmissionTime: {homeworkSubmission.SubmissionTime}\n" + "   }\n");
                    }
                }

                Console.WriteLine("}\n");
            });


        }
    }
}