namespace Assignment2B;
internal class Program
{
    static void Main(string[] args)
    {
        // Set title in console window
        Console.Title = "Guess the Number";

        // Instantiate and start game object
        GuessTheNumber game = new ();
        game.Start();
    }
}