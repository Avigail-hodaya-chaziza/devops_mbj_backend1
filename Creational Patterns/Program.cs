using System;
using System.Xml.Linq;
using Creational_Patterns;
using Creational_Patterns.Builder;
using Creational_Patterns.Factory;
using Creational_Patterns.Prototype;
using Creational_Patterns.Singelton;
namespace CreationalPatterns
{
    class Program
    {
       static void Main(string[] args)
        {
            ContactsList contactsList = new ContactsList();
            FactoryPhoneContact PhoneContact = new FactoryPhoneContact();
            FactorySimContact SimContact = new FactorySimContact();
            PrototypeRegistry prototypeRegistry = new PrototypeRegistry();
            Director director = new Director();
            Contact contact;
            PrintSingelton printSingelton = PrintSingelton.Printer;


            contactsList.AddContact(SimContact, "Avigail", "111-222-3333", Group.work);
            contactsList.AddContact(PhoneContact, "David", "444-555-6666", Group.general);

            PhoneContact family = (PhoneContact)prototypeRegistry.CreateContact(Group.family);
            family.Name = "Yael";
            family.Phonenumber = "888-999-0000";
            contactsList.AddContact(family);

            SimContact general = (SimContact)prototypeRegistry.CreateContact(Group.general);
            general.Name = "Michal";
            general.Phonenumber = "888-999-0000";
            contactsList.AddContact(general);

            PhoneContact friends = (PhoneContact)prototypeRegistry.CreateContact(Group.friends);
            friends.Name = "Michal";
            friends.Phonenumber = "888-999-0000";
            contactsList.AddContact(friends);


            PhoneContact work = (PhoneContact)prototypeRegistry.CreateContact(Group.work);
            work.Name = "Yaela";
            work.Phonenumber = "888-999-0000";
            work.AddColor("Yellow");
            contactsList.AddContact(work);



            BuilderContact sim = new BuilderSimContact();
            director = new Director(sim);
            director.Basic("Bob", "098-765-4321", Group.friends, "Blue", "ringtone1");

            BuilderContact phone = new BuilderPhonContact();
            director = new Director(phone);
            director.Expanded("Alice", "123-456-7890", Group.family, "Green", "standard", "alice@gmail.com", "01/01/1990");


            BuilderContact Phones = new BuilderPhonContact();
            Phones.Reset("Ayala", "0583284905", Group.friends);
            Phones.AddEmail("Ayala05@gmail.com");
            Phones.AddRingtone("Nokya.mp3");
            Phones.AddColor("Yellow");
            contactsList.AddContact(Phones.GetResult());
            static void PrintFoundContact(Contact contact, string context)
            {
                if (contact != null)
                {
                    PrintSingelton.Printer.PrintContact(context, contact, ConsoleColor.Green);
                }
                else
                {
                    Console.WriteLine($"{context} Contact not found.");
                }
            }
            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("To Search contact by name click 1");
                Console.WriteLine("To Search contact by phone number click 2");
                Console.WriteLine("To Print all contacts click 3");
                var click = Console.ReadLine();
                Contact p;
                switch (click)
                {
                    case "1":
                        Console.WriteLine("Enter name:");
                        string name = Console.ReadLine();
                        p = contactsList.FindContactByName(name);
                        if (p != null)
                        {
                            printSingelton.PrintContact($"the name: {name}", p);
                        }
                        else
                        {
                            System.Console.WriteLine("The name is not defind");
                        }
                        break;

                    case "2":
                        Console.WriteLine("Enter phone number:");
                        string phoneNumber = Console.ReadLine();
                        p = contactsList.FindContactByPhonenumber(phoneNumber);
                        if (p != null)
                        {
                            printSingelton.PrintContact($"the name: {phoneNumber}", p);
                        }
                        else
                        {
                            System.Console.WriteLine("The phone is not defind");
                        }
                        break;

                    case "3":
                        for (int i = 0; i < contactsList.Contacts.Count; i++)
                        {
                            printSingelton.PrintContact($"contact num is : {i}", contactsList.Contacts[i]);
                        }
                        break;


                    default:
                        Console.WriteLine("try again");
                        break;
                }
            }
        }
    }
}
