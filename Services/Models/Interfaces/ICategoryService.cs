using DrogeriaProjekt.Models;

namespace DrogeriaProjekt.Services.Models.Interfaces
{
    public interface ICategoryService
    {
        public Task<List<Category>> GetAllCategoriesAsync();
        public Task<List<Product>> GetAllProductsAsync(Category category);
    }
}
