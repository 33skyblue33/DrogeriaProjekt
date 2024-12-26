using DrogeriaProjekt.Models;

namespace DrogeriaProjekt.Services.Models.Interfaces
{
    public interface IShoppingCartService
    {
        public Task<ICollection<ShoppingCartItem>> GetAllItems(ShoppingCart cart);
        public Task<bool> AddItemsToCartAsync(ShoppingCart cart, params ShoppingCartItem[] item);
        public Task<bool> UpdateItemInCartAsync(ShoppingCart cart, ShoppingCartItem item);
        public Task<bool> RemoveItemFromCartAsync(ShoppingCart cart, ShoppingCartItem item);
        public Task<bool> ClearCartAsync(ShoppingCart cart);
        public Task<float> GetTotalCartPrice(ShoppingCart cart);
    }
}
