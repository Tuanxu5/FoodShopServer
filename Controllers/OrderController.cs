using foodshop.Modal;
using foodshop.Service.Orders;
using foodshop.Service.ProductCategorys;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace foodshop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }
        // GET: api/<OrderController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_orderService.GetOrder());
        }

        // GET api/<OrderController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<OrderController>
        [HttpPost]
        public IActionResult Post(Order order)
        {
            return Ok(_orderService.AddOrder(order));
        }

        // PUT api/<OrderController>/5
        [HttpPut()]
        public IActionResult Put(Order order)
        {
            return Ok(_orderService.UpdateOrder(order));
        }

        // DELETE api/<OrderController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            return Ok(_orderService.DeleteOrder(id));
        }
    }
}
