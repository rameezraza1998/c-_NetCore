using System;
using System.Collections.Generic;

class PhoneBookApp
{
    private Dictionary<long, string> contacts = new Dictionary<long, string>();

    // Add a new contact
    public void AddContact(string name, long number)
    {
        if (!contacts.ContainsKey(number))
        {
            contacts.Add(number, name);
            Console.WriteLine($"\n Contact Added: {name} ({number})\n");
        }
        else
        {
            Console.WriteLine("\n This number already exists in contacts!\n");
        }
    }

    // Display all contacts
    public void DisplayContacts()
    {
        Console.WriteLine("\n Contacts List:");
        Console.WriteLine("=======================");
        if (contacts.Count == 0)
        {
            Console.WriteLine("No contacts available.\n");
            return;
        }

        foreach (var contact in contacts)
        {
            Console.WriteLine($" {contact.Key} → {contact.Value}");
        }
        Console.WriteLine("=======================\n");
    }

    // Search contact by number
    public void SearchContact(long number)
    {
        Console.WriteLine();
        if (contacts.ContainsKey(number))
        {
            Console.WriteLine($" Contact Found: {contacts[number]} ({number})\n");
        }
        else
        {
            Console.WriteLine(" Contact Not Found.\n");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        PhoneBookApp phoneBook = new PhoneBookApp();
        bool isRunning = true;

        Console.WriteLine("======================================");
        Console.WriteLine("Welcome to the Phone Book Application!");
        Console.WriteLine("======================================");

        while (isRunning)
        {
            Console.WriteLine("\n========= MENU =========");
            Console.WriteLine("1. Add Contact");
            Console.WriteLine("2. Display Contacts");
            Console.WriteLine("3. Search Contact by Number");
            Console.WriteLine("4. Exit");
            Console.WriteLine("========================");
            Console.Write("Enter your choice: ");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("\n Invalid input! Please enter a number (1-4).\n");
                continue;
            }

            switch (choice)
            {
                case 1:
                    Console.Write("\nEnter Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Enter Number: ");
                    long number;
                    if (long.TryParse(Console.ReadLine(), out number))
                    {
                        phoneBook.AddContact(name, number);
                    }
                    else
                    {
                        Console.WriteLine("\n Invalid number format!\n");
                    }
                    break;

                case 2:
                    Console.Clear();
                    phoneBook.DisplayContacts();
                    break;

                case 3:
                    Console.Write("\nEnter Number to Search: ");
                    long searchNumber;
                    if (long.TryParse(Console.ReadLine(), out searchNumber))
                    {
                        phoneBook.SearchContact(searchNumber);
                    }
                    else
                    {
                        Console.WriteLine("\n Invalid number format!\n");
                    }
                    break;

                case 4:
                    Console.WriteLine("\n Exiting the application. Goodbye!");
                    isRunning = false;
                    
                    break;

                default:
                    Console.WriteLine("\n Invalid choice. Please try again.\n");
                    break;
            }
        }
    }
}
