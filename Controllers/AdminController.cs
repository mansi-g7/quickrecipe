//using Microsoft.AspNetCore.Mvc;

//namespace quickrecipe.Controllers
//{
//    public class AdminController : Controller
//    {
//        public IActionResult Index()
//        {
//            return View();
//        }
//    }
//}
using Microsoft.AspNetCore.Mvc;
using QuickCook.DATABASEFOLDER;

public class AdminController : Controller
{
    private readonly QCDB _context; // Using your context name

    public AdminController(QCDB context)
    {
        _context = context;
    }

    public IActionResult Dashboard()
    {
        // Get counts for the dashboard tiles
        ViewBag.RecipeCount = _context.Recipes.Count();
        ViewBag.UserCount = _context.Users.Count();
        ViewBag.ReviewCount = _context.Reviews.Count();
        return View();
    }
}