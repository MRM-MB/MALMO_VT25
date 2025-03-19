using System;
using System.Windows;
using Assignment4.Models;

namespace Assignment4
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // Quick test for Recipe class
            try
            {
                Recipe testRecipe = new Recipe(50)
                {
                    Name = "Pancakes",
                    Category = FoodCategory.MainCourse,
                    Description = "A simple pancake recipe."
                };

                testRecipe.AddIngredient("Flour");
                testRecipe.AddIngredient("Milk");
                testRecipe.AddIngredient("Eggs");

                MessageBox.Show($"Recipe: {testRecipe.Name}\nCategory: {testRecipe.Category}\nDescription: {testRecipe.Description}\nIngredients: {string.Join(", ", testRecipe.Ingredients)}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}