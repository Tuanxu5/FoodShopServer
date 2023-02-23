using foodshop.Modal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace foodshop.Data
{
    public class CategoriesDbContextFactory : IDesignTimeDbContextFactory<CategoriesDbContext>
    {
        public CategoriesDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configurationRoot = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var connectionString = configurationRoot.GetConnectionString("FoodShopDatabase");

            var optionBuilder = new DbContextOptionsBuilder<CategoriesDbContext>();
            optionBuilder.UseSqlServer(connectionString);

            return new CategoriesDbContext(optionBuilder.Options);
        }
    }
}
