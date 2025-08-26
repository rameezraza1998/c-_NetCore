class Person
{

    // fields
    //private string name;
    //private int age;
    //private string address;
    //private string city;
    //private string gender;


    // SHORT HAND GETTER AND SETTER

    public int Height { get; private set; }
    public int Width { get; private set; }


    public Person(int height, int weight)
    {
        Height = height;
        Width = weight;
    }
    public double Area => Height * Width;




    // property
    //public string Name
    //{
    //     get { return name; }
    //    set { name = value; }
    //}

    //public int Age

    //{
    //    get { return age; }
    //    set { age = value;
    //    }

    //}

    //private string Address
    //{
    //    get { return address; }
    //    set { address = value; }

    //}
    //private string City
    //{
    //    get { return city; }
    //    set { city = value; }
    //}
    //private string Gender
    //{
    //    get { return gender; }
    //    set { gender = value; }
    //}


    private static void Main(string[] args)
    {
        Person person1 = new Person(10,20);

        //person1.Height = 10;
        //person1.Width = 20;
        Console.WriteLine(person1.Area);
        //person1.Name = "Rameez";
        //person1.Age = 27;
        //person1.Address = "B-175/18 JTHS";
        //person1.City = "Karachi";
        //person1.Gender = "Male";

        //Console.WriteLine($"the person name: {person1.Name} \n the age is : {person1.Age}");
        //Console.WriteLine($"the person address: {person1.Address} \n the city is : {person1.City}");
        //Console.WriteLine($"the person gender is: {person1.Gender} ");
    }
}