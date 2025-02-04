using Creational_Patterns.Prototype;
using Creational_Patterns.Singelton;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Patterns
{
    internal class PhoneContact : Contact, IPrototype
    {
        public PhoneContact(string name, string phonenumber ,Group group):
            base(name, phonenumber, group)
        {

        }

        public IPrototype Clone()

        {
            PhoneContact phoneContact = new PhoneContact(this.Phonenumber, this.Phonenumber, this.Group);
            return (phoneContact);

        }

    }
}



