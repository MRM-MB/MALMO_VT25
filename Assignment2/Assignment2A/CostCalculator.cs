namespace Assignment2A;

class Calculator 
{
    // Number of units purchased
    private int number;

    // Price per unit
    private float price;

    // Discount to provide
    private float discount;

    // Variables for Calculations
    private float originalTotal;
    private float finalTotal;

    // Take y/n or yes/no as input
    private string? answer;

    public void Start()
    {
        while (true)
        {
            // Validate Price input
            while (true)
            {
                Console.Write("Enter the original price per unit: ");
                if (float.TryParse(Console.ReadLine(), out price) && price > 0)
                    break; // Valid input, exit loop
                else
                    Console.WriteLine("Invalid input. Please enter a number greater than 0.");
            }

            // Validate Quantity of the product
            while (true)
            {
                Console.Write("Enter the quantity of the product: ");
                if (int.TryParse(Console.ReadLine(), out number) && number > 0)
                    break; // Valid input, exit loop
                else
                    Console.WriteLine("Invalid input. Please enter a number greater than 0.");
            }

            // STEP 1 - Discount Structure
            if (number >= 100)
                discount = 50;
            else if (number >= 50)
                discount = 40;
            else if (number >= 20)
                discount = 30;
            else if (number >= 10)
                discount = 20;
            else
                discount = 0; // No discount if less than 10 units

            // STEP 1 - Calculation of Total Cost
            originalTotal = price * number;
            Console.WriteLine($"\nOriginal Total Cost: {originalTotal:F2} kr");

            Console.WriteLine($"Discount Applied: {discount:F2} %");

            finalTotal = originalTotal * (1 - discount / 100);
            Console.WriteLine($"Final Total Cost: {finalTotal:F2} kr");

            // STEP 2 - Ask the user if they want to make another calculation
            Console.Write("\nContinue? (yes/no or y/n): ");
            answer = Console.ReadLine()?.Trim().ToLower();

            if (string.IsNullOrEmpty(answer) || !(answer == "y" || answer == "yes"))
            {
                Console.WriteLine("\nThank you for using this calculator! :)");
                break;
            }
            else
                Console.WriteLine("\n--- Another Calculation ---");
        }
    }
}