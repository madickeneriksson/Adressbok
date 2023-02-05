using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.ObjectModel;
using System.Windows;
using WpfAdressbok.Models;
using WpfAdressbok.Services;

namespace WpfAdressbok.MWWM.ViewModels
{
    public partial class ContactsViewModel : ObservableObject
    {

        [ObservableProperty]
        private string title = "Contacts";

        [ObservableProperty]
        private ObservableCollection<ContactModel> contacts = ContactService.Contacts();

        [ObservableProperty]
        private ContactModel selectedContact = null!;

     
 
        [RelayCommand]
        public void Remove()

        {
            MessageBoxResult result;

            result = MessageBox.Show($"Är du säker på att du vill ta bort kontakten? {selectedContact.DisplayName}", "Ta bort kontakt", MessageBoxButton.YesNo);

            if (result == MessageBoxResult.Yes)
            {
                contacts.Remove(selectedContact);
                ContactService.Remove(SelectedContact);
            }

            else { }
   
        }

        // yes and no box - cred to w3schools

        [RelayCommand]
        public void UpdateContact()

        {
            MessageBoxResult result;

            result = MessageBox.Show($"Vill du uppdatera kontakten {selectedContact.DisplayName} ?", "Uppdatera kontakten", MessageBoxButton.YesNo);

            if (result == MessageBoxResult.Yes)
            {
                Update(selectedContact.Id, selectedContact);

            }

            else { }
        }

       private void Update(Guid id, ContactModel contact)
        {
            ContactService.UpdateListItem(id, contact);
        }
    }
}
