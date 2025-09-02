// declare karo delegate; 

public delegate void myFirstDelegate(string message);
public delegate void Notify();

public delegate void MathOperation(int a, int b);
public delegate void GreetUser(string name);


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
}

public class Calculator
{

    public void Add(int a, int b)
    {
        Console.WriteLine($"Addition: {a + b}");
        Console.WriteLine();
    }

    public void Subtract(int a, int b)
    {
        Console.WriteLine($"Subtraction: {a - b}");
        Console.WriteLine();
    }

    public void Multiply(int a, int b)
    {
        Console.WriteLine($"Multiplication: {a * b}");
        Console.WriteLine();
    }

}


class Program
{
    private static void Main(string[] args)
    {

        //myFirstDelegate myFirstDelegate = delegate (string message)
        //{
        //    Console.WriteLine(message);
        //};
        MyClass myClass = new MyClass();

        GreetUser greetUser = myClass.SayHello;
        greetUser+= myClass.SayGoodbye;
        greetUser("Rameez");


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
        //operation(10, 5);














    }


}