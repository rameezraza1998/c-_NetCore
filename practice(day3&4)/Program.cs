using System.Xml.Linq;

internal class Program
{

    // Implicit Casting: means changing small value type to larger value type size.
    static int myAge = 20;
    static double myAgeInDouble = myAge;

    // Explicit Casting: means changing larger value type to smaller value type size. it is done manually.
    static double pi = 3.142;
    static int piInInt = (int)pi;


    // conversion using type conversion methods.
    static int myInt = 10;
    static double myDouble = 5.25;
    static bool myBool = false;



    // Airthmetic Operators: +, -, *, /, %
    static int a = 10;
    static int b = 5;




    private static void Main(string[] args)
    {

        Console.WriteLine(myAge);
        Console.WriteLine(myAgeInDouble);
        // Explicit Casting: means changing larger value type to smaller value type size.
        Console.WriteLine(pi);
        Console.WriteLine(piInInt);
        // convesion using type conversion methods
        Console.WriteLine(myInt);
        Console.WriteLine(myDouble);
        Console.WriteLine(myBool);
        Console.WriteLine(Convert.ToString(myInt));
        Console.WriteLine(Convert.ToInt32(myDouble));
        Console.WriteLine(Convert.ToDouble(myBool));

        var resultSum = sum(a, b);
        Console.WriteLine($"The sum of {a} and {b} is: {resultSum}");
        static int sum(int x, int y)
        {
            return x + y;
        }
        var resultSub = subtract(a, b);
        Console.WriteLine($"The subtraction of {a} & {b} is: {resultSub}");
        static int subtract(int x, int y)
        {
            return x - y;
        }

        var resultMul = multiplication(a, b);
        Console.WriteLine($"The multiplication of {a} & {b} is: {resultMul}");

        static int multiplication(int x, int y)
        {
            return x * y;
        }

        var resultDiv = divison(a, b);
        Console.WriteLine($"the division of {a},{b} is: {resultDiv}");


         static int divison(int x, int y)
        {
            if(x > 0 || y> 0)
            {
                return x / y;
                
            }

            Console.WriteLine("Divison is invalid");
            return 0;
        }

        var resultMod = modulus(a, b);
        Console.WriteLine($"The modulus of {a} & {b} is: {resultMod}");

        static int modulus(int x, int y)
        {
            return x % y;
        }


        // ❓ Null-Coalescing Operator (??) in this when the value isn't given, it will return the default value.
        string myName=null;

        string displayName = myName ?? "Guest";

        Console.WriteLine($"Hello, {displayName}!");
    }
}