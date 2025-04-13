using Assignment5;
using System.Linq;

public class Customer
{
    public string ID { get; set; } = string.Empty;
    public Contact ContactDetails { get; set; } = new Contact();

    // DisplayName property with padding for consistent spacing
    public string DisplayName =>
        $"{ID.PadRight(35)}" +                                // ID column with width 35
        $"{ContactDetails.LastName.PadRight(1)} , " +         // Last Name with width 1
        $"{ContactDetails.FirstName.PadRight(65)}  " +        // First Name with width 65
        $"{ContactDetails.Phone.CellPhone.PadRight(60)}  " +  // CellPhone column with width 60
        $"{ContactDetails.Email.Work}";                       // Updated to use Work instead of BusinessEmail
}




