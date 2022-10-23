using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Models
{
    public class customer
    {
        [Key]
        public int Id { get; set; }
        public string FName { get; set; }

        public string LName { get; set; }

        public string Email { get; set; }

        [Required(ErrorMessage = "*")]
        public string Password { get; set; }



        public string Address  { get; set; }

        public string Img { get; set; }


        public string Phone { get; set; }

        public ICollection<Order> orders { get; set; }
        public ICollection<Cart> carts { get; set; }
        public ICollection<admin> admins { get; set; }



    }
}
