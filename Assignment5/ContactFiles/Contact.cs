namespace Assignment5.ContactFiles
{
    public class Contact
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public Phone Phone { get; set; } = new Phone { HomePhone = string.Empty, CellPhone = string.Empty };
        public Email Email { get; set; } = new Email();
        public Address Address { get; set; } = new Address();
    }
}
