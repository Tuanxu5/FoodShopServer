using foodshop.Data;
using foodshop.Modal;

namespace foodshop.Service.Stores
{
    public interface IStoreService
    {
        List<Store> GetStore();
        Boolean AddStore(Store store);
        Boolean UpdateStore(Store store);
        Boolean DeleteStore(int id);
        List<Store> GetDetailStore(int id);
    }
}
