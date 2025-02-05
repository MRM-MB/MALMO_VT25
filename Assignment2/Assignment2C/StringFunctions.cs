namespace Assignment2C;
class MultiplePrograms
{
    // a) String length
    public void StringLength()
    {
        Console.WriteLine("\n=================================================");
        Console.WriteLine("👉 Welcome to the Super Duper String Detailer! 🎉");
        Console.WriteLine("=================================================\n");
        Console.Write("Enter text: ");
        string text = Console.ReadLine();
        int length = text.Length; 
        string UpperText = text.ToUpper();

        Console.WriteLine("\n⭐ Details about your text ⭐\n");
        Console.WriteLine($"- Length: {length} characters");
        Console.WriteLine($"\n- Uppercase version: {UpperText}");
    }

    // b) Day of the week quotes
    public void PredictMyDay()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\nPRESS ENTER to start the Week Commenter Program");
        Console.ResetColor();

        Console.ReadLine();
        Console.WriteLine("\n=================================================");
        Console.WriteLine("Welcome to Super Savvy Comments of the Week! 🎉");
        Console.WriteLine("=================================================\n");

        int day;
        do
        {
            Console.Write("Enter a number between 1 and 7 to get a quote of your day day: ");
            Console.WriteLine(@"

    1 - Monday 😴
    2 - Tuesday 💪
    3 - Wednesday 🏃
    4 - Thursday 🚀
    5 - Friday 🎉
    6 - Saturday 🏖️
    7 - Sunday ☕");

            // Validate input
            Console.Write("\nEnter number: ");
            if (!int.TryParse(Console.ReadLine(), out day) || day < 1 || day > 7)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input!\n");
                Console.ResetColor();
            }

        } while (day < 1 || day > 7);

        switch (day)
        {
            case 1:
                Console.WriteLine("\n🟢 Keep calm on Mondays! You can fall apart!");
                break;
            case 2:
                Console.WriteLine("\n🟢 Tuesdays give you the strength to keep going.");
                break;
            case 3:
                Console.WriteLine("\n🟢 Wednesdays are the sprint to the halfway point of the week.");
                break;
            case 4:
                Console.WriteLine("\n🟢 Thursday is your lucky day—don't just wait for Friday!");
                break;
            case 5:
                Console.WriteLine("\n🟢 Friday—time to celebrate the well-deserved weekend!");
                break;
            case 6:
                Console.WriteLine("\n🟢 Saturday—relax, unwind, and make the most of it!");
                break;
            case 7:
                Console.WriteLine("\n🟢 Sunday always comes too soon!");
                break;
            default:
                Console.WriteLine("No day? A good day but it doesn't exist!");
                break;
        }
    }

    // c) Repeat the week quotes programm
    public void RunAgain()
    {
        string userResponse;
        do
        {
            // Call the previous methods
            StringLength(); // string legth program
            PredictMyDay(); // quote day program

            Console.Write("\nWould you like to go again? (y/n): ");
            userResponse = Console.ReadLine(); // Get user input

            if(userResponse != "y")
            {
                Console.WriteLine("\nThank you so much for using all my programs!");
                Console.WriteLine("Have a nice rest of your day :)\n");
                break;
            }

        } while (userResponse.ToLower() == "y");
    }
}