﻿
using System;

namespace WpfApp1.Models;

internal interface IContact

{
    Guid Id { get; set; }
    string FirstName { get; set; }
    string LastName { get; set; }
    string Email { get; set; }
    string PhoneNumber { get; set; }
    string Address { get; set; }
}

    internal class Contact : IContact
    {
        public Guid Id { get; set; } = Guid.NewGuid();    
        public string FirstName { get; set; } = null!;
        public string LastName { get ; set ; } = null!;
        public string Email { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string Address { get; set; } = null!;

}
