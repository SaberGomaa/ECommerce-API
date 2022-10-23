using Microsoft.EntityFrameworkCore;

namespace ECommerce_API.Models
{
    public class myContext : DbContext
    {
        public myContext(DbContextOptions<myContext> options)
           : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data source = SABER ; User Id = saber ; Password = 123456789;Initial catalog = EcommerceAPI;");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Products> products { get; set; }

    }
}
