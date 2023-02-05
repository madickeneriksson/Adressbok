using System;


namespace WpfAdressbok.Models
{
    public class ContactModel : Interfaces.IContactModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string PostalCode { get; set; } = null!;
        public string City { get; set; } = null!;

        public string DisplayName => $"{FirstName} {LastName}"; 
    }
}
