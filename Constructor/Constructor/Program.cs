
public class Bike
{
    public string model;
    public string make;
    public int year;

    public Bike()
    {
        model = "Ninja";
        make = "Kawasaki";
        year = 2020;
    }


}



class Truck
{
    public string model;
    public string make;
    public int year;




    public Truck(string modelName, string companyMake, int manufatureYear)
    {
        model = modelName;
        make = companyMake;
        year = manufatureYear;
    }
}

class Car
{
    public string model;
    public string make;
    public int year;
    public Car()
    {
        model = "GT86";
        make = "Toyota";
        year = 2020;
    }


   


    private static void Main(string[] args)
    {

        Car myToyota = new Car();
        Console.WriteLine(myToyota.model);
        Console.WriteLine(myToyota.make);
        Console.WriteLine(myToyota.year);


        Console.WriteLine();


        Bike my70 = new Bike(); 
        Console.WriteLine(my70.model);
        Console.WriteLine(my70.make);
        Console.WriteLine(my70.year);

        Console.WriteLine();

        Truck myFord = new Truck("F-150", "Ford", 2021);
        Console.WriteLine(myFord.model);
        Console.WriteLine(myFord.make);
        Console.WriteLine(myFord.year);



        //Console.WriteLine("Hello, World!");
    }
}