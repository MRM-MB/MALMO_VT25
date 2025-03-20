using System;

namespace Assignment4
{
    /// <summary>
    /// Represents a recipe with a category, description, ingredients, and name.
    /// </summary>
    public class Recipe
    {
        private FoodCategory category;
        private string description;
        private string[] ingredients;
        private string name;
        private int maxNumIngredients;

        /// <summary>
        /// Initializes a new instance of the <see cref="Recipe"/> class with a maximum number of ingredients.
        /// </summary>
        /// <param name="maxNumIngredients">The maximum number of ingredients the recipe can have.</param>
        public Recipe(int maxNumIngredients)
        {
            this.maxNumIngredients = maxNumIngredients;
            DefaultValues();
        }

        /// <summary>
        /// Gets or sets the category of the recipe.
        /// </summary>
        public FoodCategory Category
        {
            get { return category; }
            set { category = value; }
        }

        /// <summary>
        /// Gets or sets the description of the recipe.
        /// </summary>
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        /// <summary>
        /// Gets or sets the array of ingredients for the recipe.
        /// </summary>
        public string[] Ingredients
        {
            get { return ingredients; }
            set { ingredients = value; }
        }

        /// <summary>
        /// Gets or sets the name of the recipe.
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Gets the maximum number of ingredients allowed for the recipe.
        /// </summary>
        public int MaxNumIngredients
        {
            get { return maxNumIngredients; }
        }

        /// <summary>
        /// Adds an ingredient to the recipe.
        /// </summary>
        /// <param name="input">The ingredient to add.</param>
        /// <returns>True if the ingredient was added successfully, otherwise false.</returns>
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

        /// <summary>
        /// Changes an ingredient at a specific index.
        /// </summary>
        /// <param name="index">The index of the ingredient to change.</param>
        /// <param name="value">The new value of the ingredient.</param>
        /// <returns>True if the ingredient was changed successfully, otherwise false.</returns>
        public bool ChangeIngredientAt(int index, string value)
        {
            if (CheckIndex(index))
            {
                ingredients[index] = value;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Checks if an index is valid for the ingredients array.
        /// </summary>
        /// <param name="index">The index to check.</param>
        /// <returns>True if the index is valid, otherwise false.</returns>
        private bool CheckIndex(int index)
        {
            return index >= 0 && index < ingredients.Length;
        }

        /// <summary>
        /// Calculates the current number of ingredients in the recipe.
        /// </summary>
        /// <returns>The number of ingredients.</returns>
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

        /// <summary>
        /// Resets the recipe to default values.
        /// </summary>
        public void DefaultValues()
        {
            category = FoodCategory.Other;
            description = "";
            ingredients = new string[maxNumIngredients];
            name = "";
        }

        /// <summary>
        /// Deletes an ingredient at a specific index.
        /// </summary>
        /// <param name="index">The index of the ingredient to delete.</param>
        public void DeletingIngredientAt(int index)
        {
            if (CheckIndex(index))
            {
                ingredients[index] = null;
            }
        }

        /// <summary>
        /// Finds a vacant position in the ingredients array.
        /// </summary>
        /// <returns>The index of the vacant position or -1 if no vacant position is found.</returns>
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

        /// <summary>
        /// Gets a string representation of the ingredients in the recipe.
        /// </summary>
        /// <returns>A string containing the ingredients.</returns>
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

        /// <summary>
        /// Gets the ingredient at a specific index as a string.
        /// </summary>
        /// <param name="index">The index of the ingredient.</param>
        /// <returns>The ingredient at the specified index or null if the index is invalid.</returns>
        public string GetIngredientsStringAt(int index)
        {
            if (CheckIndex(index))
            {
                return ingredients[index];
            }
            return null;
        }

        /// <summary>
        /// Returns a string representation of the recipe.
        /// </summary>
        /// <returns>A formatted string containing the recipe details.</returns>
        public override string ToString()
        {
            const int namePad = 20;
            const int categoryPad = 48;
            const int ingredientCountPad = 60;

            string nameColumn = Name.PadRight(namePad);
            string categoryColumn = Category.ToString().PadLeft(categoryPad);
            string ingredientCountColumn = CurrentNumberOfIngredients().ToString().PadLeft(ingredientCountPad);

            return $"{nameColumn}{categoryColumn}{ingredientCountColumn}";
        }
    }
}
