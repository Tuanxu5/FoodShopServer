using foodshop.Data;
using foodshop.Modal;
using System.Drawing;
using System.Linq;

namespace foodshop.Service.Stores
{
    public class StoreService : IStoreService
    {
        public readonly StoreDbContext _storeDbContext;
        public readonly OrderDbContext _orderDbContext;
        public StoreService(StoreDbContext storeDbContext, OrderDbContext orderDbContext)
        {
            _storeDbContext = storeDbContext;
            _orderDbContext = orderDbContext;
        }
        public bool AddStore(Store store)
        {
            _storeDbContext.Stores.Add(store);
            _storeDbContext.SaveChanges();
            return true;
        }

        public bool DeleteStore(int id)
        {
            throw new NotImplementedException();
        }

        public List<Store> GetStore()
        {
            return _storeDbContext.Stores.OrderByDescending(x=>x.id).ToList();
        }


        public bool UpdateStore(Store store)
        {
            throw new NotImplementedException();
        }
        public List<Store> GetDetailStore(int id)
        {
            return _storeDbContext.Stores.Where(n => n.id == id).ToList();
        }
    }
}
