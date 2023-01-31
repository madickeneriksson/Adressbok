﻿using System;
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

            ContactService.Remove(contact);
        }

        private void ListView_Selected(object sender, RoutedEventArgs e)
        {
            var listViewItem = (ListViewItem)sender;
            var contact = (ContactModel)listViewItem.DataContext;

            MessageBox.Show(contact.DisplayName);

        }
    }
}
