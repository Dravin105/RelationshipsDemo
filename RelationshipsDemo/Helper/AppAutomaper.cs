using AutoMapper;
using RelationshipsDemo.Models;
using RelationshipsDemo.Models.Dto;
using RelationshipsDemo.OneToManyRelationShipModel.Dto;
using RelationshipsDemo.OneToManyRelationShipModel;
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

            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<CreateCategoryDto, Category>().ReverseMap();
            CreateMap<CreateProdectDto, Product>().ReverseMap();

        }
    }
}
