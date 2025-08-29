

using System.Reflection.Emit;

internal class Program
{
    //enum Signals
    //{
    //    Red, Yellow, Green
    //}

    enum Levels
    { 
    
       Low = 1, Medium = 5, High = 10
    
    }

    private static void Main(string[] args)
    {
        //    Signals redsignal = Signals.Red;
        //    Signals greensignal = Signals.Green;
        //    Signals yellowsignal = Signals.Yellow;


        //Console.WriteLine(redsignal);
        //Console.WriteLine(greensignal);
        //Console.WriteLine(yellowsignal);

        //foreach (Signals signal in Signals.GetValues(typeof(Signals)))
        //{
        //    int intValue = (int)signal;
        //    Console.WriteLine($"{signal} = {intValue}");
        //}

        Console.WriteLine("Enter level (Low, Medium, High): ");
        string? input = Console.ReadLine();


        if (Enum.TryParse(input, true, out Levels level))
        {
            switch (level)
            {
                case Levels.Low:
                    Console.WriteLine("Low level");
                    break;
                case Levels.Medium:
                    Console.WriteLine("Medium level");
                    break;
                case Levels.High:
                    Console.WriteLine("High level");
                    break;
                default:
                    Console.WriteLine("Unknown level");
                    break;
            }

        }
        else {             Console.WriteLine("Invalid input");
        }

        //Console.WriteLine("Hello, World!");
    }
}