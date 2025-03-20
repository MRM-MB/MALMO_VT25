using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Assignment4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const int MaxNumOfElements = 150;
        private const int MaxNumOfIngredients = 25;

        private RecipeManager recipeManager = new RecipeManager(MaxNumOfElements);
        private Recipe currRecipe = new Recipe(MaxNumOfIngredients);

        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            LoadCategoryList();

            categoryComboBox.SelectedIndex = 0;
            listRecipes.MouseDoubleClick += new MouseButtonEventHandler(listRecipes_MouseDoubleClick);
        }

        /// <summary>
        /// Handles the click event of the "Add Ingredients" button.
        /// </summary>
        /// <param name="sender">The sender object.</param>
        /// <param name="e">The event arguments.</param>
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

        /// <summary>
        /// Handles the click event of the "Add Recipe" button.
        /// </summary>
        /// <param name="sender">The sender object.</param>
        /// <param name="e">The event arguments.</param>
        private void btnAddRec_Click(object sender, RoutedEventArgs e)
        {
            if (currRecipe.CurrentNumberOfIngredients() == 0)
            {
                MessageBox.Show("Please add ingredients to the recipe.");
                return;
            }

            currRecipe.Name = recipeName.Text;
            currRecipe.Category = (FoodCategory)categoryComboBox.SelectedItem;

            if (string.IsNullOrEmpty(textInstructions.Text))
            {
                MessageBox.Show("Please add instructions to the recipe.");
                return;
            }

            currRecipe.Description = textInstructions.Text;

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

        /// <summary>
        /// Begins the edit mode for the selected recipe.
        /// </summary>
        /// <param name="sender">The sender object.</param>
        /// <param name="e">The event arguments.</param>
        private void btnEditBegin_Click(object sender, EventArgs e)
        {
            if (listRecipes.SelectedItem != null)
            {
                int index = listRecipes.SelectedIndex;
                currRecipe = recipeManager.GetRecipeAt(index);

                recipeName.Text = currRecipe.Name;
                categoryComboBox.SelectedItem = currRecipe.Category;
                textInstructions.Text = currRecipe.Description;
            }
            else
            {
                MessageBox.Show("Please select a recipe to edit.");
            }
        }

        /// <summary>
        /// Finishes the edit mode for the selected recipe.
        /// </summary>
        /// <param name="sender">The sender object.</param>
        /// <param name="e">The event arguments.</param>
        private void btnEditFinish_Click(object sender, EventArgs e)
        {
            if (listRecipes.SelectedItem != null)
            {
                int index = listRecipes.SelectedIndex;

                currRecipe.Name = recipeName.Text;
                currRecipe.Category = (FoodCategory)categoryComboBox.SelectedItem;
                currRecipe.Description = textInstructions.Text;

                recipeManager.ChangeElement(index, currRecipe);

                UpdateGUI();
                ClearForm();
            }
        }

        /// <summary>
        /// Handles the click event of the "Delete" button.
        /// </summary>
        /// <param name="sender">The sender object.</param>
        /// <param name="e">The event arguments.</param>
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

        /// <summary>
        /// Handles the click event of the "Clear" button.
        /// </summary>
        /// <param name="sender">The sender object.</param>
        /// <param name="e">The event arguments.</param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        /// <summary>
        /// Handles the mouse double click event on the list of recipes.
        /// </summary>
        /// <param name="sender">The sender object.</param>
        /// <param name="e">The event arguments.</param>
        private void listRecipes_MouseDoubleClick(object sender, EventArgs e)
        {
            ViewSelectedRecipeDetails();
        }

        /// <summary>
        /// Displays the details of the selected recipe.
        /// </summary>
        private void ViewSelectedRecipeDetails()
        {
            int selectedIndex = listRecipes.SelectedIndex;
            if (selectedIndex != -1)
            {
                Recipe selectedRecipe = recipeManager.GetRecipeAt(selectedIndex);

                string ingredients = selectedRecipe.GetIngredientsString();
                string instructions = selectedRecipe.Description;

                MessageBox.Show($"INGREDIENTS:\n {ingredients}\n\n {instructions}", "Cooking Instructions:");
            }
            else
            {
                MessageBox.Show("Please select a recipe to view its details.", "Selection Required");
            }
        }

        /// <summary>
        /// Updates the GUI with the list of recipes.
        /// </summary>
        private void UpdateGUI()
        {
            listRecipes.Items.Clear();

            foreach (string recipeSummary in recipeManager.RecipeListToString())
            {
                listRecipes.Items.Add(recipeSummary);
            }
        }

        /// <summary>
        /// Clears the input form.
        /// </summary>
        private void ClearForm()
        {
            recipeName.Clear();
            textInstructions.Text = "";
            categoryComboBox.SelectedIndex = -1;
            listRecipes.SelectedIndex = -1;
        }

        /// <summary>
        /// Loads the list of food categories into the ComboBox.
        /// </summary>
        private void LoadCategoryList()
        {
            foreach (FoodCategory category in Enum.GetValues(typeof(FoodCategory)))
            {
                categoryComboBox.Items.Add(category);
            }
        }
    }
}
