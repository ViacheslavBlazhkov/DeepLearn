namespace DeepLearn.Models
{
    public class Module
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Status Status { get; set; } = Status.Closed;
    }
}
