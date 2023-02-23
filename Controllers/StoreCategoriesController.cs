using foodshop.Modal;
using foodshop.Service.Includeds;
using foodshop.Service.StoreCategoriess;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace foodshop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoreCategoriesController : ControllerBase
    {
        private readonly IStoreCategoriesService _storeCategoriesService;

        public StoreCategoriesController(IStoreCategoriesService storeCategoriesService)
        {
            _storeCategoriesService = storeCategoriesService;
        }
        // GET: api/<StoreCategoriesController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_storeCategoriesService.GetStoreCategories());
        }

        // GET api/<StoreCategoriesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<StoreCategoriesController>
        [HttpPost]
        public IActionResult Post(StoreCategories storeCategories)
        {
            return Ok(_storeCategoriesService.AddStoreCategories(storeCategories));
        }

        // PUT api/<StoreCategoriesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StoreCategoriesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
