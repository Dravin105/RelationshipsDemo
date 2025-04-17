using AutoMapper;
using RelationshipsDemo.Models;

namespace RelationshipsDemo.Helper
{
    public class AppAutomaper:Profile
    {
        public AppAutomaper()
        {
            CreateMap<Student, StudentDto>().ReverseMap();
            CreateMap<Courses, CourseDto>().ReverseMap();

            CreateMap<CreateStudentDto, Student>().ReverseMap();
            CreateMap<CreateCourseDto, Courses>().ReverseMap();
        }
    }
}
