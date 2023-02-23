using foodshop.Modal;

namespace foodshop.Service.Includeds
{
    public interface IIncludedService
    {
        List<Included> GetIncluded();
        Boolean AddIncluded(Included included);
        Boolean UpdateIncluded(Included included);
        Boolean DeleteIncluded(int id);
    }
}
