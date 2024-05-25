using BannersAPI.Models;

namespace BannersAPI.Interfaces
{
    public interface ICategoryService
    {
        GetCategoryResponse GetCategory(GetCategoryRequest request);

        CreateCategoryResponse CreateCategory(CategoryModel request);

        UpdateCategoryResponse UpdateCategory(UpdateCategoryRequest request);

        DeleteCategoryResponse DeleteCategory(DeleteCategoryRequest request);
    }
}
