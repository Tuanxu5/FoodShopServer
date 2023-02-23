using foodshop.Configuration;
using foodshop.Modal;
using foodshop.Seeder;
using Microsoft.EntityFrameworkCore;

namespace foodshop.Data
{
    public class VoucherProductDbContext : DbContext
    {
        public VoucherProductDbContext(DbContextOptions<VoucherProductDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new VoucherProductConfiguration());
            modelBuilder.Seed();
        }
        public DbSet<VoucherProduct> VoucherProducts { get; set; }
    }
}
