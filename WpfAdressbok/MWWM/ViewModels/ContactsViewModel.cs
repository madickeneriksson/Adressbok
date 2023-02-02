using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public void Edit()
        {
            ContactService.Edit(SelectedContact);
        }

        [RelayCommand]
        public void Remove()

        {
            MessageBoxResult result;

            result = MessageBox.Show("Är du säker på att du vill ta bort kontakten?", "Ta bort kontakt", MessageBoxButton.YesNo);

            if (result == MessageBoxResult.Yes)
            {
                ContactService.Remove(SelectedContact);
            }

            else
            {

            }

            
        }   
    }
}
