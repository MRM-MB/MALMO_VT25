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

        public FormIngredients(Recipe recipe)
        {
            InitializeComponent();
            currRecipe = recipe;
            this.Title = $"{currRecipe.Name} - Ingredients and Instructions"; // Set dynamic title
            UpdateIngredientList();
        }

        public Recipe GetRecipe()
        {
            return currRecipe;
        }

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

        private void btnOk_Click_1(object sender, EventArgs e)
        {
            currRecipe.Description = instructionTxt.Text.Trim(); // Save instructions to the recipe
            UpdateIngredientList();
            this.Close();
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
