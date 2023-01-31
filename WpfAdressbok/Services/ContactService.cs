using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAdressbok.Models;

namespace WpfAdressbok.Services
{
    public static class ContactService
    {
        private static ObservableCollection<ContactModel> contacts = new ObservableCollection<ContactModel>()
        {
            new ContactModel() {FirstName = "hej", LastName = "hej"}
        };

        public static void Add(ContactModel model) 
        {
            contacts.Add(model);
        }
        public static void Remove(ContactModel model)
        {
            contacts.Remove(model);
        }
        public static ObservableCollection<ContactModel> Contacts()
        { 
            return contacts;
        }
    }
}
