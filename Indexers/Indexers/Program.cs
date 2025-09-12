class MyClass
{
    private int[] data = new int[5];


    public int this[int index] 
    {
        get { return data[index];}
        set { data[index] = value;}
    }
}

class AnotherMyClass
{

    private string [] names = new string[5];

    public string this[int index]
    { 
         get{ return names[index]; }

         set { names[index] = value; }

    }

    public void getAllNames()
    {

        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

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

class AnotherReadOnlyIndexer
{
    private int[] numbers = { 10, 20, 30, 40, 50 };

    public int this[int index]
    {
        get { return numbers[index]; }
    }
}

class CheckValue
{
    private Dictionary<string, string> data = new Dictionary<string, string>();

    public string this[string key]
    {
        get { return data.ContainsKey(key)? data[key] : "Not Found"; }
        set { data[key] = value; }
    }
}


internal class Program
{
    private static void Main(string[] args)
    {
        CheckValue obj = new CheckValue();

        obj["Name"] = "Ramis";
        obj["Age"] = "23";
        obj["City"] = "Karachi";

        Console.WriteLine(obj["Name"]); 
        Console.WriteLine(obj["Group"]);

        AnotherMyClass addname = new AnotherMyClass();

        addname[0] = "Ramis";
        addname[1]= "Ali";
        addname[2] = "Romaisa";
        addname[3] = "Raza";
        addname[4] = "Fatima";
        //addname.getAllNames();

        AnotherReadOnlyIndexer ro = new AnotherReadOnlyIndexer();
        Console.WriteLine(ro[0]);


        //ReadOnlyIndexer obj = new ReadOnlyIndexer();
        //Console.WriteLine(obj[0]); // 

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