using Microsoft.EntityFrameworkCore;

namespace RecipeApi
{
    public class Database : DbContext
    {
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Instruction> Instructions { get; set; }
        public Database(DbContextOptions<Database> options) : base(options) { }
    }
}