using foodshop.Data;
using foodshop.Modal;
using System.Drawing;

namespace foodshop.Service.Includeds
{
    public class IncludedService : IIncludedService
    {
        public readonly IncludedDbContext _includedDbContext;

        public IncludedService(IncludedDbContext includedDbContext)
        {
            _includedDbContext = includedDbContext;
        }
        public bool AddIncluded(Included included)
        {
            _includedDbContext.Includeds.Add(included);
            _includedDbContext.SaveChanges();
            return true;
        }
        public bool DeleteIncluded(int id)
        {
            Included included = _includedDbContext.Includeds.Find(id);
            _includedDbContext.Includeds.Remove(included);
            _includedDbContext.SaveChanges();
            return true;
        }

        public List<Included> GetIncluded()
        {
            return _includedDbContext.Includeds.ToList();
        }

        public bool UpdateIncluded(Included included)
        {
            _includedDbContext.Includeds.Update(included);
            _includedDbContext.SaveChanges();
            return true;
        }
    }
}
