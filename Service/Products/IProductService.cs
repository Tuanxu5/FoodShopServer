using foodshop.Modal;

namespace foodshop.Service.Products
{
    public interface IProductService
    {
        List<Product> GetProduct();
        Boolean AddProduct(Product product);
        Boolean UpdateProduct(Product product);
        Boolean DeleteProduct(int id);
        List<Product> GetProductDetail(int id);
        List<Product> GetProductDetailStore(int store_id,int product_category_id);
    }
}
