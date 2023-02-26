
using BlazorAppShop.Server.Services.CategoryService;
using BlazorAppShop.Shared;
using Microsoft.AspNetCore.Mvc;

namespace BlazorAppShop.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : Controller
    {
        public ICategoryService _categoryService{ get; set; }
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Category>>> GetCategories()
        {
            return Ok(await _categoryService.GetCategoriesAsync());
        }

    }
}
