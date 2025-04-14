using System;

namespace Assignment5.Models
{
    public class Contact
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public Address Address { get; set; } = new Address();
        public PhoneNumber Phone { get; set; } = new PhoneNumber();
        public Email Email { get; set; } = new Email();
    }

    public class PhoneNumber
    {
        public string HomePhone { get; set; } = string.Empty;
        public string CellPhone { get; set; } = string.Empty;
    }

    public class Address
    {
        public string Street { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string ZipCode { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
    }
}
