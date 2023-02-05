using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DevExpress.XtraPrinting;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing.Text;
using System.IO.Packaging;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using WpfAdressbok.Models;
using WpfAdressbok.Services;
using WpfAdressbok.Views;

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
