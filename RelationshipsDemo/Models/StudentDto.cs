namespace RelationshipsDemo.Models
{
    public class StudentDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<CourseDto> Courses { get; set; }
    }
}
