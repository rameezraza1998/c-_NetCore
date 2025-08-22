


public class Car
{
    public string color = "red";
    public int carSpeed = 100;

    public void throtle() { 
    
    Console.WriteLine("The car is accelerating");
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
        //Console.WriteLine($"the color of my Toyota is: {myCar1.color}");


        Truck myTruck = new Truck();
        myTruck.color = "Yellow";
        myTruck.truckSpeed = 99;
        Console.WriteLine($"the color of a truck is: {myTruck.color}");
        Console.WriteLine($"the speed of a truck is: {myTruck.truckSpeed} km/h");
    }
}