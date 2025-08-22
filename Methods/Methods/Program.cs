internal class Program
{
    //method with return type and parameters

    public int add(int a, int b)
    {
        return a + b;
    }
    //method with return type and without parameters
    public string GetName()
    {
        return "Rameez";
    }

    //  method without return type and without parameters

    private void Hello()
    {
        Console.WriteLine("Hello from another method");
    }

    // Method with parameters 

    public void person(string pname)
    {
        Console.WriteLine($"Hello, sir {pname}");
    }


    public void detail(string pname, int age)
    {
        Console.WriteLine($"Hello, sir {pname} your age is {age}");
    }


    // Method with named Arguments


    public void family(string dad, string child1) {


        Console.WriteLine($"hello youngest child {child1} ");
        Console.WriteLine($"hello father {dad} ");
    }

    private static void Main(string[] args)
    {

        Program p = new Program();
        int result = p.add(6,6);
        Console.WriteLine($"the sum of addition is: {result}");


        p.family(child1: "Rameez", dad: "Qasim");


        p.Hello();
        p.Hello();
        Console.WriteLine(p.GetName());

        p.person("Rameez");
        p.person("Qasim");

        p.detail("Ramis", 26);
    }
}

// methods are used to perform certain actions, they are also known as functions

//Every method is a function, but not every function is a method.

//Methods are just functions that "live inside" objects.