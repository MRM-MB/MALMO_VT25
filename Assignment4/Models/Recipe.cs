namespace CookbookApp.Models;

public class Recipe
{
    public required string Name { get; set; }
    public FoodCategory Category { get; set; }
    public required string Instructions { get; set; }
    public required string Description { get; set; }
    public string[] Ingredients { get; set; }

    public Recipe(int maxIngredients)
    {
        Ingredients = new string[maxIngredients];
    }
}