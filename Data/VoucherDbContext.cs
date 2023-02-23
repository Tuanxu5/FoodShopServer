using foodshop.Configuration;
using foodshop.Modal;
using foodshop.Seeder;
using Microsoft.EntityFrameworkCore;

namespace foodshop.Data
{
    public class VoucherDbContext : DbContext
    {
        public VoucherDbContext(DbContextOptions<VoucherDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new VoucherConfiguration());
            modelBuilder.Seed();
        }
        public DbSet<Voucher> Vouchers { get; set; }
    }
}
