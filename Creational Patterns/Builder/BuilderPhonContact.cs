using Creational_Patterns.Singelton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Patterns.Builder
{
    internal class BuilderPhonContact : BuilderContact
    {

        PhoneContact Phonecontact;

        public void Reset(string name, string phonenumber, Group group)
        {
 
            Phonecontact = new PhoneContact(name, phonenumber, group);
            
        }
        public void AddEmail(string email)
        {
            Phonecontact.AddEmail(email);
        }
        public void AddRingtone(string ringtone)
        {
            Phonecontact.AddRingtone(ringtone);
        }
        public void AddBirthday(string birthday)
        {
            Phonecontact.AddBirthday(birthday);
        }
        public void AddColor(string Color)
        {
            Phonecontact.AddColor(Color);
        }
        public Contact GetResult()
        {
            PrintSingelton.Printer.PrintContact("Created in Phon Builder", Phonecontact);
            return Phonecontact;

        }
    }
}

