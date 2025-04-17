namespace RelationshipsDemo.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Navigation property
        public virtual ICollection<Courses> Courses { get; set; }
    }
}
