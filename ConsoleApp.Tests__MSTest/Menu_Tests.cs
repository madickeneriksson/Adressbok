using ConsoleApp1.Models;
using ConsoleApp1.Services;
using System.ComponentModel.Design;

namespace ConsoleApp.Tests__MSTest
{
    [TestClass]
    public class Menu_Tests
    {
        [TestMethod]
        public void Should_Add_Contact_To_List()
        {
            // arrange
            Menu menu = new Menu();
            Contact contact = new Contact();
        

            // act
            menu.contacts.Add((Contact)contact);
           


            // assert
            Assert.AreEqual(1, menu.contacts.Count);
        }
    }
}