using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CookbookApp.Models;

namespace CookbookApp.Views;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private RecipeManager recipeManager;

    public MainWindow()
    {
        InitializeComponent();
        recipeManager = new RecipeManager(200); // Max 200 recipes
    }

    // Event handlers and other methods for managing recipes
}