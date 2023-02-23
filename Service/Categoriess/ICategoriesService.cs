using foodshop.Modal;

namespace foodshop.Service.Categoriess
{
    public interface ICategoriesService
    {
        List<Categories> GetCategories();
        Boolean AddCategories(Categories categories);
        Boolean UpdateCategories(Categories categories);
        Boolean DeleteCategories(int id);
    }
}
