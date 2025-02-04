using Creational_Patterns.Singelton;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Patterns.Prototype
{
    internal class PrototypeRegistry
    {
        private Dictionary<Group, Contact> registry = new Dictionary<Group, Contact>();
        public PrototypeRegistry()
        {

            PhoneContact family = new PhoneContact(string.Empty, string.Empty, Group.family);
            family.AddEmail(string.Empty);
            family.AddColor("Green");
            registry.Add(Group.family, family);

            SimContact general = new SimContact(string.Empty, string.Empty, Group.general);
            general.AddEmail(string.Empty);
            general.AddBirthday(string.Empty);
            general.AddRingtone("Ringtone");
            general.AddColor("Red");
            registry.Add(Group.general, general);

            PhoneContact friends = new PhoneContact(string.Empty, string.Empty, Group.friends);
            friends.AddColor("Yellow");
            friends.AddRingtone("Ringtone");
            registry.Add(Group.friends, friends);

            PhoneContact work = new PhoneContact(string.Empty, string.Empty, Group.work);
            work.AddColor("Blue");
            registry.Add(Group.work, work);

        }
        public IPrototype CreateContact(Group group)
        {

            if (registry.TryGetValue(group, out Contact contactPrototype))
            {
                PrintSingelton.Printer.PrintContact("created in registery", contactPrototype);
                return (IPrototype)contactPrototype;
            }
            return null;

        }
    }
}



