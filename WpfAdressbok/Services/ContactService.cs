using DevExpress.Data.Extensions;
using Newtonsoft.Json;
using System;
using System.Collections.ObjectModel;
using WpfAdressbok.Models;

namespace WpfAdressbok.Services
{
    public static class ContactService
    {
        private static ObservableCollection<ContactModel> contacts;
        private static FileService fileService = new FileService($@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\content.json");

        static ContactService()
        {
            try
            {
                contacts = JsonConvert.DeserializeObject<ObservableCollection<ContactModel>>(fileService.Read())!;
            }
            catch { contacts = new ObservableCollection<ContactModel>(); }
        }
    
        public static void Add(ContactModel model)
        {
            contacts.Add(model);
            fileService.Save(JsonConvert.SerializeObject(contacts));
            
        }
        public static void Remove(ContactModel model)
        {
            contacts.Remove(model);
            fileService.Save(JsonConvert.SerializeObject(contacts));
        }

        public static void UpdateListItem(Guid id, ContactModel contact)
        {
            var item = contacts.FindIndex(x => x.Id == id);
            var index = contacts.FindIndex(item => item.Id == id);
            try
            {
                contacts.RemoveAt(index);
                contacts.Insert(index, contact);
                fileService.Save(JsonConvert.SerializeObject(contacts));
            }
            catch { }

        }

        public static ObservableCollection<ContactModel> Contacts()
        {
            var items = new ObservableCollection<ContactModel>();
            foreach (var contact in contacts)
                items.Add(contact);

            return items;
        }

    }
}
