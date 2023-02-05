using DevExpress.Utils.CommonDialogs.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
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

        private void btn_Edit_Click(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var contact = (ContactModel)button.DataContext;

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

            else
            {

            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            EditContactForm.Visibility = Visibility.Visible;
        }
    }
}
