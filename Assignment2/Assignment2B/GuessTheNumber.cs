namespace Assignment2B;
internal class GuessTheNumber
{
    private readonly Random random = new();

    public void Start()
    {
        bool play = true; // Flag to control the game loop

        DisplayGameInfo();

        while (play)
        {
            // Enhancement (Optional) - Adding number of NumAttempts depending on the Level
            int LevelAttempt = Levels();
            PlayGame(LevelAttempt);
            play = PlayAgain();
        }

        Console.WriteLine("\nCome back soon! Cannot wait to see u again :)");
    }

    private int Levels()
    {
        Console.WriteLine("====== Number of NumAttempts ======");
        Console.WriteLine(" * Level 0: Unlimited NumAttempts");
        Console.WriteLine(" * Level 1: 10 NumAttempts");
        Console.WriteLine(" * Level 2:  8 NumAttempts");
        Console.WriteLine(" * Level 3:  5 NumAttempts");
        Console.WriteLine(" -.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.- ");
        Console.Write("Choose a Level (0-3): ");

        int level;
        while (!int.TryParse(Console.ReadLine(), out level) || level < 0 || level > 3)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Invalid choice. Please enter a number between 0 and 3: ");
            Console.ResetColor();
        }

        int LevelAttempt;
        switch (level)
        {
            case 1:
                LevelAttempt = 10;
                break;
            case 2:
                LevelAttempt = 8;
                break;
            case 3:
                LevelAttempt = 5;
                break;
            case 0:
                LevelAttempt = int.MaxValue; // Unlimited NumAttempts with "MaxValue" for an integer
                break;
            default:
                Console.WriteLine("Level not recognized"); // Just in case the switch fails for any reason (Should not happen)
                LevelAttempt = 0;
                break;
        }
        return LevelAttempt;
    }

    private void PlayGame(int LevelAttempt)
    {
        int RandomNum = random.Next(0, 100); // Generate a random number from 0-100
        int NumAttempts = 0; // Number of attempts the user enters

        while (NumAttempts < LevelAttempt)
        {
            NumAttempts++;
            int UserGuess = ReadIntegerConsole($"Attempt {NumAttempts}/{LevelAttempt} - Enter your guess: ");

            if (UserGuess == RandomNum)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n++++++++  Congratulations! +++++++++");
                Console.ResetColor();
                Console.WriteLine($"\n🎉 You guessed the number with {LevelAttempt - NumAttempts} attempts left");
                return; // Exit the method "PlayGame()"
            }

            Console.WriteLine(UserGuess > RandomNum ? "Too high!" : "Too low!");
        }

        Console.WriteLine($"\nGame Over, Max number of attempts reached!");
        Console.WriteLine($"\nThe correct number was {RandomNum}");
    }

    private bool PlayAgain()
    {
        Console.Write("\nPlay again? (y/n): ");
        char response = char.ToLower(Console.ReadKey().KeyChar);
        Console.WriteLine();
        return response == 'y';
    }

    private void DisplayGameInfo()
    {
        Console.WriteLine("\n--------------------------GUESS THE NUMBER--------------------------");
        Console.WriteLine("   The computer selects a random value between 0 and 99");
        Console.WriteLine("   You have guesss the number. The game will let you");
        Console.WriteLine("   know whether your guess is correct, greater than or");
        Console.WriteLine("   less than the random number.");
        Console.WriteLine("\n🎯 You can set the number of guessing attempts");
        Console.WriteLine("by selecting a difficulty Level to make the game more challenging.");
        Console.WriteLine("-------------------------------------------------------------------\n");
    }

    private int ReadIntegerConsole(string message)
    {
        int number;
        Console.Write(message);
        while (!int.TryParse(Console.ReadLine(), out number) || number < 0 || number > 99)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Invalid input. Please enter a number between 0 and 99: ");
            Console.ResetColor();
        }
        return number;
    }
}