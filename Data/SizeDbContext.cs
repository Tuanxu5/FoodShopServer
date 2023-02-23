using foodshop.Configuration;
using foodshop.Modal;
using foodshop.Seeder;
using Microsoft.EntityFrameworkCore;

namespace foodshop.Data
{
    public class SizeDbContext : DbContext
    {
        public SizeDbContext(DbContextOptions<SizeDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SizeConfiguration());
            modelBuilder.Seed();
        }
        public DbSet<Size> Sizes { get; set; }
    }
}
