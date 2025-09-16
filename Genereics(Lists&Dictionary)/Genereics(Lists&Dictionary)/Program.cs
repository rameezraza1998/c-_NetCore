using System.Runtime.InteropServices;

class ListExample
{

   
    public void CreatList()
    {
        List<int> numbers = new List<int>();

        numbers.Add(1);
        numbers.Add(2);
        numbers.Add(3);
        numbers.Add(4);
        numbers.Add(5);
        numbers.Add(6);
        numbers.Add(7);
       
        PrintList(numbers);
        CheckList(numbers);

        Console.WriteLine("List created and printed.");
        //Console.WriteLine("The length of List size is: "+numbers.Count);

        numbers.Remove(2);
        PrintList(numbers);
        CheckList(numbers);
    }
    public void PrintList(List<int> numbers)
    {

        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
        Console.WriteLine("The length of List size is: " + numbers.Count);
    }

    public void CheckList(List<int> numbers)
    { 
        if(numbers.Contains(2))
        {
            Console.WriteLine("Item found in the list.");
        }
        else
        {
            Console.WriteLine("Item not found in the list.");
        }
    }
}

class LibrarySystem
{   

    List<string> books = new List<string>();

    public void AddBook(string bookname)
    { 
            
        string book = bookname; 
        books.Add(book);

    }
    public void ShowBooks()
    {   
        Console.WriteLine("Books in the library:");
        foreach (var book in books)
        {
            Console.WriteLine($"*{book}");
        }
    }
    public void RemoveBook(string bookname)
    { 
        if(books.Count > 0 && books.Contains(bookname))
        {
            books.Remove(bookname);
            Console.WriteLine($"Book {bookname} removed from the library.");
            Console.WriteLine("Updated list of books:");
            ShowBooks();
        }
        else
        {
            Console.WriteLine($"Book {bookname} not found in the library.");
        }
    }


}

class Program
{

    private static void Main(string[] args)
    {

        //Practice for Lists and Dictionary in C#

        //ListExample listExample = new ListExample();
        //listExample.CreatList();

        LibrarySystem librarySystem = new LibrarySystem();
        librarySystem.AddBook("The Great Gatsby");
        librarySystem.AddBook("To Kill a Mockingbird");
        librarySystem.ShowBooks();
        librarySystem.RemoveBook("The Great Gatsby");









        // END practice for Lists and Dictionary in C#

        //List<string> names = new List<string>();
        //names.Add("Ali");
        //names.Add("Ramis");
        //names.Add("Rameez");

        //Console.WriteLine(names.Count);
        //Console.WriteLine(names[0]);


        //foreach (var name in names)
        //{
        //    Console.WriteLine(name);
        //}
        // Task 1 create list of present students and print them with sorting unique names and when type done is typed make it done


        // List<string> presentStudents = new List<string>();

        //Console.WriteLine("Enter the names of present students (type 'done' to finish):");
        //string input = Console.ReadLine();
        //string task = "done";


        //    while (input != task)
        //    {
        //      presentStudents.Add(input);
        //      input = Console.ReadLine();
        //    }


        //foreach (var student in presentStudents.Distinct().OrderBy(name => name))
        //{
        //    Console.WriteLine(student);

        //}


        //Dictionary<string, string> capitals = new Dictionary<string, string>();
        //capitals.Add("Pakistan", "Islamabad");
        //capitals.Add("India", "New Delhi");
        //capitals.Add("USA", "Washington DC");
        //// Console.WriteLine(capitals["India"]);
        //foreach (var item in capitals)
        //{
        //    Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
        //}


        //Syntax
        // Dictionary<TKey, TValue>



        // Dictionary example

        //Dictionary<string, int> Studentage = new Dictionary<string, int>();

        //Studentage.Add("Rameez Raza", 26);
        //Studentage.Add("Ali Raza", 24);

        //int age = Studentage["Rameez Raza"];
        //Console.WriteLine(age);

        //Dictionary<int, string > Studentage = new Dictionary<int, string >();

        //Studentage.Add(26, "Rameez Raza");
        //Studentage.Add(24, "Ali Raza");

        // // // // // // // //Studentage.Add(24, "Ali"); key must be unique

        //string Name = Studentage[26];
        //string Name1 = Studentage[24];
        //Console.WriteLine(Name);
        //Console.WriteLine(Name1);



        // Simple task for dictionary where add 5 user as contact and ask the user to search through name in it if not found show not found

        //var contacts = new Dictionary<string, string>();

        //Console.WriteLine("Add 5 contacts (name and phone number):");

        //contacts["Rameez"] = "123-456-7890";
        //contacts["Ali"] = "234-567-8901";
        //contacts["Ahmed"] = "345-678-9012";
        //contacts["Sara"] = "456-789-0123";
        //contacts["Zara"] = "567-890-1234";

        //Console.WriteLine("Enter a name to search for a contact (or type 'exit' to quit):");
        //string? input = Console.ReadLine();



        //while (input != "exit")
        //{ 
        //    if(!string.IsNullOrEmpty(input) && contacts.ContainsKey(input))
        //    {
        //        Console.WriteLine($"Contact is found {input} => {contacts[input]}");
        //        break;
        //    }
        //    else 
        //    {                
        //        Console.WriteLine("Contact not found.");
        //        break;
        //    }     
        //}
        //Console.WriteLine("ThankYou come again to search");



    }
}