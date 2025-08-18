internal class Program
{

   // static variables jab banata hai jab huma values fixed rkhni hoti ha aur sharabale ho sab ma
   static int myNum = 27;
   static string myName = "Rameez";
   static bool myBool = true;
   static double temp = 36.6;


    private static void Main(string[] args)
    {
        Console.WriteLine(myNum);
        Console.WriteLine(myName);
        if (myBool)
        {
            Console.WriteLine("hello if");
        }
        Console.WriteLine(temp);
    }
}