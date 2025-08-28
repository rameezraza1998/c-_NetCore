
interface CheckValueAtIndex
{

    int[] MyNum { get; set; }



}

class CheckValue : CheckValueAtIndex
{
    public int[] MyNum { get; set; }

    //public CheckValue(int mynum)
    //{        
    //    MyNum = new int[] { 1, 2, 3, 4, 5 };
    //}

    public CheckValue(int[] myNum)
    {
        MyNum = myNum;
    }

}

class Program
{
    private static void Main(string[] args)
    {   
        int [] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

        CheckValue obj = new CheckValue(arr);
        Console.Write("Type index no to get value the value:");
        string? input = Console.ReadLine();

        if (input == null)
        {
            Console.WriteLine("Input cannot be null.");
            return; 
        }
        bool isValidNumber = int.TryParse(input, out int indexVal);
        if (!isValidNumber || indexVal < 0 || indexVal >= obj.MyNum.Length)
        {
            Console.WriteLine("Invalid index!");
        }
        else
        {
            Console.WriteLine($"Value is at index number {indexVal}: {obj.MyNum[indexVal]}");
        }

        //int indeval = Console.Read();
        //CheckValue obj = new CheckValue(indeval);
        //Console.WriteLine($"Value is: {obj.MyNum[1]}");
        //Console.WriteLine("Hello, World!");
    }
}