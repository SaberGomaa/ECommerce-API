using ECommerce_API.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Models
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "*")]
        public int Quantity { get; set; }

        ///
        public int customer_id { get; set; }
        public int product_id { get; set; }

        [ForeignKey("product_id")]
        public Products Product { get; set; }

        [ForeignKey("customer_id")]
        public customer customer { get; set; }

    }
}
