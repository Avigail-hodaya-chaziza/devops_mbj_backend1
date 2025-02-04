using Creational_Patterns.Prototype;
using Creational_Patterns.Singelton;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Patterns
{
    internal class SimContact : Contact, IPrototype

    {
        public SimContact(string name, string phonenumber, Group group) : base(name, phonenumber, Group.general)
        {
            AddColor("");
        }
        public override void AddColor(string color)
        {
            Properties["Color"] = "Gray";
        }
        public IPrototype Clone()

        {
            SimContact simContact = new SimContact(this.Name,  this.Phonenumber, this.Group);
            return simContact;


        }


    }
}