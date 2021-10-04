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
            _db.SaveChanges();
            return Ok(recipe);
        }
    }
}