using DrogeriaProjekt.Models;

namespace DrogeriaProjekt.Services.Models.Interfaces
{
    public interface IProductService
    {
        public Task<ICollection<Product>> GetAllProductsAsync();
        public Task<ICollection<Product>> GetProductsByQueryAsync(string query);
        public Task<bool> AddProductAsync(Product product);
        public Task<bool> UpdateProductAsync(Product product);
        public Task<bool> RemoveProductAsync(Product product);
    }
}
