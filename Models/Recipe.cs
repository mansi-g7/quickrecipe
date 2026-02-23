using System.ComponentModel.DataAnnotations;

namespace quickrecipe.Models // Change from QuickCOOK to quickrecipe
{
    public class Recipe
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string RecipeName { get; set; }
        [Required]
        public string Ingredients { get; set; } // Keep this if you want a text summary
        [Required]
        public string Instructions { get; set; }

        // This list must exist for the Configuration to work
        public List<RecipeIngredient> RecipeIngredients { get; set; } = new();
    }
}