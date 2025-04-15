//Code provided by Farid Naisan

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Email
{
    // Private email address
    private string personalMail = string.Empty;
    // Office email address
    private string officeMail = string.Empty;

    // Constructors are overloaded and called in a chain

    /// <summary>
    /// Default constructor - initializes fields with default values.
    /// </summary>
    public Email()
    {
        // Fields are initialized with default values at declaration
    }

    /// <summary>
    /// Constructor with one parameter - calls the constructor with 
    /// two parameters, using an empty string as the second argument.
    /// </summary>
    /// <param name="workMail">Office email address provided by the client</param>
    public Email(string workMail) : this(workMail, string.Empty)
    {
    }

    /// <summary>
    /// Copy constructor - creates a new Email object with the same values as the provided one.
    /// </summary>
    /// <param name="theOther">The Email object to copy from</param>
    public Email(Email theOther)
    {
        this.personalMail = theOther.personalMail;
        this.officeMail = theOther.officeMail;
    }

    /// <summary>
    /// Constructor with two parameters. This is the constructor with the most
    /// parameters and contains the main initialization logic.
    /// </summary>
    /// <param name="workMail">Office email address</param>
    /// <param name="personalMail">Personal email address</param>
    public Email(string workMail, string personalMail)
    {
        officeMail = workMail;
        this.personalMail = personalMail;
    }

    /// <summary>
    /// Property for accessing and modifying the personal email address.
    /// </summary>
    public string Personal
    {
        get { return personalMail; }
        set { personalMail = value; }
    }

    /// <summary>
    /// Property for accessing and modifying the work email address.
    /// </summary>
    public string Work
    {
        get { return officeMail; }
        set { officeMail = value; }
    }

    /// <summary>
    /// Provides a formatted string to be used as a header in the UI.
    /// This header format matches the data format in the ToString method.
    /// </summary>
    /// <returns>A formatted string to be used as a column header in the ListBox</returns>
    public string GetToStringItemsHeadings
    {
        get { return string.Format("{0,-20} {1, -20}", "Office EmailData", "Private EmailData"); }
    }

    /// <summary>
    /// Returns a formatted string containing the email addresses.
    /// Use a monospaced font for proper column alignment when displaying.
    /// </summary>
    /// <returns>A formatted string representation of the email addresses</returns>
    public override string ToString()
    {
        string strOut = "\n" + "Emails" + "\n";

        strOut += string.Format(" {0,-10} {1, -10}\n", "Private", personalMail);
        strOut += string.Format(" {0,-10} {1, -10}\n\n", "Office", officeMail);

        return strOut;
    }
}