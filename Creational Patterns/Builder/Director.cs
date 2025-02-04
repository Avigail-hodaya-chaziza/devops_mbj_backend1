using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Patterns.Builder
{
    internal class Director
    {
        BuilderContact builder;

        public Director()
        {
            
        }

        public Director(BuilderContact _builder)
        {
            builder=_builder;   
        }
        public void Basic (string name, string phonenumber, Group group , string Color, string ringtone)
        {
            builder.Reset(name, phonenumber, group);
            builder.AddRingtone(ringtone);  
            builder.AddColor(Color);
            builder.GetResult();
            
        }
        public void Expanded(string name, string phonenumber, Group group, string Color, string ringtone, string  email, string birthday)
        {
            builder.Reset(name, phonenumber, group);
            builder.AddRingtone(ringtone);
            builder.AddColor(Color);
            builder.AddEmail(email);
            builder.AddBirthday(birthday);
            builder.AddEmail(email);
            builder.AddBirthday(birthday);
            builder.GetResult();
        }

    }
}
