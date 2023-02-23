using foodshop.Configuration;
using foodshop.Seeder;
using Microsoft.EntityFrameworkCore;

namespace foodshop.Modal
{
    public class ProductCategoryDbContext : DbContext
    {
        public ProductCategoryDbContext(DbContextOptions<ProductCategoryDbContext> option) : base(option)
        {
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductCategoryConfiguration());
            modelBuilder.Seed();
        }
        public DbSet<ProductCategory> ProductCategories { get; set; }
    }
}
