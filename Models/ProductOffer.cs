using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DrogeriaProjekt.Models
{
    [Table("ProductOffers")]
    [Keyless]
    public class ProductOffer
    {
        [ForeignKey("ProductId")]
        public int ProductId { get; set; }
        [ForeignKey("OfferId")]
        public Product Product { get; set; }
        public Offer Offer { get; set; }
    }
}
