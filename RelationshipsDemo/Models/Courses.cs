namespace RelationshipsDemo.Models
{
    public class Courses
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
    }
}
