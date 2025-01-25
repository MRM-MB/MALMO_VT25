namespace Assignment1Part1;
class Program
{
    static void Main (string[] args)
    {
        // pet object
        Pet pet = new();
        pet.Start();

        Console.WriteLine("Press ENTER to start next part!\n");
        Console.ReadLine();

        // album object
        Album album = new();
        album.Start();

        Console.WriteLine("Press ENTER to start next part!\n");
        Console.ReadLine();

        // ticket object
        TicketSeller ticket = new();
        ticket.Start();
    }
}