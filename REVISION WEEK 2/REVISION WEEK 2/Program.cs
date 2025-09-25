//public class Person
//{

//    private int age;
//    public string name { get; set;}

//    private string password { get;  set; }

//    public int Age
//    {
//        get { return age; }

//        set
//        {
//            if (value >= 0)
//            {
//                age = value;
//            }
//        }
//    }

//    public string Password
//    {
//        set
//        { 
//            password = value;
//        }
//    }
//}


//public class Book
//{ 
//    public string Title {  get; set; }
//    public string Name { get; set; }
//    public string Author { get; set; }


//    public Book()
//    {
//        Title = "Unknown";
//        Name = "Harry Potter";
//        Author = "unknown";
//    }



//    public Book(string title, string name, string author)
//    { 
//        Title = title;
//        Name = name;
//        Author = author;

//    }


//}


//public class Person
//{ 


//    public string name;
//    public int age;
//    public int id;



//    public void Introduction(string name, int age, int id)
//    {

//        Console.WriteLine($"Hello {name}, Age: {age}, id{id}"); 
//    }
//}


//public class Car
//{ 

//    public string Make { get; set; }

//    public string Model { get; set; }

//    public int Year { get; set; }



//    public void DisplayInfo()
//    {
//        Console.WriteLine($"Make: {Make}, Model: {Model}, Year: {Year}");

//    }

//}


//public class Student
//{

//    public int StdID;
//    public string StdName;
//    public int StdClass;


//    public Student(int id, string name, int standard)
//    {
//        StdID = id;
//        StdName = name;
//        StdClass = standard;
//    }


//    public void PrintInfo()
//    {

//        Console.WriteLine($"Student name: {StdName} \n Student_ID: {StdID} \n Student_Class: {StdClass}th");

//    }

//}

//public class BankAccount
//{

//    public string Name;
//    public string Accountnumber;
//    public double Balance = 0;



//    public double WithDraw(double amount)
//    { 
//        return Balance = Balance - amount;
//    }

//    public double Deposit(double amount)
//    { 
//        return Balance = Balance + amount;   
//    }

//    public void DisplayInfo()
//    { 
//        Console.WriteLine($"Account under the name of: {Name} \n Balance: {Balance}");
//    }


//}

//public class Rectangle
//{
//    public double Width { get; set; }
//    public double Height { get; set; }

//    public double GetArea()
//    {
//        return Width * Height;
//    }

//    public double GetPerimeter()
//    {
//        return 2 * (Height + Width);
//    }

//    public void DisplayInfo()
//    {
//        Console.WriteLine($"Width: {Width} \n Height: {Height} \n Area: {GetArea()} \n Perimeter: {GetPerimeter()}");
//    }

//}



// simple overriding started Day 2 of revision week 2


//public class Animal
//{

//    public virtual void Speak()
//    {
//        Console.WriteLine("Animal speaks");
//    }

//}

//public class Dog : Animal
//{
//    public string breed;

//    public sealed override void Speak()
//    {
//        base.Speak();
//        Console.WriteLine($"{breed} Barks ");
//    }

//}
///


//public class Vechile
//{ 
//    public virtual void Start()
//    {

//        Console.WriteLine("Engine starts!!");

//    }
//}

//public class Car : Vechile
//{
//    public string Make {  get; set; }
//    public override void Start()
//    {
//        Console.WriteLine($"{Make} Engine starts!!!!!!!!");
//    }
//}


//public class Bike : Vechile
//{
//    public string Make { get; set; }
//    public override void Start()
//    {
//        Console.WriteLine($"{Make} Engine starts!!!!!!!!!!");
//    }
//}


//public class Shape
//{
//    public virtual void Draw()
//    {
//        Console.WriteLine("Shape draw method");
//    }
//}

//public class Circle : Shape
//{

//    public override void Draw()
//    {
//        Console.WriteLine("Circle draw method");
//    }
//}

//public class Reactangle : Shape
//{

//    public override void Draw()
//    {
//        Console.WriteLine("Reactangle draw method");
//    }
//}

//abstract class Shape
//{
//    public abstract double GetArea();
//    public abstract double GetPerimeter();

//}

// class Circle : Shape
//{
//    public int radius;
//    public override double GetArea()
//    {
//        return radius*radius * (3.142);
//    }
//    public override double GetPerimeter()
//    {
//        return (radius * 3.142) * 2;
//    }
//}

// Interface start


public interface IDriveable
{
    void Drive();
}
public interface IFlyable
{

    void Fly();
}

public class Car : IDriveable
{
    public void Drive()
    {
        Console.WriteLine("Car is being drive ");
    }
}

public class Plane : IFlyable, IDriveable
{
    public void Drive()
    {
        Console.WriteLine("Plane is taxing on thr Runway!");
    }
    public void Fly()
    {
        Console.WriteLine("Plane is about to fly");
    }
}

internal class Program
    {
        private static void Main(string[] args)
        {

        IDriveable driveable = new Car();
        driveable.Drive();

        Plane flyable = new Plane();
        flyable.Fly();
        flyable.Drive();

        //Rectangle rectangle = new Rectangle();
        //rectangle.Width = 5;
        //rectangle.Height = 10;

        //rectangle.DisplayInfo();


        // getter setter and class and objects concepts

        // Person person1 =new Person();
        //int ramisAge= person1.Age = 10;
        //string testName = person1.name = "Ramis";
        //person1.Password = "heylo";



        //Console.WriteLine(ramisAge);
        //Console.WriteLine(testName);    


        //Console.WriteLine(person1.Password);


        // Constructor concept started


        //Book book1 = new Book();

        //Console.WriteLine(book1.Title);
        //Console.WriteLine(book1.Name);
        //Console.WriteLine(book1.Author);

        //Person person = new Person();
        // person.Introduction("Ramis", 27, 143);

        //Car toyota = new Car();
        //toyota.Make = "Toyota";
        //toyota.Model = "Tundra";
        //toyota.Year = 2018;
        //toyota.DisplayInfo();

        //Student std1 = new Student(3485, "Syed Muhammad Rameez Raza", 10);
        //std1.PrintInfo();

        //BankAccount account1 = new BankAccount();
        //account1.Name = "Rameez";
        //account1.Deposit(10);
        //account1.DisplayInfo();
        //account1.WithDraw(5);
        //account1.DisplayInfo();





        // simple overriding started Day 2 of revision week 2


        //Dog dog = new Dog();
        //dog.breed = "German Shepherd";
        //dog.Speak();

        //BullDog bd= new BullDog();
        //bd.Speak();

        //Cat cat = new Cat();
        //cat.breed = "Ragdoll";
        //cat.Speak();

        //Vechile car = new Car();
        //car.Start();
        
        //Vechile bike = new Bike();
        //bike.Start();
       


       // Circle circle = new Circle();
       // circle.Draw();

       //Reactangle reactangle = new Reactangle();
       // reactangle.Draw();


       // Circle c1 = new Circle();
       // c1.radius = 2;
       //Console.WriteLine(c1.GetArea());
       // Console.WriteLine(c1.GetPerimeter());

    }
}
