using System;
using System.Collections.Generic;

namespace RecipeApi
{
    public class Ingredient
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public List<Recipe> Recipes { get; set; }
    }
}