using foodshop.Data;
using foodshop.Modal;

namespace foodshop.Service.OrderDetails
{
    public class OrderDetailService : IOrderDetailService
    {
        public readonly OrderDetailDbContext _orderDetailDbContext;

        public OrderDetailService(OrderDetailDbContext orderDetailDbContext)
        {
            _orderDetailDbContext = orderDetailDbContext;
        }
        public bool AddOrderDetail(OrderDetail orderDetail)
        {
            _orderDetailDbContext.OrderDetails.Add(orderDetail);
            _orderDetailDbContext.SaveChanges();
            return true;
        }

        public bool DeleteOrderDetail(int id)
        {
            throw new NotImplementedException();
        }

        public List<OrderDetail> GetOrderDetail()
        {
            return _orderDetailDbContext.OrderDetails.ToList();
        }

        public bool UpdateOrderDetail(OrderDetail orderDetail)
        {
            throw new NotImplementedException();
        }
        public List<OrderDetail> GetOrderDeatailId(string order_id)
        {
            return _orderDetailDbContext.OrderDetails.Where(n => n.order_id == order_id).ToList();
        }
    }
}
