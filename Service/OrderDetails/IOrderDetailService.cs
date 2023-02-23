using foodshop.Modal;

namespace foodshop.Service.OrderDetails
{
    public interface IOrderDetailService
    {
        List<OrderDetail> GetOrderDetail();
        Boolean AddOrderDetail(OrderDetail orderDetail);
        Boolean UpdateOrderDetail(OrderDetail orderDetail);
        Boolean DeleteOrderDetail(int id);
        List<OrderDetail> GetOrderDeatailId(string order_id);
    }
}
