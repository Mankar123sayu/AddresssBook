using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddresssBook
{
    public class AddressBookMain
    {
        Contact contact = new Contact();
        List<Contact> main = new List<Contact>();

        public void AddContact()
        {
            Console.Write("Enter the first name: ");
            contact.FirstName = Console.ReadLine();

            Console.Write("Enter the last name: ");
            contact.LastName = Console.ReadLine();

            Console.Write("Enter the address: ");
            contact.Address = Console.ReadLine();

            Console.Write("Enter the city: ");
            contact.City = Console.ReadLine();

            Console.Write("Enter the state: ");
            contact.State = Console.ReadLine();

            Console.Write("Enter the Zip: ");
            contact.Zip = Console.ReadLine();

            Console.Write("Enter the phone number: ");
            contact.PhoneNumber = Console.ReadLine();

            Console.Write("Enter the email: ");
            contact.email = Console.ReadLine();

            main.Add(contact);
        }
    }
}
