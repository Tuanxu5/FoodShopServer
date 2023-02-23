using foodshop.Modal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace foodshop.Data
{
    public class StoreCategoriesDbContextFactory: IDesignTimeDbContextFactory<StoreCategoriesDbContext>
    {
        public StoreCategoriesDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configurationRoot = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var connectionString = configurationRoot.GetConnectionString("FoodShopDatabase");

            var optionBuilder = new DbContextOptionsBuilder<StoreCategoriesDbContext>();
            optionBuilder.UseSqlServer(connectionString);

            return new StoreCategoriesDbContext(optionBuilder.Options);
        }
    }
}
