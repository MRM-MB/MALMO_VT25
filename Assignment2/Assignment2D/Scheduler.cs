namespace Assignment2D;
public class Scheduler
{
    // Method to generate work weeks for a given start week, end week, and interval
    public void GenerateSchedule(int startWeek, int endWeek, int interval)
    {
        Console.WriteLine($"Scheduling for weeks {startWeek} to {endWeek} with an interval of {interval} weeks:");
        for (int week = startWeek; week <= endWeek; week += interval)
        {
            Console.WriteLine($"Week {week}");
        }
    }

    // Method to display the menu and prompt user input
    public void DisplayMenu()
    {
        int choice;
        bool continueRunning = true;

        while (continueRunning)
        {
            Console.WriteLine("\nScheduler Menu:");
            Console.WriteLine("1. Weekends (every 2nd weekend starting from week 1)");
            Console.WriteLine("2. Night Shifts (every 4th week starting from week 2)");
            Console.WriteLine("3. Exit");

            Console.Write("Enter your choice (1-3): ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    // Weekends: every 2nd weekend starting from week 1
                    GenerateSchedule(1, 52, 2);
                    break;
                case 2:
                    // Night shifts: every 4th week starting from week 2
                    GenerateSchedule(2, 52, 4);
                    break;
                case 3:
                    Console.WriteLine("Exiting the program...");
                    continueRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter 1, 2, or 3.");
                    break;
            }
        }
    }

    // Optional: Method for user to input parameters (start week, end week, and interval)
    public void UserDefinedSchedule()
    {
        Console.WriteLine("\nEnter the year parameters for the schedule:");
        Console.Write("Enter the start week (1-52): ");
        int startWeek = int.Parse(Console.ReadLine());

        Console.Write("Enter the end week (1-52): ");
        int endWeek = int.Parse(Console.ReadLine());

        Console.Write("Enter the interval (in weeks): ");
        int interval = int.Parse(Console.ReadLine());

        // Validate the input
        if (startWeek < 1 || startWeek > 52 || endWeek < 1 || endWeek > 52 || interval < 1)
        {
            Console.WriteLine("Invalid input! Please enter valid week numbers (1-52) and a positive interval.");
            return;
        }

        // Ask the user which schedule they want to see
        Console.WriteLine("1. Weekends");
        Console.WriteLine("2. Night Shifts");

        Console.Write("Choose 1 or 2: ");
        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            GenerateSchedule(startWeek, endWeek, 2); // Weekends: every 2nd week
        }
        else if (choice == 2)
        {
            GenerateSchedule(startWeek, endWeek, 4); // Night shifts: every 4th week
        }
        else
        {
            Console.WriteLine("Invalid choice! Please enter 1 or 2.");
        }
    }
}

public class Program
{
    public static void Main()
    {
        Scheduler scheduler = new Scheduler();

        // Display menu with options
        Console.WriteLine("Welcome to the Employee Scheduler!");
        Console.WriteLine("Do you want to use the default schedule or provide custom parameters?");
        Console.WriteLine("1. Default schedule (1st and 2nd week intervals)");
        Console.WriteLine("2. Custom schedule");

        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            scheduler.DisplayMenu();
        }
        else if (choice == 2)
        {
            scheduler.UserDefinedSchedule();
        }
        else
        {
            Console.WriteLine("Invalid choice! Exiting...");
        }
    }
}