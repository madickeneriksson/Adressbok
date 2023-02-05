
using System.Windows;
using System.Windows.Controls;
using WpfAdressbok.Models;
using WpfAdressbok.Services;

namespace WpfAdressbok.Views
{
    /// <summary>
    /// Interaction logic for ContactsView.xaml
    /// </summary>
    public partial class ContactsView : UserControl
    {
        public ContactsView()
        {
            InitializeComponent();
        }

        private void btn_Remove_Click(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var contact = (ContactModel)button.DataContext;
    
            MessageBoxResult result;

            result = MessageBox.Show("Är du säker på att du vill ta bort kontakten?", "Ta bort kontakt", MessageBoxButton.YesNo);

            if (result == MessageBoxResult.Yes)
            {
                ContactService.Remove(contact);
            }

            else { }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            EditContactForm.Visibility = Visibility.Visible;
        }
    }
}
