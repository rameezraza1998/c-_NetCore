
// Record types in C# are immutable by default, meaning that their properties cannot be changed after the record is created.
// Syntax for records:
// public record Person(string FirstName, string LastName);


    // Tuples 


internal class Program
{
    public record Person(string FirstName, string LastName);


    // immutability example
    // in immutable records, properties are init-only by default

    public record Book()
    { 
        public string Title { get; init; } = string.Empty;
        public string Author { get; init; } = string.Empty;
    }

    (string, int) GetInfo()
    {
        return ("Rameez", 30);
    }


    private static void Main(string[] args)
    {

        Program p = new Program();
        var tuples = (1, "Hello", true);
        var (integerVal, stringVal, boolVal) = tuples; // Deconstruction
        //Console.WriteLine($"Item1: {tuples.Item1}, Item2: {tuples.Item2}, Item3: {tuples.Item3}");

        var result = p.GetInfo();
        Console.WriteLine($"Name: {result.Item1}, Age: {result.Item2}");


        //var person1 = new Person("Rameez", "Raza");
        //Console.WriteLine(person1);

        //var person2 = person1 with { LastName = "Rizvi" }; // 'with' expression to create a new record with modified properties
        //Console.WriteLine(person2);

        Console.WriteLine();

        //var book1 = new Book { Title = "C# in Depth", Author = "Jon Skeet" };
        //Console.WriteLine($"Book 1: {book1.Title} by {book1.Author}");
        //var book2 = book1 with { Title = "Effective C#" }; // Using 'with' expression to create a new record with modified properties
        //Console.WriteLine($"Book 2: {book2.Title} by {book2.Author}");



        (double X, double Y) Cordinate1 = (3.5, 7.2);
        var Cordinate2 = (X: 4.5, Y: 8.2);

        PrintCoordinate(Cordinate1);
        PrintCoordinate(Cordinate2);

        static void PrintCoordinate((double X, double Y) point)
        {
            Console.WriteLine($"X: {point.X}, Y: {point.Y}");
        }



    }
}