using foodshop.Modal;

namespace foodshop.Service.Sizes
{
    public interface ISizeService
    {
        List<Size> GetSize();
        Boolean AddSize(Size size);
        Boolean UpdateSize(Size size);
        Boolean DeleteSize(int id);
    }
}
