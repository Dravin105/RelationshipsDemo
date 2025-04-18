using AutoMapper;
using RelationshipsDemo.Models;
using RelationshipsDemo.Models.Dto;
using RelationshipsDemo.OneToOneRelationShipModel;

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

            CreateMap<UserDto, User>().ReverseMap();
            CreateMap<ProfileDto, Profiles>().ReverseMap();
            CreateMap<CreateUserDto, User>().ReverseMap();
            CreateMap<CreateProfileDto, Profiles>().ReverseMap();

        }
    }
}
