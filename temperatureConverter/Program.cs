internal class Program
{
    static double celcius = 37.0;
    static double fahrenheit; 
    private static void Main(string[] args)
    {
        celcius = 47.2;
        fahrenheit = (celcius * 9 / 5) + 32;
        Console.WriteLine("Given temperature was in Celcius: "+celcius);
        Console.WriteLine("Converted temperature in Fahrenheit: " + fahrenheit);
        celcius = (fahrenheit - 32) * 5 / 9;
        Console.WriteLine("Now converting back Fahrenheit to Celcius: "+celcius );
    }
}