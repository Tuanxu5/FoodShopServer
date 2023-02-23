using foodshop.Modal;
using foodshop.Service.Includeds;
using foodshop.Service.Products;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace foodshop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IncludedController : ControllerBase
    {
        private readonly IIncludedService _includedService;

        public IncludedController(IIncludedService includedService)
        {
            _includedService = includedService;
        }
        // GET: api/<IncludedController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_includedService.GetIncluded());
        }

        // GET api/<IncludedController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<IncludedController>
        [HttpPost]
        public IActionResult Post(Included included)
        {
            return Ok(_includedService.AddIncluded(included));
        }

        // PUT api/<IncludedController>/5
        [HttpPut()]
        public IActionResult Put(Included included)
        {
            return Ok(_includedService.UpdateIncluded(included));
        }

        // DELETE api/<IncludedController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_includedService.DeleteIncluded(id));
        }
    }
}
