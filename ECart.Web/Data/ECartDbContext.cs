using ECart.Web.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace ECart.Web.Data
{
    public class ECartDbContext : DbContext
    {
        public ECartDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }
    }
}
