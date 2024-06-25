using DapperProject.Dtos.CategoryDtos;

namespace DapperProject.Service
{
    public interface ICategoryService
    {
        Task<List<ResultCategoryDto>> GetAllCategoryAsync ();
        Task CreateCategoryAsync (CreateCategoryDto createCategoryDto);
        Task UpdateCategoryAsync (UpdateCategoryDto updateCategoryDto);
        Task DeleteCategoryAsync (int id);
        Task<GetByIdCategoryDto> GetCategoryAsync (int id);
    }
}
