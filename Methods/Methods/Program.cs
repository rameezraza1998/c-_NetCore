internal class Program
{   


    static int add(int a ,int b)
    {
        return a + b;
    }

    public string GetName()
    {
        return "Rameez" ;
    }

    // another method without return type

    private void Hello()
    {
        Console.WriteLine("Hello from another method");
    }

    private static void Main(string[] args)
    {
       

        int result = add(6,6);
        Console.WriteLine($"the sum of addition is: {result}");

        Program p = new Program();

        p.Hello();
       Console.WriteLine(p.GetName());
    }
}