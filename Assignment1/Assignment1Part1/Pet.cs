namespace Assignment1Part1;

public class Pet 
{
    private string? name;
    private int age;
    private bool isFemale;

    public void Start()
    {
        Console.WriteLine("\nStarting the Pet program 🐶\n");
        TakeUserInput();
        DisplayInfo();   
    }

    public void TakeUserInput()
    {
        // Name
        Console.Write("What is the name of your pet? ");
        name = Console.ReadLine();

        // Age
        Console.Write("What is " + name + "'s age? ");
        age = int.Parse(Console.ReadLine());

        // Female y/n
        Console.Write("Is your pet a female (y/n)? ");
        string? gender = Console.ReadLine().Trim().ToLower();
        char response = gender[0];
        if (response == 'y')
            isFemale = true;
        else
            isFemale = false;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("\n==================================");
        Console.WriteLine("Name: " + name + "  Age: " + age);
        if(isFemale)
            Console.WriteLine(name + " is a good girl!");
        else
            Console.WriteLine(name + " is a good boy!");
        Console.WriteLine("==================================\n");
    }
}