using foodshop.Modal;

namespace foodshop.Service.ProductCategorys
{
    public class ProductCategoryService : IProductCategoryService
    {
        public readonly ProductCategoryDbContext _productCategoryDbContext;

        public ProductCategoryService(ProductCategoryDbContext productCategoryDbContext)
        {
            _productCategoryDbContext = productCategoryDbContext;
        }
        public bool AddProductCategory(ProductCategory productCategory)
        {
            _productCategoryDbContext.ProductCategories.Add(productCategory);
            _productCategoryDbContext.SaveChanges();
            return true;
        }

        public bool DeleteProductCategory(int id)
        {
            ProductCategory productCategory = _productCategoryDbContext.ProductCategories.Find(id);
            _productCategoryDbContext.ProductCategories.Remove(productCategory);
            _productCategoryDbContext.SaveChanges();
            return true;
        }

        public List<ProductCategory> GetProductCategory()
        {
            return _productCategoryDbContext.ProductCategories.ToList();
        }

        public bool UpdateProductCategory(ProductCategory productCategory)
        {
            _productCategoryDbContext.ProductCategories.Update(productCategory);
            _productCategoryDbContext.SaveChanges();
            return true;
        }
        public List<ProductCategory> GetProductCategoryStore(int id)
        {
            return _productCategoryDbContext.ProductCategories.Where(n => n.store_id == id).ToList();
        }
    }
}
