using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
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

    }
}
