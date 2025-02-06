using System;

namespace Assignment2D
{
    public class Scheduler
    {
        // Method to generate work schedule for a given start week, end week, and interval
        public void GenerateSchedule(int startWeek, int endWeek, int interval)
        {
            Console.WriteLine($"Scheduling for weeks {startWeek} to {endWeek} with an interval of {interval} weeks:");
            for (int week = startWeek; week <= endWeek; week += interval)
            {
                int year = ((week - 1) / 52) + 1; // Calculate which year the week falls in
                int displayWeek = ((week - 1) % 52) + 1; // Reset week count per year
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
                        GenerateSchedule(1, totalWeeks, 2);
                        break;
                    case 2:
                        GenerateSchedule(2, totalWeeks, 4);
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
            int startWeek = int.Parse(Console.ReadLine());

            Console.Write("Enter the end week (1-" + totalWeeks + "): ");
            int endWeek = int.Parse(Console.ReadLine());

            Console.Write("Enter the interval (in weeks): ");
            int interval = int.Parse(Console.ReadLine());

            if (startWeek < 1 || startWeek > totalWeeks || endWeek < 1 || endWeek > totalWeeks || interval < 1)
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
                GenerateSchedule(startWeek, endWeek, 2);
            }
            else if (choice == 2)
            {
                GenerateSchedule(startWeek, endWeek, 4);
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
}