using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using WpfApp1.Models;
using WpfApp1.Services;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Contact> contacts = new ObservableCollection<Contact>();
        private readonly FileService file = new();

        public MainWindow()
        {
            InitializeComponent();
            file.FilePath = @$"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\content.json";

            PopulateContactList();
            
        }

        private void PopulateContactList()
        {
            try
            {
                var items = contacts = JsonConvert.DeserializeObject<ObservableCollection<Contact>>(file.Read());
                if (items != null)
                    contacts = items;
            }
            catch { }

            lv_Contact.ItemsSource = contacts;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Btn_Add_Click(object sender, RoutedEventArgs e)
        {
            contacts.Add (new Contact
            {
                FirstName = tb_FirstName.Text,
                LastName = tb_LastName.Text,
                Email = tb_Email.Text,
                PhoneNumber = tb_PhoneNumber.Text,
                Address = tb_Address.Text
            });

            file.Save(JsonConvert.SerializeObject(contacts));
            ClearFrom();
        }  
        private void ClearFrom()
        {
            tb_FirstName.Text = "";
            tb_LastName.Text = "";
            tb_Email.Text = "";
            tb_PhoneNumber.Text = "";
            tb_Address.Text = "";
        }

        private void lbox_NavMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
