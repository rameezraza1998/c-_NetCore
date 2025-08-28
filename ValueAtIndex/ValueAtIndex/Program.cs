
interface CheckValueAtIndex
{

    int[] MyNum { get; set; }
    //int Input { get; set; }
    void checkNumberAtIndex(int input);



}

class CheckValue : CheckValueAtIndex
{
    public int[] MyNum { get; set; }
    //int Input { get; set; }
    //public CheckValue(int mynum)
    //{        
    //    MyNum = new int[] { 1, 2, 3, 4, 5 };
    //}

    public CheckValue(int[] myNum)
    {
        MyNum = myNum;
        //Input = input;
    }
    
    public void checkNumberAtIndex(int input)
    { 
     for (int i = 0; i<MyNum.Length; i++)
        {
            if (MyNum[i] == input)
            {
                Console.WriteLine($"Index number is: {i}");
                return;
            }

        }
        Console.WriteLine("Value not found in the array");
}
}


class Program
{
    private static void Main(string[] args)
    {
        int[] arr = new int[] { 21, 52, 35, 47, 533, 67, 97, 86, 97, 110, 131 };

        Console.Write("type value to get index number: ");

        int input = Convert.ToInt32(Console.ReadLine());
        CheckValue obj = new CheckValue(arr);
        obj.checkNumberAtIndex(input);
        Console.Write("type value to get index number: ");
        int input2 = Convert.ToInt32(Console.ReadLine());
        obj.checkNumberAtIndex(input2);
        //int newArray = obj.MyNum.Length; 
        //Console.WriteLine($"Array Length is: {newArray}");


        //Console.WriteLine(input);






        //bool isValidNumber = int.TryParse(input, out int indexVal);


        //Console.Write("Type index no to get value the value:");



        //int indeval = Console.Read();
        //CheckValue obj = new CheckValue(indeval);
        //Console.WriteLine($"Value is: {obj.MyNum[1]}");
        //Console.WriteLine("Hello, World!");
    }
}