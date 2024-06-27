using System;
using System.Collections.Generic;

class phoneBook
{
    static void Main()
    {
        Dictionary<string, string> phoneBook = new Dictionary<string, string>();
        int choice;
        
        do
        {
            Console.WriteLine("\nPhonebook Menu:");
            Console.WriteLine("1. Add Contact");
            Console.WriteLine("2. Search Contact");
            Console.WriteLine("3. Display All Contacts");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddContact(phoneBook);
                    break;
                case 2:
                    SearchContact(phoneBook);
                    break;
                case 3:
                    DisplayContacts(phoneBook);
                    break;
                case 4:
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        } while (choice != 4);
    }

    static void AddContact(Dictionary<string, string> phoneBook)
    {
        Console.Write("Enter name: ");
        string name = Console.ReadLine();
        Console.Write("Enter phone number: ");
        string phoneNumber = Console.ReadLine();

        if (phoneBook.ContainsKey(name))
        {
            Console.WriteLine("Contact already exists. Updating phone number.");
            phoneBook[name] = phoneNumber;
        }
        else
        {
            phoneBook.Add(name, phoneNumber);
        }
        
        Console.WriteLine("Contact added/updated successfully.");
    }

    static void SearchContact(Dictionary<string, string> phoneBook)
    {
        Console.Write("Enter name to search: ");
        string name = Console.ReadLine();
        string phoneNumber;

        if (phoneBook.TryGetValue(name , out  phoneNumber))
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Phone Number: " + phoneNumber);
        }
        else
        {
            Console.WriteLine("Contact not found.");
        }
    }

    static void DisplayContacts(Dictionary<string, string> phoneBook)
    {
        Console.WriteLine("\nPhonebook Contacts:");
        foreach (var contact in phoneBook)
        {
            Console.WriteLine("Name: " + contact.Key + ", Phone Number: " + contact.Value);
        }
    }
}
