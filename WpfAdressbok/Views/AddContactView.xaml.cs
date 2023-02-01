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
    /// Interaction logic for AddContactView.xaml
    /// </summary>
    public partial class AddContactView : UserControl
    {
        public AddContactView()
        {
            InitializeComponent();
        }

        private void btn_Create_Click(object sender, RoutedEventArgs e)
        {
            {
                var button = (Button)sender;
                var contact = (ContactModel)button.DataContext;

                ContactService.Add(contact);
                {
                    contact.FirstName = tb_FirstName.Text;
                    contact.LastName = tb_LastName.Text;
                    contact.Email = tb_Email.Text;
                    contact.Address = tb_Address.Text;
                    contact.PostalCode= tb_PostalCode.Text;
                    contact.City = tb_City.Text;

                }
            }

        }
    }
}
