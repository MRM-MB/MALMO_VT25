using System;
using System.Windows;
using System.Windows.Controls;

namespace Assignment4
{
    /// <summary>
    /// Interaction logic for FormIngredients.xaml
    /// </summary>
    public partial class FormIngredients : Window
    {
        private Recipe currRecipe;

        /// <summary>
        /// Initializes a new instance of the <see cref="FormIngredients"/> class.
        /// </summary>
        /// <param name="recipe">The recipe to edit.</param>
        public FormIngredients(Recipe recipe)
        {
            InitializeComponent();
            currRecipe = recipe;
            this.Title = $"{currRecipe.Name} - Ingredients and Instructions"; // Set dynamic title
            UpdateIngredientList();
        }

        /// <summary>
        /// Gets the current recipe being edited.
        /// </summary>
        /// <returns>The current recipe.</returns>
        public Recipe GetRecipe()
        {
            return currRecipe;
        }

        /// <summary>
        /// Handles the click event of the "Add" button.
        /// </summary>
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            string ingredient = ingredientTxt.Text.Trim();

            if (!string.IsNullOrEmpty(ingredient))
            {
                if (currRecipe.AddIngredient(ingredient))
                {
                    UpdateIngredientList();
                    ingredientTxt.Clear();
                }
                else
                {
                    MessageBox.Show("Unable to add ingredient. Check if the list is full or duplicated.");
                }
            }
            else
            {
                MessageBox.Show("Please enter an ingredient.");
            }
        }

        /// <summary>
        /// Updates the list of ingredients displayed in the UI.
        /// </summary>
        private void UpdateIngredientList()
        {
            listBox.Items.Clear();
            foreach (var ingredient in currRecipe.Ingredients)
            {
                if (!string.IsNullOrEmpty(ingredient))
                {
                    listBox.Items.Add(ingredient);
                }
            }
            numOfIng.Content = currRecipe.CurrentNumberOfIngredients().ToString();
            instructionTxt.Text = currRecipe.Description; // Load instructions into the textbox
        }

        /// <summary>
        /// Handles the click event of the "Edit" button.
        /// </summary>
        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            int index = listBox.SelectedIndex;
            if (index != -1)
            {
                string ingredient = currRecipe.GetIngredientsStringAt(index);
                ingredientTxt.Text = ingredient;
                currRecipe.DeletingIngredientAt(index);
                UpdateIngredientList();
            }
            else
            {
                MessageBox.Show("Please select an ingredient to edit.");
            }
        }

        /// <summary>
        /// Handles the click event of the "Delete" button.
        /// </summary>
        private void btnDel_Click_1(object sender, EventArgs e)
        {
            int index = listBox.SelectedIndex;
            if (index != -1)
            {
                currRecipe.DeletingIngredientAt(index);
                UpdateIngredientList();
            }
            else
            {
                MessageBox.Show("Please select an ingredient to delete.");
            }
        }

        /// <summary>
        /// Handles the click event of the "Ok" button.
        /// </summary>
        private void btnOk_Click_1(object sender, EventArgs e)
        {
            currRecipe.Description = instructionTxt.Text.Trim(); // Save instructions to the recipe
            UpdateIngredientList();
            this.Close();
        }

        /// <summary>
        /// Handles the click event of the "Cancel" button.
        /// </summary>
        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
