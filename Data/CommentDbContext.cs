using foodshop.Configuration;
using foodshop.Seeder;
using Microsoft.EntityFrameworkCore;

namespace foodshop.Modal
{
    public class CommentDbContext : DbContext
    {
        public CommentDbContext(DbContextOptions<CommentDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CommentConfiguration());
            modelBuilder.Seed();
        }
        public DbSet<Comment> Comments { get; set; }
    }
}
