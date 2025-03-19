using CookbookApp.Models;

namespace CookbookApp.ViewModels;

public class MainViewModel
{
    private RecipeManager recipeManager; // Ensure RecipeManager is properly referenced

    public MainViewModel()
    {
        recipeManager = new RecipeManager(200); // Max 200 recipes
    }

    // Methods for interacting with the RecipeManager
}