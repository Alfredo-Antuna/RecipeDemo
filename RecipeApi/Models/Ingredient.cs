using System;
using System.Collections.Generic;

namespace RecipeApi
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Recipe> Recipes { get; set; }

        public override string ToString() => $"id/{Id}, name/{Name}";
    }
}