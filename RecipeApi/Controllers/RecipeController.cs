using System;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace RecipeApi
{
    [ApiController]
    [Route("recipes")]
    public class RecipeController : ControllerBase
    {
        private Database _db;

        public RecipeController(Database db)
        {
            _db = db;
        }

        [HttpPost]
        public IActionResult CreateRecipe(Recipe recipe)
        {
            _db.Add(recipe);

            foreach (Ingredient i in recipe.Ingredients)
            {
                _db.Add(i);
            }

            foreach (Instruction i in recipe.Instructions)
            {
                _db.Add(i);
            }

            _db.SaveChanges();

            return Ok(recipe);
        }

        [HttpGet("{name}")]
        public IActionResult GetRecipeByName(string name)
        {
            var recipe = _db.Recipes.Where(r => r.Name == name).SingleOrDefault();
            if (recipe is null) return NotFound();
            return Ok(recipe);
        }
    }
}