using Creational_Patterns.Prototype;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Patterns
{
     abstract class Contact
    {
       public string Name { get; set; }
       public string Phonenumber { get; set; }
       public Group group { get; set; }
       public Dictionary<string, string> Properties { get; private set; } = new Dictionary<string, string>();

        public void AddEmail(string email)
        {
            Properties["Email1"] = email;
        }
        public void AddBirthday(string birthday)
        {
            Properties["Birthday"] = birthday;
        }
        public void AddRingtone(string ringtone)
        {
            Properties["Ringtone"] = ringtone;
        }
        public virtual void AddColor(string Color)
        {
            Properties["Color"] = Color;
        }
        public void AddGroup(Group group)
        {
          this.group = group;
        }


        public Group Group { get; set; }    
        public Contact(string name, string phonenumber, Group group)
        {
            Name = name;
            Phonenumber = phonenumber;
            Group = group;
        }

        public override string ToString() 
        {
            string s = $"{"Name",-15}: {Name,-15} \n";
            s += $"{"Phone Number",-15}: {Phonenumber,-15} \n";
            s+= $"{"Group",-15}: {Group,-15} \n";
            foreach (var item in Properties)
            {
                s += $"{item.Key,-15}: {item.Value,-15}\n";
            }
            return s;
        }

    }
}
