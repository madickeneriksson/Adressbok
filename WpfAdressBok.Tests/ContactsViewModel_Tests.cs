
using FluentAssertions;
using System.Collections.ObjectModel;
using WpfAdressbok.Models;
using WpfAdressbok.MWWM.ViewModels;

namespace WpfAdressBok.Tests
{
    public class ContactsViewModel_Tests
    {
        private ContactsViewModel viewModel;

        public ContactsViewModel_Tests()
        {
            viewModel= new ContactsViewModel();
        }

     
        [Fact]
        public void Should_Add_Contact_To_ContactList()
        {
            // act
            ContactModel contact = new ContactModel { FirstName = "Madicken", LastName = "Eriksson" };
            viewModel.Contacts.Add(contact);

            // assert
            viewModel.Contacts.Should().BeOfType<ObservableCollection<ContactModel>>();
            viewModel.Contacts.Should().Contain(contact);

        }
    }
}