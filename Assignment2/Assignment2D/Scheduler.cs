namespace Assignment2D;
public class Scheduler
{
    // Variables declared at class level
    private string? workType; // Night or Weekends
    private int numYears; // Number of working years to get the total weeks
    private int totalWeeks; // Total weeks from the years entered
    private bool runAgain = true; // Loop to present the menu again until exit

    // Optional part - Ask the user for the start-interval-end weeks and years
    private int start;
    private int interval;
    private int end;

    // Start of the program
    // Players can choose either to print the work schedule or enter the start, interval and end week, as well as the year.
    public void Start()
    {
        Console.WriteLine("\n========================================");
        Console.WriteLine("💼 WELCOME to Work Presenter (WoPre) 💼");
        Console.WriteLine("========================================\n");

        // Get a valid number of years input
        numYears = GetValidInteger("Number of years to work: ", 1);

        Console.WriteLine("\n\nDo you want to use the default schedule or provide custom parameters?\n");
        Console.WriteLine("1. Default schedule");
        Console.WriteLine("2. Custom schedule");

        int input = GetValidInteger("\nEnter your choice (1 or 2): ", 1, 2);

        if (input == 1)
        {
            Menu(numYears);
        }
        else
        {
            SpecifiedParameters();
        }
    }

    // Method to validate and get integer input within a given range
    public int GetValidInteger(string text, int min, int max = int.MaxValue)
    {
        int value = 0;
        bool inputInvalid = true;

        while (inputInvalid)
        {
            Console.Write(text);
            string? userNum = Console.ReadLine();

            if (int.TryParse(userNum, out value) && value >= min && value <= max)
            {
                inputInvalid = false;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nEnter a valid positive number");
                Console.ResetColor();
            }
        }
        return value;
    }

    // Create the Schedule for start, interval and end week
    public void CreateSchedule(int start, int end, int interval)
    {
        Console.WriteLine("\n=========================");
        Console.WriteLine($" Work {workType} ");
        Console.WriteLine("=========================\n");
        Console.WriteLine($"From week {start} to {end}:\n");
        Console.WriteLine($"You will be scheduled to work every {interval} weeks.\n");

        int columns = 4; // Number of columns
        int count = 0;

        for (int week = start; week <= end; week += interval)
        {
            Console.Write($"Week {week,-8}"); // Aligns text

            count++;
            if (count % columns == 0) // Break to a new line every 'columns' (4) weeks
            {
                Console.WriteLine();
            }
        }
        Console.WriteLine("\n"); // Extra spacing after schedule
    }

    // Get user input and showcase the Default Work Menu
    public void Menu(int numYears)
    {
        totalWeeks = numYears * 52;

        while (runAgain)
        {
            Console.WriteLine("\n*-*-*-*-*-*-*-*-*-*");
            Console.WriteLine(" Default Work Menu ");
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*\n");
            Console.WriteLine("1. Weekends ☕");
            Console.WriteLine("2. Night Shifts 🌙");
            Console.WriteLine("3. Exit 👋");

            int input = GetValidInteger("\nEnter input (1-3): ", 1, 3);

            switch (input)
            {
                case 1:
                    workType = "☕ Weekends ☕";

                    // Interval of 2 weeks for Weekends
                    CreateSchedule(1, totalWeeks, 2);
                    break;
                case 2:
                    workType = "🌙 Night Shifts 🌙";

                    // Interval of 4 weeks for Nights
                    CreateSchedule(2, totalWeeks, 4);
                    break;
                case 3:
                    Console.WriteLine("\nHave a nice day at work!");
                    Console.WriteLine("I hope to see you again soon 🤗\n");
                    runAgain = false;
                    break;
            }
        }
    }

    // Method for user to input parameters with a looping Custom Work Menu
    public void SpecifiedParameters()
    {
        Console.WriteLine("\nEnter the parameters to customize how your work is showed\n");
        totalWeeks = numYears * 52;

        while (runAgain)
        {
            Console.WriteLine("\n*-*-*-*-*-*-*-*-*-*");
            Console.WriteLine(" Custom Work Menu ");
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*\n");
            Console.WriteLine("1. Weekends ☕");
            Console.WriteLine("2. Night Shifts 🌙");
            Console.WriteLine("3. Exit 👋");

            int input = GetValidInteger("\nEnter input (1-3): ", 1, 3);

            switch (input)
            {
                case 1:
                    workType = "☕ Weekends ☕";
                    DataToEnter();
                    CreateSchedule(start, end, interval);
                    break;
                case 2:
                    workType = "🌙 Night Shifts 🌙";
                    DataToEnter();
                    CreateSchedule(start, end, interval);
                    break;
                case 3:
                    Console.WriteLine("\nHave a nice day at work!");
                    Console.WriteLine("I hope to see you again soon 🤗\n");
                    runAgain = false;
                    break;
            }
        }
    }
    
    // Method to get the weeks from the user in Custom Work Menu
    public void DataToEnter()
    {
        start = GetValidInteger($"\nStart week (1-{totalWeeks}): ", 1, totalWeeks);
        end = GetValidInteger($"End week ({start}-{totalWeeks}): ", start, totalWeeks);
        interval = GetValidInteger("Interval (in weeks): ", 1);
    }
}