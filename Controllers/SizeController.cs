using foodshop.Modal;
using foodshop.Service.Products;
using foodshop.Service.Sizes;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace foodshop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SizeController : ControllerBase
    {
        private readonly ISizeService _sizeService;

        public SizeController(ISizeService sizeService)
        {
            _sizeService = sizeService;
        }
        // GET: api/<SizeController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_sizeService.GetSize());
        }

        // GET api/<SizeController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SizeController>
        [HttpPost]
        public IActionResult Post(Size size)
        {
            return Ok(_sizeService.AddSize(size));
        }

        // PUT api/<SizeController>/5
        [HttpPut()]
        public IActionResult Put(Size size)
        {
            return Ok(_sizeService.UpdateSize(size));
        }

        // DELETE api/<SizeController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_sizeService.DeleteSize(id));
        }
    }
}
