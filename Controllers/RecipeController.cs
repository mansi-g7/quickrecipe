using Microsoft.AspNetCore.Mvc;

namespace quickrecipe.Controllers
{
    public class RecipeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult add()
        {
            return View();
        }
        public IActionResult edit()
        {
            return View();
        }
        public IActionResult delete()
        {
            return View();
        }
    }
}
