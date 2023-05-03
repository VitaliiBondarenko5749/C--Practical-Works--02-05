using Microsoft.EntityFrameworkCore;
using P01_StudentSystem.Data;
using P01_StudentSystem.Data.Models;

namespace StudentSystem_ConsoleApp_.Services
{
    public static class CourseService
    {
        public static async Task ShowAllCoursesAsync()
        {
            Console.WriteLine("All courses: ");

            using StudentSystemContext studentSystemDb = new();
#pragma warning disable CS8620 // Argument cannot be used for parameter due to differences in the nullability of reference types.
            List<Course>? courses = await studentSystemDb.Courses.AsNoTracking()
                .Include(c => c.Resources)
                .Include(c => c.StudentCourses)
                .ThenInclude(sc => sc.Student).ToListAsync();
#pragma warning restore CS8620 // Argument cannot be used for parameter due to differences in the nullability of reference types.

            courses.ForEach(c =>
            {
                Console.WriteLine("{\n" + $"Name: {c.Name}\n" +
                    $"Description: {c.Description}\n" +
                    $"StartDate: {c.StartDate}\n" +
                    $"EndDate: {c.EndDate}\n" +
                    $"Price: {c.Price}\n");

                if (c.Resources is not null && c.Resources.Count() > 0)
                {
                    Console.WriteLine("Resources: ");

                    foreach (Resource resource in c.Resources)
                    {
                        Console.WriteLine($"Name: {resource.Name}\n" +
                            $"Url: {resource.Url}\n" +
                            $"ResourceType: {resource.ResourceType}\n");
                    }
                }

                if (c.StudentCourses is not null && c.StudentCourses.Count() > 0)
                {
                    Console.WriteLine("Students: ");

                    foreach (StudentCourse studentCourse in c.StudentCourses)
                    {
                        if (studentCourse.Student is not null)
                        {
                            Console.WriteLine($"Name: {studentCourse.Student.Name}\n" +
                                $"PhoneNumber: {studentCourse.Student.PhoneNumber}\n" +
                                $"RegisteredOn: {studentCourse.Student.RegisteredOn}\n" +
                                $"Birthday: {studentCourse.Student.Birthday}\n");
                        }
                    }
                }

                Console.WriteLine("}\n");
            });
        }
    }
}