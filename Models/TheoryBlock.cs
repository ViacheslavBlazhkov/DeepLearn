namespace DeepLearn.Models
{
    public class TheoryBlock
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Status Status { get; set; } = Status.Closed;
        public int LessonId { get; set; }
    }
}
