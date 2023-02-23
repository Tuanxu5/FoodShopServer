using foodshop.Data;
using foodshop.Modal;
using foodshop.Service.ProductCategorys;

namespace foodshop.Service.Orders
{
    public class OrderService : IOrderService
    {
        public readonly OrderDbContext _orderDbContext;

        public OrderService(OrderDbContext orderDbContext)
        {
            _orderDbContext = orderDbContext;
        }
        public bool AddOrder(Order order)
        {
            _orderDbContext.Orders.Add(order);
            _orderDbContext.SaveChanges();
            return true;
        }

        public bool DeleteOrder(string id)
        {
            Order order = _orderDbContext.Orders.Find(id);
            _orderDbContext.Orders.Remove(order);
            _orderDbContext.SaveChanges();
            return true;
        }

        public List<Order> GetOrder()
        {
            return _orderDbContext.Orders.ToList();
        }

        public bool UpdateOrder(Order order)
        {
            _orderDbContext.Orders.Update(order);
            _orderDbContext.SaveChanges();
            return true;
        }
    }
}
