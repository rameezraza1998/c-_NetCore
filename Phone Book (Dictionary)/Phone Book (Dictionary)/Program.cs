class PhoneBookApp
{
    Dictionary<long, string> contacts = new Dictionary<long, string>();

    /*
        
    
     
     */

    public void AddContacts(string name, long numbers)
    {
        // Implementation for adding contacts
        string customerName = name;
        long customerNumber = numbers;

        contacts.Add(customerNumber, customerName);
    }

    public void DisplayContacts()
    {
        Console.WriteLine("Contacts List:");
        foreach (var contact in contacts)
        {
            Console.WriteLine($"Contact-Number: {contact.Key} => Name: {contact.Value}  ");
        }
    }

    public void SearchContactNumber(long number)
    { 
            if (contacts.ContainsKey(number))
            {
                Console.WriteLine($"Contact Found: {contacts[number]}");
            }
            else
            {
                Console.WriteLine("Contact Not Found");
            }
    }
}
class Program
{
    private static void Main(string[] args)
    {   
        PhoneBookApp phoneBook = new PhoneBookApp();

      

        bool isRunning = true;
        while (isRunning)
        { 
            
        }
            int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("Enter Name:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Number:");
                long number = Convert.ToInt64(Console.ReadLine());
                phoneBook.AddContacts(name, number);
                break;
            case 2:
                phoneBook.DisplayContacts();
                break;
            case 3:
                Console.WriteLine("Enter Number to Search:");
                long searchNumber = Convert.ToInt64(Console.ReadLine());
                phoneBook.SearchContactNumber(searchNumber);
                break;
            case 4:
                Console.WriteLine("Exiting the application. Goodbye!");
                isRunning = false;
                break;

            default:
                break;
        }
 

        // Dummy entries
        //phoneBook.AddContacts("Rameez", 1234567890);
        //phoneBook.AddContacts("Raza", 9876543210);
        //phoneBook.AddContacts("Ali", 5555555555);
        //phoneBook.AddContacts("Hina", 1112223333);
        //phoneBook.AddContacts("Sara", 4445556666);
        //phoneBook.AddContacts("Usman", 7778889999);
        //phoneBook.AddContacts("Bilal", 1010101010);

        // 🔥 10 more dummy contacts
        //phoneBook.AddContacts("Ahsan", 2020202020);
        //phoneBook.AddContacts("Nida", 3030303030);
        //phoneBook.AddContacts("Khalid", 4040404040);
        //phoneBook.AddContacts("Fatima", 5050505050);
        //phoneBook.AddContacts("Hamza", 6060606060);
        //phoneBook.AddContacts("Tariq", 7070707070);
        //phoneBook.AddContacts("Sana", 8080808080);
        //phoneBook.AddContacts("Omer", 9090909090);
        //phoneBook.AddContacts("Laiba", 1212121212);
        //phoneBook.AddContacts("Imran", 1313131313);

        //phoneBook.DisplayContacts();



            /*  Console.WriteLine("hey");*/
    }
}