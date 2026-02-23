using Microsoft.EntityFrameworkCore;
using QuickCOOK.Models;
using quickrecipe.Models; // Only need this one now!

namespace QuickCook.DATABASEFOLDER
{
    public class QCDB : DbContext
    {
        public QCDB(DbContextOptions options) : base(options) { }

        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<RecipeIngredient> RecipeIngredients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // This line automatically applies RecipeIngredientConfiguration
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(QCDB).Assembly);
        }
    }
}