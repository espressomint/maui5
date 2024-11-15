using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplikacjatress
{
    public class ContactList
    {
        public static ObservableCollection<Contact> Contacts = new ObservableCollection<Contact>();

        public static IEnumerable<Contact> GetContactsOlderThan(int age)
        {
            return Contacts.Where(contact => contact.Age > age);
        }
    }
}

