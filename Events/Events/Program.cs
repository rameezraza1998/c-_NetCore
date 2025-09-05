//public delegate string MyNotify(string message);

//public delegate void WeatherAlert(string message);

public delegate void StockAlert(string message);


class LaptopStock
{ 
    public int laptopCount = 0;
    public event StockAlert StockAlertevent;
    private readonly Action<string> _orderingSystem;



    public LaptopStock(int count, Action<string> orderingSystem)
    {
        laptopCount = count;
        _orderingSystem = orderingSystem;

    }

    public void CheckStock()
    {
        Console.WriteLine($"Current Laptop Stock: {laptopCount}");
        if (laptopCount < 5)
        {
            StockAlertevent?.Invoke("Stock is low! Check your Inventory Store");
            _orderingSystem("Ordering System: Placing order for more laptops.");
        }
        else
        {
            StockAlertevent?.Invoke($"Stock is Sufficient ==>Total quantity is: {laptopCount}");
        }
    }
}

//class WeatherCheck
//{
//    public event WeatherAlert WeatherAlertevent;


//    public void checkTemp(double temp)
//    {
//        Console.WriteLine($"The temperature is: {temp}");

//        if (temp > 30)
//        {
//            WeatherAlertevent?.Invoke("It's too hot! Sending alert...");
//        }
//        else 
//        {
//            WeatherAlertevent?.Invoke("Temperature is Normal... sending Alert!!");
//        }
//    }


//}

class Program
{

    //event MyNotify MyNotifyevent;

    //public string Display(string message)
    //{
    //    return "Message: " + message;
    //}

    //static void DisplayDevice(string message)
    //{
    //     Console.WriteLine("Display Device: " + message);
    //}
    //static void CoolingSystem(string message)
    //{
    //    Console.WriteLine("Cooling System Activated!" + message);
    //}



    static void InventorySystem(string message)
    {
        Console.WriteLine("Inventory System Alert: " + message);
    }
    static void OrderingSystem(string message)
    {
        Console.WriteLine("Ordering System: Placing order for more laptops.");
    }


    private static void Main(string[] args)
    {
        //Program p = new Program();


        //p.MyNotifyevent = new MyNotify(p.Display);
        //string str = p.MyNotifyevent("Hello World");
        //System.Console.WriteLine(str);

        //WeatherCheck weatherCheck = new WeatherCheck();

        //weatherCheck.WeatherAlertevent += DisplayDevice;
        //weatherCheck.WeatherAlertevent += CoolingSystem;
        //weatherCheck.checkTemp(25);

        LaptopStock laptopStock = new LaptopStock(1, OrderingSystem);

        laptopStock.StockAlertevent += InventorySystem;
        laptopStock.CheckStock();

     




        //Console.WriteLine("Hello, World!");
    }
}
