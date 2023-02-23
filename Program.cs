using foodshop.Data;
using foodshop.Modal;
using foodshop.Service.Includeds;
using foodshop.Service.OrderDetails;
using foodshop.Service.Orders;
using foodshop.Service.ProductCategorys;
using foodshop.Service.Products;
using foodshop.Service.Sizes;
using foodshop.Service.StoreCategoriess;
using foodshop.Service.Stores;
using foodshop.Service.Userss;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ProductCategoryDbContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("FoodShopDatabase"));
});
builder.Services.AddTransient<IProductCategoryService, ProductCategoryService>();


builder.Services.AddDbContext<ProductDbContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("FoodShopDatabase"));
});
builder.Services.AddTransient<IProductService, ProductService>();


builder.Services.AddDbContext<StoreDbContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("FoodShopDatabase"));
});
builder.Services.AddTransient<IStoreService, StoreService>();


builder.Services.AddDbContext<OrderDbContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("FoodShopDatabase"));
});
builder.Services.AddTransient<IOrderService, OrderService>();

//build OrderDetail
builder.Services.AddDbContext<OrderDetailDbContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("FoodShopDatabase"));
});
builder.Services.AddTransient<IOrderDetailService, OrderDetailService>();

builder.Services.AddDbContext<UsersDbContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("FoodShopDatabase"));
});
builder.Services.AddTransient<IUsersService, UsersService>();

builder.Services.AddDbContext<SizeDbContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("FoodShopDatabase"));
});
builder.Services.AddTransient<ISizeService, SizeService>();


builder.Services.AddDbContext<IncludedDbContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("FoodShopDatabase"));
});
builder.Services.AddTransient<IIncludedService, IncludedService>();

builder.Services.AddDbContext<StoreCategoriesDbContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("FoodShopDatabase"));
});
builder.Services.AddTransient<IStoreCategoriesService, StoreCategoriesService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(builder =>
    {
        builder
        .AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader();
    }
);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
