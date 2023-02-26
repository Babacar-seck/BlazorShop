using BlazorAppShop.Server.Services.ProductService;
using BlazorAppShop.Shared;
using Microsoft.AspNetCore.Mvc;

namespace BlazorAppShop.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {

        public IProductService _productService { get; set; }

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetAllProducts() 
        {
            return Ok(await _productService.GetAllProducts());
        }

        [HttpGet("Category/{categoryUrl}")]
        public async Task<ActionResult<List<Product>>> GetProductsByCategoryUrl(string categoryUrl)
        {
            return Ok(await _productService.GetProductsByCategory(categoryUrl));
        }


        [HttpGet("{Id}")]
        public async Task<ActionResult<List<Product>>> GetProductById(int Id)
        {
            return Ok(await _productService.GetProductById(Id));
        }




    }
}
