using RelationshipsDemo.OneToManyRelationShipModel.Dto;

namespace RelationshipsDemo.OneToManyRelationShipService
{
    public interface ICategoryService
    {
        Task<CategoryDto> GetCategoryByIdAsync(int categoryId);
        Task<IEnumerable<CategoryDto>> GetAllCategoriesAsync();
        Task<CategoryDto> CreateCategoryAsync(CreateCategoryDto CategoryDto);
        Task<CategoryDto> UpdateCategoryAsync(int categoryId, CategoryDto categoryDto);
        Task<bool> DeleteCategoryAsync(int categoryId);
    }
}
