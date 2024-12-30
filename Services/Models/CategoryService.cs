using DrogeriaProjekt.Models;
using DrogeriaProjekt.Services.Models.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DrogeriaProjekt.Services.Models
{
    public class CategoryService : ICategoryService
    {
        private readonly IDatabaseService DatabaseService;

        public CategoryService(IDatabaseService databaseService)
        {
            DatabaseService = databaseService;

            var test = new List<Category>()
            {
                new() { Name="Hair" },
                new() { Name="Body" },
                new() { Name="Make-up" },
                new() { Name="Nails" },
                new() { Name="Men" },
                new() { Name="Home" },
                new() { Name="Self-Care" }
            };

            var current = DatabaseService.DatabaseContext.Categories.ToList();
            DatabaseService.DatabaseContext.Categories.RemoveRange(current);
            DatabaseService.DatabaseContext.SaveChanges();
            DatabaseService.DatabaseContext.Categories.AddRange(test);
            DatabaseService.DatabaseContext.SaveChanges();
        }

        public Task<List<Category>> GetAllCategoriesAsync()
        {
            return DatabaseService.DatabaseContext.Categories.ToListAsync();
        }

        public Task<List<Product>> GetAllProductsAsync(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
