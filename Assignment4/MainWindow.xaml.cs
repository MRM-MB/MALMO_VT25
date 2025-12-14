using System;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

// Finished by Manish Raj Moriche on 27th March 2025
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
            
            if (categoryComboBox.SelectedItem != null)
            {
                string categoryDescription = categoryComboBox.SelectedItem.ToString() ?? string.Empty;
                currRecipe.Category = categoryDescription.GetEnumFromDescription<FoodCategory>();
            }
            else
            {
                MessageBox.Show("Please select a category for the recipe.");
                return;
            }

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
                
                if (categoryComboBox.SelectedItem != null)
                {
                    string categoryDescription = categoryComboBox.SelectedItem.ToString() ?? string.Empty;
                    currRecipe.Category = categoryDescription.GetEnumFromDescription<FoodCategory>();
                }
                else
                {
                    MessageBox.Show("Please select a category for the recipe.");
                    return;
                }

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
                    // Format ingredients with numeration
                    string ingredients = FormatIngredientsWithNumbers(selectedRecipe);
                    string instructions = selectedRecipe.Description;

                    SetCookingDetailsText($"INGREDIENTS:\n\n{ingredients}\n\nCOOKING INSTRUCTIONS:\n\n{instructions}");
                    
                    // Display the category image for the selected recipe in the right panel
                    DisplayCategoryImage(selectedRecipe.Category.GetDescription(), true);
                }
                else
                {
                    SetCookingDetailsText("Selected recipe is invalid.");
                    recipeCategoryImage.Visibility = Visibility.Hidden;
                }
            }
            else
            {
                ClearCookingDetailsText();
                recipeCategoryImage.Visibility = Visibility.Hidden;
            }
        }

        // Helper method to format ingredients with numbers
        private string FormatIngredientsWithNumbers(Recipe recipe)
        {
            string[] ingredients = recipe.GetIngredientsString().Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            string formattedIngredients = string.Empty;
            
            for (int i = 0; i < ingredients.Length; i++)
            {
                formattedIngredients += $"{i + 1}. {ingredients[i]}\n";
            }
            
            return formattedIngredients;
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
            ClearCookingDetailsText();
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
                string selectedCategory = categoryComboBox.SelectedItem.ToString() ?? string.Empty;
                DisplayCategoryImage(selectedCategory, false);
            }
            else
            {
                categoryImage.Visibility = Visibility.Hidden;
            }
        }

        // Updated method to handle both image controls
        private void DisplayCategoryImage(string selectedCategory, bool isRecipeDetail)
        {
            // Reference to the image control
            Image imageControl = isRecipeDetail ? recipeCategoryImage : categoryImage;
            
            // Default to hiding the image
            imageControl.Visibility = Visibility.Hidden;
            
            if (string.IsNullOrEmpty(selectedCategory))
            {
                return;
            }
            
            try
            {
                // Extract the category name without emoji for the image filename
                string[] parts = selectedCategory.Split(' ');
                if (parts.Length == 0)
                {
                    return;
                }
                
                string categoryName = parts[0];
                
                // Use relative path from the executable
                string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                string assetsPath = Path.Combine(baseDirectory, "Assets");
                string imagePath = Path.Combine(assetsPath, $"{categoryName}.png");
                
                // Check if file exists
                if (File.Exists(imagePath))
                {
                    BitmapImage bitmapImage = new BitmapImage();
                    bitmapImage.BeginInit();
                    bitmapImage.UriSource = new Uri(imagePath);
                    bitmapImage.EndInit();
                    
                    imageControl.Source = bitmapImage;
                    imageControl.Visibility = Visibility.Visible;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                imageControl.Visibility = Visibility.Hidden;
            }
        }

        // Add this method to your class to set text in the RichTextBox
        private void SetCookingDetailsText(string text)
        {
            FlowDocument document = new FlowDocument();
            Paragraph paragraph = new Paragraph();
            
            string[] lines = text.Split('\n');
            
            foreach (string line in lines)
            {
                if (line.Contains("INGREDIENTS") || line.Contains("COOKING INSTRUCTIONS"))
                {
                    // Highlight the headers
                    Run highlightRun = new Run(line);
                    highlightRun.Background = new SolidColorBrush(Color.FromRgb(230, 240, 255)); // Light blue background
                    highlightRun.FontWeight = FontWeights.Bold;
                    highlightRun.Foreground = new SolidColorBrush(Color.FromRgb(45, 90, 128)); // Match the existing blue color
                    paragraph.Inlines.Add(highlightRun);
                }
                else
                {
                    // Normal text
                    paragraph.Inlines.Add(new Run(line));
                }
                
                // Add line break after each line
                paragraph.Inlines.Add(new LineBreak());
            }
            
            document.Blocks.Add(paragraph);
            cookingDetailsText.Document = document;
        }

        // To clear the RichTextBox, replace:
        // cookingDetailsText.Clear();
        // with:
        private void ClearCookingDetailsText()
        {
            FlowDocument document = new FlowDocument();
            document.Blocks.Add(new Paragraph(new Run("")));
            cookingDetailsText.Document = document;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            
            // Ensure all background processes are terminated
            Application.Current.Shutdown();
        }
    }
}
