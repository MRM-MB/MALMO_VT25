namespace Assignment2A;

class Calculator 
{
    // Number of units purchased
    private int number;

    // Price per unit
    private float price;
    private float discount;

    // Varibles used in the Programm method for the calculations
    private float OriginalTotal;
    private float DiscountApplied;
    private float FinalTotal;

    // Starting the programm
    public void Start()
    {
        Programm();
    }

    // Make the calculations
    public void Calculations()
    {
        Console.WriteLine("Original Total Cost: ");
        Console.WriteLine("Discount Applied: ");
        Console.WriteLine("Final Total Cost: ");
    }

    public void Programm()
    {
        // STEP 1
        Console.WriteLine("STEP 1: CALCULATE TOTAL COST APPLYING DISCOUNT");
        Console.WriteLine("Enter the original price per unit: ");

        if(float.TryParse(Console.ReadLine(), out float price) && price >= 0)
        {
            Console.WriteLine("Enter the quantity of the product: ");
            if(int.TryParse(Console.ReadLine(), out int number) && number >= 0)
            {
                Calculations();
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a positive number.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a positive number.");
        }
    }
}