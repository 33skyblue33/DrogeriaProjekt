using DrogeriaProjekt.Models;

namespace DrogeriaProjekt.Services.Models.Interfaces
{
    public interface IOrderService
    {
        public Task<ICollection<Order>> GetAllOrdersAsync(User user);
        public Task<ICollection<OrderItem>> GetAllItemsAsync(Order order);
        public Task<bool> AddItemAsync(OrderItem item);
        public Task<bool> UpdateItemAsync(OrderItem item);
        public Task<bool> RemoveItemAsync(OrderItem item);
        public Task<bool> AddOrderAsync(Order order);
        public Task<bool> UpdateOrderAsync(Order order);
        public Task<bool> RemoveOrderAsync(Order order);
        public Task<bool> ValidateOrderPaymentStatusAsync(Order order);
        public Task<int> GetDaysToOrderDeliveryAsync(Order order);
        public Task<float> GetTotalOrderPrice(Order order);
    }
}
