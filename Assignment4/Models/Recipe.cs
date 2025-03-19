namespace CookbookApp.Models;

public class Recipe
{
    public string Name { get; set; }
    public FoodCategory Category { get; set; }
    public string Instructions { get; set; }
    public string Description { get; set; }
    public string[] Ingredients { get; set; }

    public Recipe(int maxIngredients)
    {
        Ingredients = new string[maxIngredients];
    }
}