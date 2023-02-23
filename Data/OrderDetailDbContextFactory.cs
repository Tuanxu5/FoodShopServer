using foodshop.Modal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace foodshop.Data
{
    public class OrderDetailDbContextFactory : IDesignTimeDbContextFactory<OrderDetailDbContext>
    {
        public OrderDetailDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configurationRoot = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var connectionString = configurationRoot.GetConnectionString("FoodShopDatabase");

            var optionBuilder = new DbContextOptionsBuilder<OrderDetailDbContext>();
            optionBuilder.UseSqlServer(connectionString);

            return new OrderDetailDbContext(optionBuilder.Options);
        }
    }
}

