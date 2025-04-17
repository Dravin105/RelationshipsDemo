using RelationshipsDemo.Models;

namespace RelationshipsDemo.Business_Layer
{
    public interface IService
    {
        Task<List<StudentDto>> GetAllStudentsAsync();
        Task<StudentDto> GetStudentByIdAsync(int id);
        Task<StudentDto> CreateStudentAsync(CreateStudentDto studentDto);
    }
}
