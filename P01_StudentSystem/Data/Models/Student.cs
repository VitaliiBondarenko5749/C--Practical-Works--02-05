namespace P01_StudentSystem.Data.Models
{
    public class Student
    {
        public Guid StudentId { get; set; }
        public string? Name { get; set; }
        public string? PhoneNumber { get; set; }
        public DateTime RegisteredOn { get; set; }
        public DateTime? Birthday { get; set; }

        public ICollection<StudentCourse>? StudentCourses { get; set; }
        public ICollection<Homework>? HomeworkSubmissions { get; set; }
    }
}