//using foodshop.Configuration;
//using foodshop.Seeder;
using Microsoft.EntityFrameworkCore;

namespace foodshop.Modal
{
    public class CategoriesDbContext : DbContext
    {
        public CategoriesDbContext(DbContextOptions<CategoriesDbContext> options) : base(options)
        {
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
            //modelBuilder.ApplyConfiguration(new CategoriesConfiguration());
            //modelBuilder.Seed();
        //}
        public DbSet<Categories> Categoriess { get; set; }
    }
}
