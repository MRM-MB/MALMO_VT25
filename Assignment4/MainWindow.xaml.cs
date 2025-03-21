using System;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace Assignment4
{
    public partial class MainWindow : Window
    {
        private const int MaxNumOfElements = 200;
        private const int MaxNumOfIngredients = 50;

        private RecipeManager recipeManager = new RecipeManager(MaxNumOfElements);
        private Recipe currRecipe = new Recipe(MaxNumOfIngredients);
        private bool isEditMode = false;
        private int editingIndex = -1;

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

            bool success = false;
            
            if (isEditMode && editingIndex >= 0)
            {
                // In edit mode, update the existing recipe
                recipeManager.ChangeElement(editingIndex, currRecipe);
                MessageBox.Show("Recipe updated successfully.");
                isEditMode = false;
                editingIndex = -1;
                success = true;
            }
            else
            {
                // In add mode, add a new recipe
                success = recipeManager.Add(currRecipe);
            }

            if (success)
            {
                UpdateGUI();
                currRecipe = new Recipe(MaxNumOfIngredients);
                ClearForm();
            }
            else
            {
                MessageBox.Show("Failed to update recipe. An error occurred.");
            }
        }

        private void btnEditBegin_Click(object sender, EventArgs e)
        {
            if (listRecipes.SelectedItem != null)
            {
                editingIndex = listRecipes.SelectedIndex;
                var recipe = recipeManager.GetRecipeAt(editingIndex);
                if (recipe != null)
                {
                    currRecipe = recipe;
                    recipeName.Text = currRecipe.Name;
                    categoryComboBox.SelectedItem = currRecipe.Category.GetDescription();
                    isEditMode = true;
                    MessageBox.Show("Now editing recipe. Click Add Recipe to save changes.");
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
                isEditMode = false;
                editingIndex = -1;
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
            isEditMode = false;
            editingIndex = -1;
            currRecipe = new Recipe(MaxNumOfIngredients);
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
            isEditMode = false;
            editingIndex = -1;
        }

        private void LoadCategoryList()
        {
            foreach (FoodCategory category in Enum.GetValues(typeof(FoodCategory)))
            {
                categoryComboBox.Items.Add(category.GetDescription());
            }
        }

        private void categoryComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (categoryComboBox.SelectedItem != null)
            {
                string selectedCategory = categoryComboBox.SelectedItem.ToString();
                
                // Default to hiding the image
                categoryImage.Visibility = Visibility.Hidden;
                
                try
                {
                    // Extract the category name without emoji for the image filename
                    string categoryName = selectedCategory.Split(' ')[0];
                    
                    // Use direct path to the assets folder in the project directory
                    string projectDirectory = @"c:\Users\manis\Desktop\MALMO\Assignment4";
                    string assetsPath = Path.Combine(projectDirectory, "assets");
                    string imagePath = Path.Combine(assetsPath, $"{categoryName}.png");
                    
                    // Check if file exists
                    if (File.Exists(imagePath))
                    {
                        BitmapImage bitmapImage = new BitmapImage();
                        bitmapImage.BeginInit();
                        bitmapImage.UriSource = new Uri(imagePath);
                        bitmapImage.EndInit();
                        
                        categoryImage.Source = bitmapImage;
                        categoryImage.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        // Hide image if the file doesn't exist, no need for message box
                        categoryImage.Visibility = Visibility.Hidden;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    categoryImage.Visibility = Visibility.Hidden;
                }
            }
            else
            {
                categoryImage.Visibility = Visibility.Hidden;
            }
        }
    }
}
