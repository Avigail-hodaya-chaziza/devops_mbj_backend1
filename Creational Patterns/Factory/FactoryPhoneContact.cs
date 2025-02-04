using Creational_Patterns.Singelton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Patterns.Factory
{
    internal class FactoryPhoneContact:FactoryContact
    {
        public override Contact CreateContact(string name, string phonenumber, Group group)
        {
            PhoneContact phoneContact = new PhoneContact(name, phonenumber, group); 
            PrintSingelton.Printer.PrintContact("factory phone in contact", phoneContact);
            return phoneContact;
        }
    }
}
