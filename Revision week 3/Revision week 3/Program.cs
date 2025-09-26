//public static class MathHelper
//{
//    public static int count = 0;
//    public static double Square(double x)
//    {
//        return x * x ;
//    }
 
//}

//public class Counter
//{

//    public static int count = 0;

//    public Counter()
//    {
//        count++;
//    }
//}


public partial class Fullname
{
    public  string FirstName;

    public  string LastName;

    public Fullname(string name, string name2)
    {
        FirstName = name;
        LastName = name2;

    }


}

public partial class Fullname
{

    public void FullName()
    {
        Console.WriteLine($"{FirstName} {LastName}");
    }
}



internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        //double square = MathHelper.Square(2);
        ////Console.WriteLine(square);

        //Counter c1 = new Counter();
        //Counter c2 = new Counter();
        //Counter c3 = new Counter();
        //Console.WriteLine(Counter.count);

        //Fullname f=new Fullname("Rameez","Raza");

        var name = new Fullname("Rameez", "Raza");
        name.FullName();
        

    }
}