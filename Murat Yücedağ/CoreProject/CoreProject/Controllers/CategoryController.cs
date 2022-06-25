using Microsoft.AspNetCore.Mvc;

namespace CoreProject.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
