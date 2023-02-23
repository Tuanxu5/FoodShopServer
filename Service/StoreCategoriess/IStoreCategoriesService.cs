using foodshop.Modal;

namespace foodshop.Service.StoreCategoriess
{
    public interface IStoreCategoriesService
    {
        List<StoreCategories> GetStoreCategories();
        Boolean AddStoreCategories(StoreCategories storeCategories);
    }
}
