namespace Assignment1Part1;

public class Album
{
    private string? albumName;
    private string? artistName;
    private int numOfTracks;

    public void Start()
    {
        Console.WriteLine("\nStarting the Album program 🎵");
        TakeUserInput();
        DisplayInfo();   
    }

    public void TakeUserInput()
    {
        // Name of the album
        Console.Write("\nWhat is the name of your favourite music album?\n");
        albumName = Console.ReadLine();

        // Age
        Console.Write("\nWhat is name of the Artist or Band for " + albumName + "?\n");
        artistName = Console.ReadLine();

        // Female y/n
        Console.Write("\nHow many tracks does " + albumName + " have?\n");
        string? strnumOfTracks = Console.ReadLine();
        numOfTracks = int.Parse(strnumOfTracks);
    }

    public void DisplayInfo()
    {
        Console.WriteLine();
        Console.WriteLine("Album Name: " + albumName);
        Console.WriteLine("Artist / Band: " + artistName);
        Console.WriteLine("Number of Tracks: " + numOfTracks);
        Console.WriteLine("\nEnjoy Listening 🎧");
        Console.WriteLine();
    }
}