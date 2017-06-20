using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RecipeManager.Models
{
    public class Recipe
    {
        public string Name { get;private set; }
        public List<Ingredient> Ingredients { get; set; }
        public string Contents { get;private set; }
        public int CaloriesCount {
            get
            {
                int value = 0;
                foreach (var i in Ingredients)
                {
                    value += i.Key.CaloriesPer100g * i.Value / 100;
                }
                return value;
            }
        }
        public int CalCount {
            get
            {
                return Ingredients.Select((x) => x.Key.CaloriesPer100g * x.Value / 100).Sum();
            }
        }
        public Recipe(string name, string contents)
        {
            Name = name;
            Contents = contents;
            Ingredients = new Dictionary<Ingredient, int>();
        }
    }
}