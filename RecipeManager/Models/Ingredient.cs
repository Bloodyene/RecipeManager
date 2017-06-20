namespace RecipeManager.Models
{
    public class Ingredient
    {
        public string  Name { get; set; }
        public int CaloriesPer100g { get; set; }
        public int CarbohydratesPer100g { get; set; }
        public int FatPer100g { get; set; }
        public int ProteinPer100g { get; set; }
        public int FibrePer100g { get; set; }
        public int Amount { get; set; }
    }
}