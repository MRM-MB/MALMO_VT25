using CookbookApp.Models;

namespace CookbookApp.ViewModels;

public class RecipeDetailsViewModel
{
    private Recipe recipe; // Ensure Recipe is properly referenced
    public Recipe CurrentRecipe { get; set; }

    public RecipeDetailsViewModel(Recipe recipe)
    {
        CurrentRecipe = recipe;
    }

    // Methods for managing recipe details
}