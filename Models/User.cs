using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DrogeriaProjekt.Models
{
    [Table("Users")]
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Verified { get; set; }
        public bool Admin { get; set; }

        public ShoppingCart ShoppingCart { get; set; }
        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }

    public class ClientUser
    {
        public int UserId { get; set; }
        public string Email { get; set; }
        public bool Verified { get; set; }
        public bool Admin { get; set; }

        public ShoppingCart ShoppingCart { get; set; }
        public ICollection<Order> Orders { get; set; } = new List<Order>();
        public ClientUser(User user)
        {
            UserId = user.UserId; 
            Email = user.Email;
            Verified = user.Verified;
            Admin = user.Admin;
            ShoppingCart = user.ShoppingCart;
            Orders = user.Orders; 
        }
    }



}
