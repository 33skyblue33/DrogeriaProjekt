using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DrogeriaProjekt.Models
{
    [Table("ShoppingCartItems")]
    public class ShoppingCartItem
    {
        [Key]
        public int ShoppingCartItemId { get; set; }
        [ForeignKey("ShoppingCartId")]
        public int ShoppingCartId { get; set; }
        [ForeignKey("ProductId")]
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public ShoppingCart ShoppingCart { get; set; }
        public Product Product { get; set; }
    }
}
