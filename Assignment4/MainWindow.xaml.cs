using System;
using System.ComponentModel;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Assignment4
{
    public partial class MainWindow : Window
    {
        private const int MaxNumOfElements = 200;
        private const int MaxNumOfIngredients = 50;

        private RecipeManager recipeManager = new RecipeManager(MaxNumOfElements);
        private Recipe currRecipe = new Recipe(MaxNumOfIngredients);

        public MainWindow()
        {
            InitializeComponent();
            LoadCategoryList();

            categoryComboBox.SelectedIndex = 0;
            listRecipes.MouseDoubleClick += new MouseButtonEventHandler(listRecipes_MouseDoubleClick);
            listRecipes.SelectionChanged += new SelectionChangedEventHandler(listRecipes_SelectionChanged);
        }

        private void addIngerBtn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(recipeName.Text) || categoryComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please enter a name and select a category for the recipe.");
                return;
            }
            FormIngredients formIngredients = new FormIngredients(currRecipe);
            formIngredients.ShowDialog();
        }

        private void btnAddRec_Click(object sender, RoutedEventArgs e)
        {
            if (currRecipe.CurrentNumberOfIngredients() == 0)
            {
                MessageBox.Show("Please add ingredients to the recipe.");
                return;
            }

            currRecipe.Name = recipeName.Text;
            currRecipe.Category = categoryComboBox.SelectedItem.ToString().GetEnumFromDescription<FoodCategory>();

            bool addedSuccessfully = recipeManager.Add(currRecipe);

            if (addedSuccessfully)
            {
                UpdateGUI();
                currRecipe = new Recipe(MaxNumOfIngredients);
                ClearForm();
            }
            else
            {
                MessageBox.Show("Failed to add recipe. The recipe book is full or an error occurred.");
            }
        }

        private void btnEditBegin_Click(object sender, EventArgs e)
        {
            if (listRecipes.SelectedItem != null)
            {
                int index = listRecipes.SelectedIndex;
                var recipe = recipeManager.GetRecipeAt(index);
                if (recipe != null)
                {
                    currRecipe = recipe;
                    recipeName.Text = currRecipe.Name;
                    categoryComboBox.SelectedItem = currRecipe.Category.GetDescription();
                }
                else
                {
                    MessageBox.Show("Selected recipe is invalid.");
                }
            }
            else
            {
                MessageBox.Show("Please select a recipe to edit.");
            }
        }

        private void btnEditFinish_Click(object sender, EventArgs e)
        {
            if (listRecipes.SelectedItem != null)
            {
                int index = listRecipes.SelectedIndex;

                currRecipe.Name = recipeName.Text;
                currRecipe.Category = categoryComboBox.SelectedItem.ToString().GetEnumFromDescription<FoodCategory>();

                recipeManager.ChangeElement(index, currRecipe);

                UpdateGUI();
                ClearForm();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (listRecipes.SelectedItem != null)
            {
                int index = listRecipes.SelectedIndex;
                recipeManager.DeleteElement(index);
                UpdateGUI();
            }
            else
            {
                MessageBox.Show("Please select a recipe to delete.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void listRecipes_MouseDoubleClick(object sender, EventArgs e)
        {
            ViewSelectedRecipeDetails();
        }

        private void listRecipes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ViewSelectedRecipeDetails();
        }

        private void ViewSelectedRecipeDetails()
        {
            int selectedIndex = listRecipes.SelectedIndex;
            if (selectedIndex != -1)
            {
                var selectedRecipe = recipeManager.GetRecipeAt(selectedIndex);
                if (selectedRecipe != null)
                {
                    string ingredients = selectedRecipe.GetIngredientsString();
                    string instructions = selectedRecipe.Description;

                    cookingDetailsText.Text = $"INGREDIENTS:\n\n{ingredients}\n\nCOOKING INSTRUCTIONS:\n\n{instructions}";
                }
                else
                {
                    cookingDetailsText.Text = "Selected recipe is invalid.";
                }
            }
            else
            {
                cookingDetailsText.Text = string.Empty;
            }
        }

        private void UpdateGUI()
        {
            listRecipes.Items.Clear();

            foreach (string recipeSummary in recipeManager.RecipeListToString())
            {
                listRecipes.Items.Add(recipeSummary);
            }
        }

        private void ClearForm()
        {
            recipeName.Clear();
            categoryComboBox.SelectedIndex = -1;
            listRecipes.SelectedIndex = -1;
            cookingDetailsText.Clear();
        }

        private void LoadCategoryList()
        {
            foreach (FoodCategory category in Enum.GetValues(typeof(FoodCategory)))
            {
                categoryComboBox.Items.Add(category.GetDescription());
            }
        }
    }
}
