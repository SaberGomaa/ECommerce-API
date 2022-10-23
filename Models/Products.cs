using ECommerce.Models;
using System.ComponentModel.DataAnnotations;

namespace ECommerce_API.Models
{
    public class Products
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public double Price { get; set; }
        public string Img { get; set; }

        public string Color { get; set; } // drop downlist Options
        public string Size { get; set; } // drop downlist Options

        public int Quantity { get; set; }
        public string? Details { get; set; }

        public string Category { get; set; }

        public ICollection<Order> orders { get; set; }
        public ICollection<Cart> carts { get; set; }
        public ICollection<admin> admins { get; set; }

    }
}
