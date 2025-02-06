namespace Assignment2D;
public class Scheduler
{
    // Create the Schedule for start, interval and end week
    public void CreateSchedule(int start, int interval, int end)
    {
        Console.WriteLine("\n=============================");
        Console.WriteLine(" Here is your work Schedule ");
        Console.WriteLine("=============================\n");
        Console.WriteLine($"From week {start} to {end}:");
        for (int week = start; week <= end; week += interval)
        {
            int year = ((week - 1) / 52) + 1; // Identify the year from the week
            int displayWeek = ((week - 1) % 52) + 1; // Reset week per year
            Console.WriteLine($"Year {year}, Week {displayWeek}");
        }
    }

    // Method to display the menu and prompt user input
    public void DisplayMenu(int numYears)
    {
        int choice;
        bool continueRunning = true;
        int totalWeeks = numYears * 52;

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
                    CreateSchedule(1, totalWeeks, 2);
                    break;
                case 2:
                    CreateSchedule(2, totalWeeks, 4);
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

    // Method for user to input parameters
    public void UserDefinedSchedule()
    {
        Console.WriteLine("\nEnter the scheduling parameters:");
        Console.Write("Enter the number of years: ");
        int numYears = int.Parse(Console.ReadLine());
        int totalWeeks = numYears * 52;

        Console.Write("Enter the start week (1-" + totalWeeks + "): ");
        int start = int.Parse(Console.ReadLine());

        Console.Write("Enter the end week (1-" + totalWeeks + "): ");
        int end = int.Parse(Console.ReadLine());

        Console.Write("Enter the interval (in weeks): ");
        int interval = int.Parse(Console.ReadLine());

        if (start < 1 || start > totalWeeks || end < 1 || end > totalWeeks || interval < 1)
        {
            Console.WriteLine("Invalid input! Please enter valid week numbers and a positive interval.");
            return;
        }

        Console.WriteLine("1. Weekends");
        Console.WriteLine("2. Night Shifts");
        Console.Write("Choose 1 or 2: ");
        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            CreateSchedule(start, end, 2);
        }
        else if (choice == 2)
        {
            CreateSchedule(start, end, 4);
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

        Console.WriteLine("Welcome to the Employee Scheduler!");
        Console.Write("Enter the number of years for scheduling: ");
        int numYears = int.Parse(Console.ReadLine());

        Console.WriteLine("Do you want to use the default schedule or provide custom parameters?");
        Console.WriteLine("1. Default schedule (weekends every 2nd week, night shifts every 4th week)");
        Console.WriteLine("2. Custom schedule");

        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            scheduler.DisplayMenu(numYears);
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