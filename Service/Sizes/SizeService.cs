using foodshop.Data;
using foodshop.Modal;
using foodshop.Service.Products;

namespace foodshop.Service.Sizes
{
    public class SizeService : ISizeService
    {
        public readonly SizeDbContext _sizeDbContext;

        public SizeService(SizeDbContext sizeDbContext)
        {
            _sizeDbContext = sizeDbContext;
        }
        public bool AddSize(Size size)
        {
            _sizeDbContext.Sizes.Add(size);
            _sizeDbContext.SaveChanges();
            return true;
        }

        public bool DeleteSize(int id)
        {
            Size size = _sizeDbContext.Sizes.Find(id);
            _sizeDbContext.Sizes.Remove(size);
            _sizeDbContext.SaveChanges();
            return true;
        }

        public List<Size> GetSize()
        {
            return _sizeDbContext.Sizes.OrderByDescending(p => p.id).ToList();
        }

        public bool UpdateSize(Size size)
        {
            _sizeDbContext.Sizes.Update(size);
            _sizeDbContext.SaveChanges();
            return true;
        }
    }
}
