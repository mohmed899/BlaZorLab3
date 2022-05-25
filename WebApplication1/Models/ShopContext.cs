using Microsoft.EntityFrameworkCore;
using Shared;

namespace WebApplication1.Models
{
    public class ShopContext : DbContext
    {
        public ShopContext()
        {
        }
        public ShopContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Category> categories { get; set; }
        public DbSet<Product> products { get; set; }

    }
}
