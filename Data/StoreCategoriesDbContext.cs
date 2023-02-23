using foodshop.Configuration;
using foodshop.Modal;
using foodshop.Seeder;
using Microsoft.EntityFrameworkCore;

namespace foodshop.Data
{
    public class StoreCategoriesDbContext: DbContext
    {
        public StoreCategoriesDbContext(DbContextOptions<StoreCategoriesDbContext> option) : base(option)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StoreCategoriesConfiguration());
            modelBuilder.Seed();
        }
        public DbSet<StoreCategories> StoreCategoriess { get; set; }
    }
}
