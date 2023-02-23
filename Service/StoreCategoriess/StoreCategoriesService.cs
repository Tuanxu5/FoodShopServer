using foodshop.Data;
using foodshop.Modal;
using System.Drawing;

namespace foodshop.Service.StoreCategoriess
{
    public class StoreCategoriesService : IStoreCategoriesService
    {
        public readonly StoreCategoriesDbContext _storeCategoriesDbContext;

        public StoreCategoriesService(StoreCategoriesDbContext storeCategoriesDbContext)
        {
            _storeCategoriesDbContext = storeCategoriesDbContext;
        }
        public bool AddStoreCategories(StoreCategories storeCategories)
        {
            _storeCategoriesDbContext.StoreCategoriess.Add(storeCategories);
            _storeCategoriesDbContext.SaveChanges();
            return true;
        }

        public List<StoreCategories> GetStoreCategories()
        {
            return _storeCategoriesDbContext.StoreCategoriess.OrderByDescending(p => p.id).ToList();
        }
    }
}
