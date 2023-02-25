using Microsoft.AspNetCore.Mvc;

namespace BlazorAppShop.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
