//using Microsoft.AspNetCore.Mvc;

//namespace quickrecipe.Controllers
//{
//    public class RecipesController : Controller
//    {
//        public IActionResult Index()
//        {
//            return View();
//        }
//    }
//}[HttpPost]
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using quickrecipe.Models;

public async Task<IActionResult> Create(Recipe recipe, int[] selectedIngredientIds)
{
    if (ModelState.IsValid)
    {
        _context.Add(recipe);
        await _context.SaveChangesAsync();

        // Map the ingredients to the recipe in the junction table
        foreach (var id in selectedIngredientIds)
        {
            _context.RecipeIngredients.Add(new RecipeIngredient
            {
                RecipeId = recipe.Id,
                IngredientId = id,
                Quantity = 1, // You can make this a dynamic input later
                Unit = "pcs"
            });
        }
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }
    return View(recipe);
}
