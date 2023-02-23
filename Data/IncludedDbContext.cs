using foodshop.Configuration;
using foodshop.Modal;
using foodshop.Seeder;
using Microsoft.EntityFrameworkCore;

namespace foodshop.Data
{
    public class IncludedDbContext : DbContext
    {
        public IncludedDbContext(DbContextOptions<IncludedDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new IncludedConfiguration());
            modelBuilder.Seed();
        }
        public DbSet<Included> Includeds { get; set; }
    }
}
