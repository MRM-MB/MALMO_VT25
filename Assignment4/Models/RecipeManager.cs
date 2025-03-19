namespace CookbookApp.Models;

public class RecipeManager
{
    private Recipe[] recipes;
    private int numOfRecipes;

    public RecipeManager(int maxRecipes)
    {
        recipes = new Recipe[maxRecipes];
        numOfRecipes = 0;
    }

    public bool AddRecipe(Recipe recipe)
    {
        if (recipe == null)
        {
            throw new ArgumentNullException(nameof(recipe));
        }

        if (numOfRecipes < recipes.Length)
        {
            recipes[numOfRecipes] = recipe;
            numOfRecipes++;
            return true;
        }
        return false;
    }

    public Recipe GetRecipe(int index)
    {
        if (index >= 0 && index < numOfRecipes)
        {
            return recipes[index];
        }
        return null;
    }

    public bool RemoveRecipe(int index)
    {
        if (index >= 0 && index < numOfRecipes)
        {
            for (int i = index; i < numOfRecipes - 1; i++)
            {
                recipes[i] = recipes[i + 1];
            }
            recipes[numOfRecipes - 1] = null;
            numOfRecipes--;
            return true;
        }
        return false;
    }
}