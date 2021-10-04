using System;
using System.Collections.Generic;

namespace RecipeApi
{
    public class Instruction
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public List<Recipe> Recipe { get; set; }

        public override string ToString() => $"id/{Id}, text/{Text}";
    }
}