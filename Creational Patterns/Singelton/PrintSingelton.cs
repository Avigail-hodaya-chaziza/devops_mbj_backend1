using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Patterns.Singelton
{
    internal class PrintSingelton
    {
        private static PrintSingelton _printer;

        private PrintSingelton() { }

        public static PrintSingelton Printer
        {
            get
            {
                if (_printer == null)
                {
                    _printer = new PrintSingelton();
                }
                return _printer;
            }
        }

        public void PrintContact(string text, Contact contact, ConsoleColor? textColor = null)
        {

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(text);
            Console.WriteLine(new string('-', 50));
            if (contact != null)
            {
                if (contact.Properties.ContainsKey("Color"))
                {
                    string colors = contact.Properties["Color"];
                    if (Enum.TryParse(colors, true, out ConsoleColor Color))
                    {
                        Console.ForegroundColor = Color;
                    }

                }

                Console.WriteLine(contact.ToString());
                Console.WriteLine(new string('-', 50));
            }
            Console.ResetColor();
        }
    }
}

