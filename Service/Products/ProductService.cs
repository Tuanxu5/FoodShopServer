using foodshop.Data;
using foodshop.Modal;

namespace foodshop.Service.Products
{
    public class ProductService : IProductService
    {
        public readonly ProductDbContext _productDbContext;

        public ProductService(ProductDbContext productDbContext)
        {
            _productDbContext = productDbContext;
        }
        public bool AddProduct(Product product)
        {
            _productDbContext.Products.Add(product);
            _productDbContext.SaveChanges();
            return true;
        }

        public bool DeleteProduct(int id)
        {
            Product product = _productDbContext.Products.Find(id);
            _productDbContext.Products.Remove(product);
            _productDbContext.SaveChanges();
            return true;
        }

        public List<Product> GetProduct()
        {
            return _productDbContext.Products.OrderByDescending(p => p.id).ToList();
        }

        public bool UpdateProduct(Product product)
        {
            _productDbContext.Products.Update(product);
            _productDbContext.SaveChanges();
            return true;
        }
        public List<Product> GetProductDetailStore(int store_id,int product_category_id)
        {
            return _productDbContext.Products.Where(n => n.store_id == store_id && n.product_category_id == product_category_id).ToList();
        }
        public List<Product> GetProductDetail(int id)
        {
            return _productDbContext.Products.Where(n => n.id == id).ToList();
        }
    }
}
