namespace Assignment4.Models
{
    public enum FoodCategory
    {
        Appetizer,
        MainCourse,
        Dessert,
        Beverage
    }

    public class Recipe
    {
        private string _name;
        private FoodCategory _category;
        private string _description;
        private string[] _ingredients;
        private int _ingredientCount;

        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Recipe name cannot be empty.");
                _name = value;
            }
        }

        public FoodCategory Category
        {
            get => _category;
            set => _category = value;
        }

        public string Description
        {
            get => _description;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Description cannot be empty.");
                _description = value;
            }
        }

        public string[] Ingredients => _ingredients;

        public Recipe(int maxIngredients)
        {
            _name = string.Empty;
            _description = string.Empty;
            _ingredients = new string[maxIngredients];
            _ingredientCount = 0;
        }

        public void AddIngredient(string ingredient)
        {
            if (_ingredientCount >= _ingredients.Length)
                throw new InvalidOperationException("Maximum number of ingredients reached.");
            _ingredients[_ingredientCount++] = ingredient;
        }
    }
}