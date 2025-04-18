using RelationshipsDemo.OneToOneRelationShipModel;

namespace RelationshipsDemo.OneToOneRelationShipService
{
    public interface IOneToOneRelationService
    {
        Task<UserDto> GetUserByIdAsync(int userId);
        Task<List<UserDto>> GetAllUserAsync();
        Task<UserDto> UpdateUserAsync(int userId, UserDto userDto);
        Task<bool> DeleteUserAsync(int userId);
        Task<UserDto> CreateUserAsync(CreateUserDto userDto);
    }
}
