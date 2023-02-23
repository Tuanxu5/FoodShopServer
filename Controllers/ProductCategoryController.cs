using foodshop.Modal;
using foodshop.Service.ProductCategorys;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace foodshop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductCategoryController : ControllerBase
    {
        private readonly IProductCategoryService _productCategoryService;

        public ProductCategoryController(IProductCategoryService productCategoryService)
        {
            _productCategoryService = productCategoryService;
        }

        // GET: api/<CategoryController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_productCategoryService.GetProductCategory());
        }

        // GET api/<CategoryController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CategoryController>
        [HttpPost]
        public IActionResult Post(ProductCategory productCategory)
        {
            return Ok(_productCategoryService.AddProductCategory(productCategory));
        }

        // PUT api/<CategoryController>/5
        [HttpPut()]
        public IActionResult Put(ProductCategory productCategory)
        {
            return Ok(_productCategoryService.UpdateProductCategory(productCategory));
        }

        // DELETE api/<CategoryController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_productCategoryService.DeleteProductCategory(id));
        }

        [HttpGet("GetProductCategoryStore/{id}")]
        public IActionResult GetProductCategoryStore(int id)
        {
            return Ok(_productCategoryService.GetProductCategoryStore(id));
        }
    }
}
