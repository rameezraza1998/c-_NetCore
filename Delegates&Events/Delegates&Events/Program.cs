// declare karo delegate; 

public delegate void myFirstDelegate(string message);
public delegate void Notify();

public delegate void MathOperation(int a, int b);
public delegate void GreetUser(string name);


public delegate void Logger(string message);

public class MyClass
{
    public void DisplayMessage(string message)
    {
        Console.WriteLine($"Message: {message}");
    }

    public void ShowMessage()
    {
        Console.WriteLine("Show Message Method called");
    }
    public void ShowWarning()
    { 
        Console.WriteLine("Show Warning Method called");
    }

    public void SayHello(string name)
    {
        Console.WriteLine($"Hello {name}!");
    }
    public void SayGoodbye(string name)
    {
        Console.WriteLine($"GoodBye {name}!");
    }

    public void LogToConsole(string message)
    {
        Console.WriteLine($"Log to Console: {message}");
    }

    public void LogToFile(string message)
    {
        Console.WriteLine($"Log to File method called {message}");
    }

}

public class Calculator
{

    //public void Add(int a, int b)
    //{
    //    Console.WriteLine($"Addition: {a + b}");
    //    Console.WriteLine();
    //}

    //public void Subtract(int a, int b)
    //{
    //    Console.WriteLine($"Subtraction: {a - b}");
    //    Console.WriteLine();
    //}

    //public void Multiply(int a, int b)
    //{
    //    Console.WriteLine($"Multiplication: {a * b}");
    //    Console.WriteLine();
    //}

    //public MathOperation  Op = delegate (int a, int b)
    //{
    //   Console.WriteLine($"Division: {a / b}");
    //    Console.WriteLine();
    //};

}


class Program
{

    public static List<int> FilterList(List<int> numbers, Predicate<int> filter)
    {

        List<int> result = new List<int>();

        //Console.WriteLine(filter);

        foreach (var number in numbers)
        {
            if (filter(number))
            {
               
                result.Add(number);
            }
        }

        return result;  
    }



    private static void Main(string[] args)
    {

        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

        //foreach (var number in numbers) 
        //{
        //    Console.WriteLine(number);
        //}

        List<int> even = FilterList(numbers,num => num % 2 == 0);

        Console.WriteLine($"Even Numbers: {string.Join(", ", even)}");


        List<int> odd = FilterList(numbers, num => num % 2 != 0);

        Console.WriteLine($"Even Numbers: {string.Join(", ", odd)}");

        //myFirstDelegate myFirstDelegate = delegate (string message)
        //{
        //    Console.WriteLine(message);
        //};
        //MyClass myClass = new MyClass();

        //GreetUser greetUser = myClass.SayHello;
        //greetUser+= myClass.SayGoodbye;
        //greetUser("Rameez");


        //Logger logger = myClass.LogToConsole;
        //logger += myClass.LogToFile;
        //logger("Dont know about hacker");

        //myFirstDelegate firstDelegate = myClass.DisplayMessage;
        //firstDelegate("Hello from the other side");


        //Notify showmsg = myClass.ShowMessage;
        //showmsg();

        //Notify warning = myClass.ShowWarning;
        //warning();

        //notify warning = myClass.ShowWarning;
        //Console.WriteLine("Hello, World!");

        //Calculator calculator = new Calculator();

        //MathOperation operation = calculator.Add;
        //operation += calculator.Subtract;
        //operation += calculator.Multiply;
        //MathOperation operation = calculator.Op;
        //operation(10, 2);


        //always void return nai karta action

        //Action<int, int> add = (a, b) =>
        //{
        //    Console.WriteLine($"Addition: {a + b}");
        //};

        //add(10, 20);

        //Action<int, int> subtract = (a, b) =>
        //{
        //    Console.WriteLine($"Subtraction: {a - b}");
        //};
        //subtract(10, 5);

        //Action<int, int> mul = (a,b) =>
        //{
        //    Console.WriteLine($"Multiplivation: {a*b}");
        //};
        //mul(2, 3);

        //Action<int> cube = (a) =>
        //{

        //    Console.WriteLine($"the cube of {a}: {a*a*a}");
        //};
        //cube(3);


        // must have return type func

        //Func<int, int,int > add = (a, b) => a + b;

        //int result = add(10, 10);
        //Console.WriteLine($"Addition: {result}");

        //Func<int, int, int> subtract = (a, b) => a - b;

        //Console.WriteLine($"Subtraction: {subtract(20, 10)}");


        //Func<int, int, int> Product = (a, b) => a * b;

        //Console.WriteLine($"Product: {Product(10, 10)}");








    }


}