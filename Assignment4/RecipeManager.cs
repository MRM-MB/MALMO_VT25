using System;

namespace Assignment4
{
    /// <summary>
    /// Manages a list of recipes.
    /// </summary>
    internal class RecipeManager
    {
        private Recipe[] recipeList;
        private int numOfElems = 0;

        /// <summary>
        /// Initializes a new instance of the <see cref="RecipeManager"/> class with a maximum number of recipes.
        /// </summary>
        /// <param name="maxNumRecipes">The maximum number of recipes the manager can hold.</param>
        public RecipeManager(int maxNumRecipes)
        {
            recipeList = new Recipe[maxNumRecipes];
        }

        /// <summary>
        /// Adds a recipe to the list.
        /// </summary>
        /// <param name="recipe">The recipe to add.</param>
        /// <returns>True if the recipe was added successfully, otherwise false.</returns>
        public bool Add(Recipe recipe)
        {
            int index = FindVacantPosition();
            if (index != -1)
            {
                recipeList[index] = recipe;
                numOfElems++;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Creates and adds a recipe to the list.
        /// </summary>
        /// <param name="name">The name of the recipe.</param>
        /// <param name="description">The description of the recipe.</param>
        /// <param name="category">The category of the recipe.</param>
        /// <param name="ingredients">The ingredients of the recipe.</param>
        /// <returns>True if the recipe was added successfully, otherwise false.</returns>
        public bool Add(string name, string description, FoodCategory category, string[] ingredients)
        {
            Recipe recipe = new Recipe(ingredients.Length);
            recipe.Name = name;
            recipe.Description = description;
            recipe.Category = category;
            recipe.Ingredients = ingredients;
            return Add(recipe);
        }

        /// <summary>
        /// Changes a recipe at a specific index.
        /// </summary>
        /// <param name="index">The index of the recipe to change.</param>
        /// <param name="recipe">The new recipe.</param>
        public void ChangeElement(int index, Recipe recipe)
        {
            if (CheckIndex(index))
            {
                recipeList[index] = recipe;
            }
        }

        /// <summary>
        /// Deletes a recipe at a specific index.
        /// </summary>
        /// <param name="index">The index of the recipe to delete.</param>
        public void DeleteElement(int index)
        {
            if (CheckIndex(index))
            {
                recipeList[index] = null;
                numOfElems--;
                MoveElementsOneStepToLeft(index);
            }
        }

        /// <summary>
        /// Gets the current number of recipes in the list.
        /// </summary>
        /// <returns>The number of recipes.</returns>
        public int GetCurrentNumberOfRecipes()
        {
            int count = 0;
            for (int i = 0; i < recipeList.Length; i++)
            {
                if (recipeList[i] != null)
                {
                    count++;
                }
            }
            return count;
        }

        /// <summary>
        /// Gets a recipe at a specific index.
        /// </summary>
        /// <param name="index">The index of the recipe to retrieve.</param>
        /// <returns>The recipe at the specified index or null if the index is invalid.</returns>
        public Recipe GetRecipeAt(int index)
        {
            if (CheckIndex(index))
            {
                return recipeList[index];
            }
            return null;
        }

        /// <summary>
        /// Converts the list of recipes to an array of strings.
        /// </summary>
        /// <returns>An array of strings representing the recipes.</returns>
        public string[] RecipeListToString()
        {
            string[] recipeStrings = new string[GetCurrentNumberOfRecipes()];
            int counter = 0;
            foreach (var recipe in recipeList)
            {
                if (recipe != null)
                {
                    recipeStrings[counter++] = recipe.ToString();
                }
            }
            return recipeStrings;
        }

        /// <summary>
        /// Checks if the given index is valid.
        /// </summary>
        /// <param name="index">The index to check.</param>
        /// <returns>True if the index is valid, otherwise false.</returns>
        private bool CheckIndex(int index)
        {
            if (index >= 0 && index < recipeList.Length)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Finds the first vacant position in the recipe list.
        /// </summary>
        /// <returns>The index of the first vacant position or -1 if the list is full.</returns>
        private int FindVacantPosition()
        {
            for (int i = 0; i < recipeList.Length; i++)
            {
                if (recipeList[i] == null)
                {
                    return i;
                }
            }
            return -1;
        }

        /// <summary>
        /// Moves all elements one step to the left starting from the specified index.
        /// </summary>
        /// <param name="index">The index from which to start moving elements.</param>
        private void MoveElementsOneStepToLeft(int index)
        {
            for (int i = index; i < recipeList.Length - 1; i++)
            {
                recipeList[i] = recipeList[i + 1]; //move 1 step to left
            }
            recipeList[recipeList.Length - 1] = null; //empty last place
        }
    }
}
