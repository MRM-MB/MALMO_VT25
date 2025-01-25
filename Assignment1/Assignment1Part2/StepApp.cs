namespace Assignment1Part2;

class StepApp
{
    // Constant for daily step goal
    private const int DailyStepGoal = 10000;
    // Store the time of user
    private DateTime UserTime;
    // User's step count
    private int CurrentSteps;

    public void Start()
    {
        InformStepGoal();
        TakeUserInput();
    }
    
    // Inform users about the daily step goal
    public void InformStepGoal()
    {
        Console.WriteLine("\n🏃 Welcome to the Step Motivation App! 🏃\n");
        Console.WriteLine($"\nYour daily step goal is {DailyStepGoal} steps to maintain good health. Let's see how you're doing today!\n");
    }

    // Get time and steps
    public void TakeUserInput()
    {

        // Get the current time from the user
        Console.Write("\nWhat hour is it now (0-23)? ");
        if (int.TryParse(Console.ReadLine(), out int hour) && hour >= 0 && hour < 24)
        {
            UserTime = new DateTime(1, 1, 1, hour, 0, 0);

            // Get the current step count from the user
            Console.Write("\nHow many steps have you walked today? ");
            if (int.TryParse(Console.ReadLine(), out int steps) && steps >= 0)
            {
                CurrentSteps = steps;
                ProvideFeedback();
            }
            else
            {
                Console.WriteLine("\nInvalid step count. Please enter a valid number.");
            }
        }
        else
        {
            Console.WriteLine("\nInvalid time. Please enter a valid hour between 0 and 23.");
        }
    }

    private void ProvideFeedback()
    {
        int hour = UserTime.Hour;

        Console.WriteLine("\n-🟢- Step Motivation Feedback -🟢-");

        // Time feedback
        if (hour < 6)
        {
            Console.WriteLine("\nIt's early morning! You've got the whole day to crush your step goal 💪");
        }
        else if (hour < 12)
        {
            Console.WriteLine("\nGood morning! You're off to a great start ⭐");
        }
        else if (hour < 18)
        {
            Console.WriteLine("\nGood afternoon! There's still plenty of time to achieve your goal 🎯");
        }
        else if (hour < 21)
        {
            Console.WriteLine("\nGood evening! Don't give up now. You can still make it 🤗");
        }
        else
        {
            Console.WriteLine("\nIt's late at night. Reflect on today's efforts and plan for tomorrow 🚩");
        }

        // Steps feedback
        if (CurrentSteps >= DailyStepGoal)
        {
            Console.WriteLine($"\nCongratulations! You've already achieved your daily step goal of {DailyStepGoal} steps.");
        }
        else
        {
            int stepsRemaining = DailyStepGoal - CurrentSteps;
            Console.WriteLine($"\nYou're {stepsRemaining} steps away from your goal. Keep moving!");
        }
    }
}