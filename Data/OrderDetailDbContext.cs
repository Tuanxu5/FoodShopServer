using foodshop.Configuration;
using foodshop.Modal;
using foodshop.Seeder;
using Microsoft.EntityFrameworkCore;

namespace foodshop.Data
{
    public class OrderDetailDbContext : DbContext
    {
        public OrderDetailDbContext(DbContextOptions<OrderDetailDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new OrderDetailConfiguration());
            modelBuilder.Seed();
        }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}
