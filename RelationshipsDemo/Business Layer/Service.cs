using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RelationshipsDemo.Data;
using RelationshipsDemo.Models;
using RelationshipsDemo.Models.Dto;

namespace RelationshipsDemo.Business_Layer
{
    public class Service:IService
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public Service(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<StudentDto>> GetAllStudentsAsync()
        {
            var students = await _context.Students.Include(s => s.Courses).ToListAsync();
            return _mapper.Map<List<StudentDto>>(students);
        }

        public async Task<StudentDto> GetStudentByIdAsync(int id)
        {
            var student = await _context.Students.Include(s => s.Courses)
                                                 .FirstOrDefaultAsync(s => s.Id == id);
            return _mapper.Map<StudentDto>(student);
        }

        public async Task<StudentDto> CreateStudentAsync(CreateStudentDto studentDto)
        {
            var student = _mapper.Map<Student>(studentDto);

            _context.Students.Add(student);
            await _context.SaveChangesAsync();

            return _mapper.Map<StudentDto>(student);
        }
    }
}

