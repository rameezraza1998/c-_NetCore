internal class Program
{


    private static void Main(string[] args)
    {
        int[] data  = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        var greaterThanThree = data.Where(n => n > 3).OrderByDescending(n => n);
        Console.WriteLine(greaterThanThree);


        foreach (var number in greaterThanThree)
        {
            Console.WriteLine(number);
        }

        //Console.WriteLine("Hello LINQ !! ");
    }
}