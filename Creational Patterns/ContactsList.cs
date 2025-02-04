using Creational_Patterns.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Patterns
{
    internal class ContactsList
    {
        public List<Contact> Contacts;
        public ContactsList()
        {
            Contacts = new List<Contact>(); 
        }
        public void AddContact(Contact contact)
        {
            Contacts.Add(contact);
        }
        public void AddContact(FactoryContact factoryContact, string name,  string phonenumber, Group group)
        {
            Contacts.Add(factoryContact.CreateContact(name, phonenumber, group));
       
        }
        public void RemoveContact(Contact contact) 
        {
            Contacts.Remove(contact);
        }

        public Contact FindContactByName(string name)
        {
            return Contacts.FirstOrDefault(n => n.Name == name);
        }
        public Contact FindContactByPhonenumber(string phonenumber)
        {
            return Contacts.FirstOrDefault(n => n.Phonenumber == phonenumber);
        }

        public override string ToString()
        {
            string result = "Contacts List:\n";
            foreach (var contact in Contacts)
            {
                result += contact.ToString() + "\n";
            }
            return result;
        }
    }



}

