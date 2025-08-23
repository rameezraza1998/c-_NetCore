


public class Car
{
    public string color = "red";
    public int carSpeed = 100;

    public void throtle() { 
    
    Console.WriteLine("The car is accelerating");
    }

}

public class Bike
{
    public string color;
    public int horsePower;

    public void accelerate()
    {
        Console.WriteLine("The bike is accelerating");
    }
}

public class Truck
{
    public string color;
    public int truckSpeed; 

    //public void throtle()
    //{
    //    Console.WriteLine("The truck is accelerating");
    //}
}

internal class Program
{



    private static void Main(string[] args)
    {
        Car myCar = new Car();
        Car myCar1 = new Car();
        Console.WriteLine($"the color of my Toyota is: {myCar.color}");
        Console.WriteLine($"the speed of my Toyota is: {myCar.carSpeed} km/h");
        myCar.throtle();

        Console.WriteLine();

        Truck myTruck = new Truck();
        myTruck.color = "Yellow";
        myTruck.truckSpeed = 99;
        Console.WriteLine($"the color of a truck is: {myTruck.color}");
        Console.WriteLine($"the speed of a truck is: {myTruck.truckSpeed} km/h");
        Console.WriteLine();
       

        Bike ninja = new Bike();
        ninja.color = "Green & Black";
        ninja.horsePower = 1600;
        Console.WriteLine($"the color of a bike is: {ninja.color}");
        Console.WriteLine($"the horsepower of a bike is: {ninja.horsePower} CC");
        ninja.accelerate();
        Console.WriteLine();

        Bike hayabusa = new Bike();
        hayabusa.color = "Yellow";
        hayabusa.horsePower = 1600;
        Console.WriteLine($"the color of a bike is: {hayabusa.color}");
        Console.WriteLine($"the horsepower of a bike is: {hayabusa.horsePower} CC");
        hayabusa.accelerate();
    }
}