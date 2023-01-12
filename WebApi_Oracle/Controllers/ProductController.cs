using Microsoft.AspNetCore.Mvc;
using WebApi_Oracle.Models;
using WebApi_Oracle.Services;

namespace WebApi_Oracle.Controllers
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
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _productService.GetAllProducts();
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> Post(Product product)
        {
            await _productService.CreateProduct(product);
            return Ok();
        }
    }
}
