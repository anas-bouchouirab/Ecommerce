using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Ecommerce.Models.Product> Product { get; set; } = default!;
        public DbSet<Ecommerce.Models.ProductTypes> ProductTypes { get; set; } = default!;

        public DbSet<Ecommerce.Models.ShoppingCart> ShoppingCarts { get; set; } = default!;
        public DbSet<Ecommerce.Models.CartDetail> CartDetails { get; set; } = default!;
        public DbSet<Ecommerce.Models.Order> Orders { get; set; } = default!;
        public DbSet<Ecommerce.Models.OrderDetail> OrderDetails { get; set; } = default!;

        public DbSet<Ecommerce.Models.OrderStatus> orderStatuses { get; set; } = default!;
    }
}
