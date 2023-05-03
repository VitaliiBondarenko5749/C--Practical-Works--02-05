namespace P01_StudentSystem.Data.Models
{
    public class Resource
    {
        public Guid ResourceId { get; set; }
        public string? Name { get; set; }
        public string? Url { get; set; }
        public string? ResourceType { get; set; }
        public Guid CourseId { get; set; }
        public Course? Course { get; set; }
    }
}