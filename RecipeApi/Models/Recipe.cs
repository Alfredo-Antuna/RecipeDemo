using System;
using System.Collections.Generic;

namespace RecipeApi
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Calories { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public List<Instruction> Instructions { get; set; }

        public override string ToString() => $"id/{Id}, name/{Name}, calories/{Calories}";
    }
}
