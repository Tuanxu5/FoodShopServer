using foodshop.Modal;

namespace foodshop.Service.Orders
{
    public interface IOrderService
    {
        List<Order> GetOrder();
        Boolean AddOrder(Order order);
        Boolean UpdateOrder(Order order);
        Boolean DeleteOrder(string id);
        
    }
}
