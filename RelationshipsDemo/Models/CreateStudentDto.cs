namespace RelationshipsDemo.Models
{
    public class CreateStudentDto
    {
        public string Name { get; set; }
        public List<CreateCourseDto> Courses { get; set; }
    }
}
