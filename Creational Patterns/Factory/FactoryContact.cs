using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Patterns.Factory
{
    internal class FactoryContact
    {
       public virtual Contact CreateContact(string name, string phonenumber, Group group)
        {
            return null;
        }
    }
}
