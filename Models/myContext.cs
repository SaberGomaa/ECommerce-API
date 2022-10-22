using Microsoft.EntityFrameworkCore;

namespace ECommerce_API.Models
{
    public class myContext : DbContext
    {
        public DbSet<Products> products { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Data source = SABER;Initial catalog = ECommerceAPI;Integrated security = true");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
