using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Patterns.Builder
{
    internal interface BuilderContact
    {
        public void Reset(string name, string phonenumber, Group group);
        public void AddEmail(string email);
        public void AddRingtone(string ringtone);
        public void AddBirthday(string birthday);
        public void AddColor(string Color);
        public Contact GetResult();

    }
}
