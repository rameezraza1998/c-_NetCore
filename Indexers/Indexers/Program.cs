class MyClass
{
    private int[] data = new int[5];


    public int this[int index] 
    {
        get { return data[index];}
        set { data[index] = value;}
    }
}

class ReadOnlyIndexer
{
    private string[] names = { "Ramis", "Ali", "Romaisa" };

    public string this[int index]
    {
        get { return names[index]; }
    }

}

internal class Program
{
    private static void Main(string[] args)
    {   
        ReadOnlyIndexer obj = new ReadOnlyIndexer();

        Console.WriteLine(obj[0]); // Output: Ramis 


        //MyClass obj = new MyClass();

        //obj[0] = 10;
        //obj[1] = 20;
        //obj[2] = 30;
        //obj[3]= 40;
        //obj[4] = 50;


        //Console.WriteLine(obj[0]); // Output: 10

        //Console.WriteLine("Indexers");
    }
}