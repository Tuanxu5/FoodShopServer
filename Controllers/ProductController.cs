using foodshop.Modal;
using foodshop.Service.Products;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace foodshop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        // GET: api/<ProductController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_productService.GetProduct());
        }

        // GET api/<ProductController>/5
        [HttpGet("GetProductDetail/{id}")]
        public IActionResult GetProductDetail(int id)
        {
            return Ok(_productService.GetProductDetail(id));
        }

        // POST api/<ProductController>
        [HttpPost]
        public IActionResult Post(Product product)
        {
            return Ok(_productService.AddProduct(product));
        }

        // PUT api/<ProductController>/5
        [HttpPut()]
        public IActionResult Put(Product product)
        {
            return Ok(_productService.UpdateProduct(product));
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_productService.DeleteProduct(id));
        }
        [HttpGet("GetProductDetailStore/{store_id}")]
        public IActionResult GetProductDetailStore(int store_id, int product_category_id)
        {
            return Ok(_productService.GetProductDetailStore(store_id, product_category_id));
        }
    }
}
