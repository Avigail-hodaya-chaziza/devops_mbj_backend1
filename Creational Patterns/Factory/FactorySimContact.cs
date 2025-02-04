using Creational_Patterns.Singelton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Patterns.Factory
{
    internal class FactorySimContact : FactoryContact
    {
        public override Contact CreateContact(string name, string phonenumber, Group group)
        {
              SimContact contact= new SimContact(name, phonenumber, group);
            PrintSingelton.Printer.PrintContact("factory sim in contact", contact );
            return contact;
        }
    }
}
