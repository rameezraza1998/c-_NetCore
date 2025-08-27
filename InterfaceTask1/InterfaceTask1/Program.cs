
interface CheckValueAtIndex
{

    int[] MyNum { get; set; }



}

class CheckValue : CheckValueAtIndex
{
    public int[] MyNum { get; set; }

    public CheckValue(int mynum)
    {        
        MyNum = new int[] { 1, 2, 3, 4, 5 };
    }
}

class Program
{
    private static void Main(string[] args)
    {   
        int indeval = Console.Read();
        CheckValue obj = new CheckValue(indeval);
        Console.WriteLine($"Value is: {obj.MyNum[1]}");
        //Console.WriteLine("Hello, World!");
    }
}