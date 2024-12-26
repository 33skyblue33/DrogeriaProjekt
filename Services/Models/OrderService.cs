using DrogeriaProjekt.Models;
using DrogeriaProjekt.Services.Models.Interfaces;

namespace DrogeriaProjekt.Services.Models
{
    public class OrderService : IOrderService
    {
        private readonly IDatabaseService DatabaseService;

        public OrderService(IDatabaseService databaseService)
        {
            DatabaseService = databaseService;
        }

        public Task<bool> AddItemAsync(OrderItem item)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AddOrderAsync(Order order)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<OrderItem>> GetAllItemsAsync(Order order)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Order>> GetAllOrdersAsync(User user)
        {
            throw new NotImplementedException();
        }

        public Task<int> GetDaysToOrderDeliveryAsync(Order order)
        {
            throw new NotImplementedException();
        }

        public Task<float> GetTotalOrderPrice(Order order)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveItemAsync(OrderItem item)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveOrderAsync(Order order)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateItemAsync(OrderItem item)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateOrderAsync(Order order)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ValidateOrderPaymentStatusAsync(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
