using System;
namespace AddresssBook
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to AddressBook");
            AddressBookMain main = new AddressBookMain();

            //main.AddContact();
            main.Display();
            main.EditContact();
            
        }
    }
}

