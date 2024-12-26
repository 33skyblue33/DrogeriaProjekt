using DrogeriaProjekt.Models;
using DrogeriaProjekt.Services.Models.Interfaces;

namespace DrogeriaProjekt.Services.Models
{
    public class ProductService : IProductService
    {
        private readonly IDatabaseService DatabaseService;

        public ProductService(IDatabaseService databaseService)
        {
            DatabaseService = databaseService;
        }

        public Task<bool> AddProductAsync(Product product)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Product>> GetAllProductsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Product>> GetProductsByQueryAsync(string query)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveProductAsync(Product product)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateProductAsync(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
