namespace Assignment2C;
class TempConverter
{
    // Variables for the program
    private double fahrenheit;
    private double celsius;

    private int input; // Get the choice menu from the user
    
    /// <summary>
    /// 
    /// *-*-*-* WHY 4 COLUMNS ? *-*-*-*
    /// 
    /// Table Distribution for Celsius and Fahrenheit Values:
    /// The conversion table needs to display values in a grid format with a number of columns.
    /// - Case 1: Fahrenheit values from 0 to 212 (213 values total)
    /// - Case 2: Celsius values from 0 to 100 (101 values total)
    /// 
    /// To evenly distribute these values across columns, I used the Greatest Common Factor (GCF)
    /// in both ranges (100 for case 1 and 212 for case 1).
    /// - GCF(100, 212) = 4, 4 columns to evenly distribute the values.
    /// 
    /// For Case 1 (Fahrenheit to Celsius), we have 213 values, which can be divided into 4 columns.
    /// However, since 213 is not perfectly divisible by 4, one column will contain one more value than the others.
    /// 
    /// For Case 2 (Celsius to Fahrenheit), we have 101 values, which can be divided into 4 columns.
    /// Similarly, one column will have one more value than the others to ensure an even distribution across 4 columns.
    /// </summary>

    private int columns = 4;
    private int currentRow = 0;

    // Run the program with a do-while loop to print the Menu at least once
    public void Start()
    {
        do
        {
            Menu(); // Print the option Menu

            // Get the user input number (0-3)
            input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    // Fahrenheit to Celsius (0-212) values
                    for (fahrenheit = 0; fahrenheit <= 212; fahrenheit++)
                    {
                        double celsiusResult = FahrenheitToCelsius(fahrenheit);

                        // 4 columns and 53 rows
                        Console.Write("{0:F2} F = {1:F2} C\t", fahrenheit, celsiusResult);
                        currentRow++;

                        // New line after every 4th value
                        if (currentRow % columns == 0)
                        {
                            Console.WriteLine();
                        }
                    }
                    break;

                case 2:
                    // Celsius to Fahrenheit (0-100) values
                    for (celsius = 0; celsius <= 100; celsius++)
                    {
                        double fahrenheitResult = CelsiusToFahrenheit(celsius);

                        // 4 columns and 25 rows
                        Console.Write("{0:F2} C = {1:F2} F\t", celsius, fahrenheitResult);
                        currentRow++;

                        // New line after every 4th value
                        if (currentRow % columns == 0)
                        {
                            Console.WriteLine();
                        }
                    }
                    break;

                case 0:
                    Console.WriteLine("\nBYE!!! Have a nice day :)\n");
                    break;

                default:
                    Console.WriteLine("\nInvalid option. Select a value from (0-2)");
                    break;
            }

        } while (input != 0); // Loop until input == 0
    }

    // Celsius to Fahrenheit
    public double CelsiusToFahrenheit(double Celsius)
    {
        return (9.0 / 5.0) * Celsius + 32;
    }

    // Fahrenheit to Celsius
    public double FahrenheitToCelsius(double Fahrenheit)
    {
        return (5.0 / 9.0) * (Fahrenheit - 32);
    }

    // Menu for the User
    public void Menu()
    {
        Console.WriteLine("\n"); // Space
        Console.WriteLine("-*-*-* 🌡️  Super Temperature Converter  -*-*-*");
        Console.WriteLine("\n=============================================");
        Console.WriteLine("1. Fahrenheit to Celsius");
        Console.WriteLine("2. Celsius to Fahrenheit");
        Console.WriteLine("0: Exit the Converter");
        Console.WriteLine("=============================================\n");
        Console.Write("Enter your input (0-2): ");
    }
}