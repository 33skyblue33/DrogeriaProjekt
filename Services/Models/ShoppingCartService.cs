using DrogeriaProjekt.Models;
using DrogeriaProjekt.Services.Models.Interfaces;

namespace DrogeriaProjekt.Services.Models
{
    public class ShoppingCartService : IShoppingCartService
    {
        private readonly IDatabaseService DatabaseService;

        public ShoppingCartService(IDatabaseService databaseService)
        {
            DatabaseService = databaseService;
        }

        public Task<bool> AddItemsToCartAsync(ShoppingCart cart, params ShoppingCartItem[] item)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ClearCartAsync(ShoppingCart cart)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<ShoppingCartItem>> GetAllItems(ShoppingCart cart)
        {
            throw new NotImplementedException();
        }

        public Task<float> GetTotalCartPrice(ShoppingCart cart)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveItemFromCartAsync(ShoppingCart cart, ShoppingCartItem item)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateItemInCartAsync(ShoppingCart cart, ShoppingCartItem item)
        {
            throw new NotImplementedException();
        }
    }
}
