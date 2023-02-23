using foodshop.Modal;
using foodshop.Service.Stores;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace foodshop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoreController : ControllerBase
    {
        private readonly IStoreService _storeService;

        public StoreController(IStoreService storeService)
        {
            _storeService = storeService;
        }
        // GET: api/<StoreController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_storeService.GetStore());
        }

        // GET api/<StoreController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_storeService.GetDetailStore(id));
        }

        // POST api/<StoreController>
        [HttpPost]
        public IActionResult Post(Store store)
        {
            return Ok(_storeService.AddStore(store));
        }

        // PUT api/<StoreController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StoreController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
