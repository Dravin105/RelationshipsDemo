using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RelationshipsDemo.Data;
using RelationshipsDemo.OneToOneRelationShipModel;

namespace RelationshipsDemo.OneToOneRelationShipService
{
    public class OneToOneRelationService: IOneToOneRelationService
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public OneToOneRelationService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<UserDto> GetUserByIdAsync(int userId)
        {
            var user = await _context.Users.Include(u => u.Profiles).FirstOrDefaultAsync(u => u.UserId == userId);
            return _mapper.Map<UserDto>(user);
        }

        public async Task<UserDto> CreateUserAsync(CreateUserDto userDto)
        {
            var user = _mapper.Map<User>(userDto);
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            return _mapper.Map<UserDto>(user);
        }

        public async Task<UserDto> UpdateUserAsync(int userId, UserDto userDto)
        {
            var user = await _context.Users.Include(u => u.Profiles).FirstOrDefaultAsync(u => u.UserId == userId);
            if (user == null) return null;

            _mapper.Map(userDto, user);
            await _context.SaveChangesAsync();
            return _mapper.Map<UserDto>(user);
        }

        public async Task<bool> DeleteUserAsync(int userId)
        {
            var user = await _context.Users.FindAsync(userId);
            if (user == null) return false;

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<List<UserDto>> GetAllUserAsync()
        {
            var user = await _context.Users.Include(c => c.Profiles).ToListAsync();
            return _mapper.Map<List<UserDto>>(user);
        }
    }
    
}
