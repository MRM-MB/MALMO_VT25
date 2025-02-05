namespace Assignment2C;
class Program
{
    static void Main (string[] args)
    {
        TempConverter temp = new();
        temp.Start();

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("PRESS ENTER to check out the String Functions program");
        Console.ResetColor();
        Console.ReadLine();

        MultiplePrograms multi = new();
        multi.RunAgain();
    }
}