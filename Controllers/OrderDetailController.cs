using foodshop.Modal;
using foodshop.Service.OrderDetails;
using foodshop.Service.Orders;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace foodshop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailController : ControllerBase
    {
        private readonly IOrderDetailService _orderDetailService;

        public OrderDetailController(IOrderDetailService orderDetailService)
        {
            _orderDetailService = orderDetailService;
        }
        // GET: api/<OrderDetailController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_orderDetailService.GetOrderDetail());
        }

        // GET api/<OrderDetailController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<OrderDetailController>
        [HttpPost]
        public IActionResult Post(OrderDetail orderDetail)
        {
            return Ok(_orderDetailService.AddOrderDetail(orderDetail));
        }

        // PUT api/<OrderDetailController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<OrderDetailController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        [HttpGet("GetOrderDeatailId/{order_id}")]
        public IActionResult GetOrderDeatailId(string order_id)
        {
            return Ok(_orderDetailService.GetOrderDeatailId(order_id));
        }
    }
}
