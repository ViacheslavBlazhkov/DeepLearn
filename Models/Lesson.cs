namespace DeepLearn.Models
{
    public class Lesson
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Status Status { get; set; } = Status.Closed;
        public int ModuleId { get; set; }
    }
}
