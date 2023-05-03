using Bogus;
using P01_StudentSystem.Data.Models;
using P01_StudentSystem.Data.Models.Enums;

namespace P01_StudentSystem.Seeding
{
    public static class DataSeeder
    {
        public static List<Course> Courses { get; private set; } = null!;
        public static List<Student> Students { get; private set; } = null!;
        public static List<Homework> HomeworkSubmissions { get; private set; } = null!;
        public static List<Resource> Resources { get; private set; } = null!;
        public static List<StudentCourse> StudentCourses { get; private set; } = null!;

        static DataSeeder()
        {
            if (Courses is null && Students is null && HomeworkSubmissions is null && Resources is null && StudentCourses is null)
            {
                InitializeData();
            }
        }

        private static void InitializeData()
        {
            Faker<Course> courseFaker = GetCourseGenerator();
            Faker<Student> studentFaker = GetStudentGenerator();
            Faker<Homework> homeworkFaker = GetHomeworkGenerator();
            Faker<Resource> resourceFaker = GetResourceGenerator();
            Faker<StudentCourse> studentCourseFaker = GetStudentCourseGenerator();

            Courses = courseFaker.Generate(10);
            Students = studentFaker.Generate(10);
            HomeworkSubmissions = homeworkFaker.Generate(15);
            Resources = resourceFaker.Generate(10);
            StudentCourses = studentCourseFaker.Generate(5);
        }

        private static Faker<Course> GetCourseGenerator()
        {
            return new Faker<Course>()
                .RuleFor(c => c.CourseId, _ => Guid.NewGuid())
                .RuleFor(c => c.Name, f => f.Company.CatchPhrase())
                .RuleFor(c => c.Description, f => f.Lorem.Paragraph())
                .RuleFor(c => c.StartDate, f => f.Date.Soon())
                .RuleFor(c => c.EndDate, f => f.Date.Soon(30))
                .RuleFor(c => c.Price, f => f.Finance.Random.Decimal(50, 500));
        }

        private static Faker<Student> GetStudentGenerator()
        {
            return new Faker<Student>().RuleFor(student => student.StudentId, Guid.NewGuid)
            .RuleFor(student => student.Name, faker => faker.Name.FullName())
            .RuleFor(student => student.PhoneNumber, faker => faker.Phone.PhoneNumber())
            .RuleFor(student => student.RegisteredOn, faker => faker.Date.Past())
            .RuleFor(student => student.Birthday, faker => faker.Date
            .Between(DateTime.Now.AddYears(-30), DateTime.Now.AddYears(-18)));
        }

        private static Faker<Homework> GetHomeworkGenerator()
        {
            return new Faker<Homework>().RuleFor(h => h.HomeworkId, _ => Guid.NewGuid())
                .RuleFor(h => h.Content, f => f.Lorem.Paragraph())
                .RuleFor(h => h.ContentType, f => f.Random.Enum<ContentTypes>().ToString())
                .RuleFor(h => h.SubmissionTime, f => f.Date.Between(DateTime.UtcNow.AddDays(-7), DateTime.UtcNow))
                .RuleFor(h => h.StudentId, f => f.PickRandom(Students).StudentId)
                .RuleFor(h => h.CourseId, f => f.PickRandom(Courses).CourseId);
        }

        private static Faker<Resource> GetResourceGenerator()
        {
            return new Faker<Resource>().RuleFor(r => r.ResourceId, _ => Guid.NewGuid())
                .RuleFor(r => r.Name, f => f.Lorem.Word())
                .RuleFor(r => r.Url, f => f.Internet.Url())
                .RuleFor(r => r.ResourceType, f => f.Random.Enum<ResourceTypes>().ToString())
                .RuleFor(r => r.CourseId, f => f.PickRandom(Courses).CourseId);
        }

        private static Faker<StudentCourse> GetStudentCourseGenerator()
        {
            return new Faker<StudentCourse>().RuleFor(sc => sc.StudentId, f => f.PickRandom(Students).StudentId)
                .RuleFor(sc => sc.CourseId, f => f.PickRandom(Courses).CourseId);
        }
    }
}