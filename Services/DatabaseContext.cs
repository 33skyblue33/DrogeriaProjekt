using DrogeriaProjekt.Models;
using Microsoft.EntityFrameworkCore;

namespace DrogeriaProjekt.Services
{
    public class DatabaseContext : DbContext, IDatabaseContext
    {
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderItem> OrderItems { get; set; }
        public virtual DbSet<Offer> Offers { get; set; }
        public virtual DbSet<ProductOffer> ProductOffers { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public virtual DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
    
        public DatabaseContext() : base() { }
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }
    }
}
