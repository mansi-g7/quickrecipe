using Microsoft.AspNetCore.Mvc;

namespace quickrecipe.Controllers
{
    public class UserController : Controller
    {
        // This action will handle your Home Page
        public IActionResult Index()
        {
            return View();
        }

        // You can add your other actions here
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
    }
}
