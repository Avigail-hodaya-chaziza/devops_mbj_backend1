using Creational_Patterns.Singelton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Patterns.Builder
{
    internal class BuilderSimContact : BuilderContact
    {
        SimContact Simcontact;
        public void Reset(string name, string phonenumber, Group group)
        {
            Simcontact = new SimContact(name, phonenumber, group);
           
        }
        public void AddEmail(string email)
        {
            Simcontact.AddEmail(email);
        }
        public void AddRingtone(string ringtone)
        {
            Simcontact.AddRingtone(ringtone);
        }
        public void AddBirthday(string birthday)
        {
            Simcontact.AddBirthday(birthday);
        }
        public void AddColor(string Color)
        {
            Simcontact.AddColor(Color);
        }
        public Contact GetResult()
        {
            PrintSingelton.Printer.PrintContact("Created in Sim Builder", Simcontact);
            return Simcontact;

        }
    }
}
