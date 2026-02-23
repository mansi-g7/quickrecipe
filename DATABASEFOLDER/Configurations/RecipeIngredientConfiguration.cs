using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using quickrecipe.Models; // Use the unified namespace

namespace QuickCook.DATABASEFOLDER.Configurations
{
    public class RecipeIngredientConfiguration : IEntityTypeConfiguration<RecipeIngredient>
    {
        public void Configure(EntityTypeBuilder<RecipeIngredient> builder)
        {
            // Sets the Composite Key
            builder.HasKey(ri => new { ri.RecipeId, ri.IngredientId });

            // Links to Recipe
            builder.HasOne(ri => ri.Recipe)
                   .WithMany(r => r.RecipeIngredients)
                   .HasForeignKey(ri => ri.RecipeId);

            // Links to Ingredient
            builder.HasOne(ri => ri.Ingredient)
                   .WithMany(i => i.RecipeIngredients)
                   .HasForeignKey(ri => ri.IngredientId);
        }
    }
}