using QuickCOOK.Models;

namespace quickrecipe.Models
{
    public class RecipeIngredient
    {
        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; } = null!;

        public int IngredientId { get; set; }
        public Ingredient Ingredient { get; set; } = null!;

        public double Quantity { get; set; }
        public string Unit { get; set; } = string.Empty; // e.g., "grams", "tsp"
    }
}
