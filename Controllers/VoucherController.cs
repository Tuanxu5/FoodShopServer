using foodshop.Data;
using foodshop.Service.Products;
using foodshop.Service.Vouchers;
using foodshop.Service.VouchersService;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace foodshop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VoucherController : ControllerBase
    {
        private readonly IVoucherService _voucherService;

        public VoucherController(IVoucherService voucherService)
        {
            _voucherService = voucherService;
        }
        // GET: api/<VoucherController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<VoucherController>/5
        [HttpGet("{id}")]
        public IActionResult GetVoucher()
        {
            return Ok(_voucherService.GetVoucher());
        }

        // POST api/<VoucherController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<VoucherController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<VoucherController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
