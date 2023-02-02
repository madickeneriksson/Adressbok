using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DevExpress.XtraPrinting;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO.Packaging;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using WpfAdressbok.Models;
using WpfAdressbok.Services;

namespace WpfAdressbok.MWWM.ViewModels
{
    public partial class AddContactViewModel : ObservableObject
    {
        [ObservableProperty]
        private string title = "Add Contacts";


        [ObservableProperty]
        private ObservableCollection<ContactModel> contacts = ContactService.Contacts();

        [ObservableProperty]
        private ContactModel selectedContact = null!;

        [RelayCommand]
        public void Add()
            
            
        {    
            ContactService.Add(SelectedContact);

           
         
        }
        public void ClearForm()
        {

        }


    }
}
