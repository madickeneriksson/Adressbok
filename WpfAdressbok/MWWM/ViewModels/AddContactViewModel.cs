using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows;
using WpfAdressbok.Models;
using WpfAdressbok.Services;


namespace WpfAdressbok.MWWM.ViewModels
{
    public partial class AddContactViewModel : ObservableObject
    {
        [ObservableProperty]
        private string title = "Add Contacts";

        [ObservableProperty]
        private ContactModel contact = new ContactModel();


        [RelayCommand]
        public void Add()
        {
            MessageBoxResult result;

            result = MessageBox.Show("Vill du skapa kontakten?", "Ny kontakt", MessageBoxButton.YesNo);

            if (result == MessageBoxResult.Yes)
            {
                ContactService.Add(contact);
            }

            else
            {

            }
            
        }
     
    }
}
