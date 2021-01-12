using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace Web.Models
{
    public class ApplicationDBContext : IdentityDbContext<User, IdentityRole<int>, int>
    {
        public DbSet<Computer> Computers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Laptop> Laptops { get; set; }
        public DbSet<Periphery> Peripherys { get; set; }
        public DbSet<Manipulator> Manipulators { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Acoustic> Acoustics { get; set; }
        public DbSet<ShopCartItem> ShopCartItem { get; set; }
        public DbSet<Remont> Remonts { get; set; }

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

    }
}