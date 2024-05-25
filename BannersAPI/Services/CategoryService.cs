using BannersAPI.Models;

namespace BannersAPI.Services
{
    public class CategoryService
    {





        public DeleteCategoryResponse DeleteCategory(DeleteCategoryRequest deletecategoryRequest)
        {
            var categoryDelete = _context.Categories.Find(DeleteCategoryRequest.Id);
            if (categoryDelete == null) 
            {
                throw new DbUpdateException($"Category with id '{DeleteCategoryRequest.Id}' doesn't exist.");
            }
            _context.Categories.Remove(categoryToDelete);
            _context.SaveChanges();

            return new DeleteCategoryResponse();
        }
    }
}
