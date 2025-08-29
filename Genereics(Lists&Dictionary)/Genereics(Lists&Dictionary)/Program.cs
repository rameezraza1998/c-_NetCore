class Program
{

    private static void Main(string[] args)
    {

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



        // Dictionary example

        Dictionary<string, int> Studentage = new Dictionary<string, int>();

        Studentage.Add("Rameez Raza", 26);
        Studentage.Add("Ali Raza", 24);

        int age = Studentage["Rameez Raza"];
        Console.WriteLine(age);




    }
}