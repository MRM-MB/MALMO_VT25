namespace Assignment1Part1;

public class TicketSeller
{   // deafult attributes
    private string? name;
    private double price = 99;
    private int numOfAdults;
    private int numOfChildren;
    private double amountToPay;

    // custom attributes for children price
    private double discountprice = 20;
    private bool buyChildTicket;

    public void Start()
    {
        Console.WriteLine("\nStarting the Ticket Seller program 🎫");
        TakeUserInput();
        DisplayInfo();   
    }

    public void TakeUserInput()
    {
        // Name of the customer
        Console.WriteLine("\nTicket purchase for AVENGERS DOOMSDAY\n");
        Console.WriteLine("\nWhat is your name?\n");
        name = Console.ReadLine();

        // Adult tickets
        Console.WriteLine("\nHello " + name + ", the price for an adult ticket is " + price + " $\n");
        Console.WriteLine("\nHow many adult tickets would you like?");
        string? AdultTickets = Console.ReadLine();
        numOfAdults = int.Parse(AdultTickets);

        // Have any Children y/n
        Console.WriteLine("\nWould you like to purchase a child ticket (y/n)?");
        string? strbuyChildTicket = Console.ReadLine().Trim().ToLower();
        char response = strbuyChildTicket[0];

        if (response == 'y')
        {
            buyChildTicket = true;
            Console.WriteLine("\n🎉 Children's tickets are " + discountprice + "% off adult tickets 🎉");
            Console.WriteLine("\nHow many children tickets would you like?");
            string? ChildrenTickets = Console.ReadLine();
            numOfChildren = int.Parse(ChildrenTickets);
        }
        
        else
        {
            buyChildTicket = false;
        }
    }

    public void DisplayInfo()
    {
        Console.WriteLine();
        Console.WriteLine("Customer Name: " + name);
        Console.WriteLine("Number of adult tickets: " + numOfAdults);
        if(buyChildTicket)
            Console.WriteLine("Number of children tickets: " + numOfChildren);
        else
            Console.WriteLine("No children tickets");
        Console.WriteLine("_________________________________");

        amountToPay = (numOfAdults * price) + (numOfChildren * ((100 - discountprice) / 100) * price);
        Console.WriteLine("Total amount to pay: " + amountToPay + " $");
    }
}