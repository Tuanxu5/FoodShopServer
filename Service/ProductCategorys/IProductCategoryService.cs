using foodshop.Modal;
namespace foodshop.Service.ProductCategorys
{
    public interface IProductCategoryService
    {
        List<ProductCategory> GetProductCategory();
        Boolean AddProductCategory(ProductCategory productCategory);
        Boolean UpdateProductCategory(ProductCategory productCategory);
        Boolean DeleteProductCategory(int id);
        List<ProductCategory> GetProductCategoryStore(int id);
    }
}
