using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DrogeriaProjekt.Models
{
    [Table("Offers")]
    public class Offer
    {
        [Key]
        public int OfferId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Discount { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; } 
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
