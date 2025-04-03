using System;

namespace Assignment4
{
    /// <summary>
    /// Manages a list of recipes.
    /// </summary>
    internal class RecipeManager
    {
        private Recipe?[] recipeList;
        private int numOfElems = 0;

        /// <summary>
        /// Initializes a new instance of the <see cref="RecipeManager"/> class with a maximum number of recipes.
        /// </summary>
        /// <param name="maxNumRecipes">The maximum number of recipes the manager can hold.</param>
        public RecipeManager(int maxNumRecipes)
        {
            recipeList = new Recipe?[maxNumRecipes];
        }

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
        public Recipe? GetRecipeAt(int index) // Already marked as nullable
        {
            if (CheckIndex(index))
            {
                return recipeList[index];
            }
            return null;
        }

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

        private bool CheckIndex(int index)
        {
            if (index >= 0 && index < recipeList.Length)
            {
                return true;
            }
            return false;
        }

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

        private void MoveElementsOneStepToLeft(int index)
        {
            for (int i = index; i < recipeList.Length - 1; i++)
            {
                recipeList[i] = recipeList[i + 1];
            }
            recipeList[recipeList.Length - 1] = null; // No change needed, null is valid for nullable Recip
        }
    }
}
