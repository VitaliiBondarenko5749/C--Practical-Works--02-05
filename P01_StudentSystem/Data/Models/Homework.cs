namespace P01_StudentSystem.Data.Models
{
    public class Homework
    {
        public Guid HomeworkId { get; set; }
        public string? Content { get; set; }
        public string? ContentType { get; set; }
        public DateTime SubmissionTime { get; set; }

        public Guid StudentId { get; set; }
        public Student? Student { get; set; }

        public Guid CourseId { get; set; }
        public Course? Course { get; set; }
    }
}