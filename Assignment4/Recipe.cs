using System;

namespace Assignment4;

/// <summary>
/// Represents a recipe with a category, description, ingredients, and name.
/// </summary>
public class Recipe
{
    private FoodCategory category;
    private string description;
    private string?[] ingredients;
    private string name;
    private int maxNumIngredients;

    public Recipe(int maxNumIngredients)
    {
        this.maxNumIngredients = maxNumIngredients;
        ingredients = new string?[maxNumIngredients];
        description = string.Empty;
        name = string.Empty;
        category = FoodCategory.Other;
    }

    public FoodCategory Category
    {
        get { return category; }
        set { category = value; }
    }

    public string Description
    {
        get { return description; }
        set { description = value; }
    }

    public string?[] Ingredients
    {
        get { return ingredients; }
        set { ingredients = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int MaxNumIngredients
    {
        get { return maxNumIngredients; }
    }

    public bool AddIngredient(string input)
    {
        int index = FindVacantPosition();
        if (index != -1)
        {
            ingredients[index] = input;
            return true;
        }
        return false;
    }

    public bool ChangeIngredientAt(int index, string value)
    {
        if (CheckIndex(index))
        {
            ingredients[index] = value;
            return true;
        }
        return false;
    }

    private bool CheckIndex(int index)
    {
        return index >= 0 && index < ingredients.Length;
    }

    public int CurrentNumberOfIngredients()
    {
        int count = 0;
        for (int i = 0; i < ingredients.Length; i++)
        {
            if (ingredients[i] != null)
            {
                count++;
            }
        }
        return count;
    }

    public void DefaultValues()
    {
        category = FoodCategory.Other;
        description = "";
        ingredients = new string?[maxNumIngredients];
        name = "";
    }

    public void DeletingIngredientAt(int index)
    {
        if (CheckIndex(index))
        {
            ingredients[index] = null;
        }
    }

    private int FindVacantPosition()
    {
        for (int i = 0; i < ingredients.Length; i++)
        {
            if (ingredients[i] == null)
            {
                return i;
            }
        }
        return -1;
    }

    public string GetIngredientsString()
    {
        string result = "";
        for (int i = 0; i < ingredients.Length; i++)
        {
            if (ingredients[i] != null)
            {
                result += ingredients[i] + "\n";
            }
        }
        return result;
    }

    public string GetIngredientsStringAt(int index)
    {
        if (CheckIndex(index))
        {
            return ingredients[index] ?? string.Empty; // Ensure no null is returned
        }
        return string.Empty; // Return empty string instead of null
    }

    public static string TruncateWithEllipsis(string text, int width)
    {
        if (string.IsNullOrEmpty(text))
            return new string(' ', width); // Ensure alignment by filling with spaces

        if (text.Length > width)
            return text.Substring(0, width - 3) + "..."; // Truncate and add ellipsis
        else
            return text.PadRight(width); // Pad with spaces if shorter than width
    }

    public override string ToString()
    {
        const int nameWidth = 21;    // Fixed width for the name column
        const int categoryWidth = 15; // Fixed width for the category column
        const int ingredientWidth = 8; // Fixed width for the number column

        // Ensure consistent alignment with truncation and padding
        string nameColumn = TruncateWithEllipsis(Name ?? string.Empty, nameWidth).PadRight(nameWidth);
        string categoryColumn = TruncateWithEllipsis(Category.ToString(), categoryWidth).PadRight(categoryWidth);
        string ingredientCountColumn = CurrentNumberOfIngredients().ToString().PadLeft(ingredientWidth);

        // Concatenate columns with fixed widths
        return $"{nameColumn}{categoryColumn}{ingredientCountColumn}";
    }
}