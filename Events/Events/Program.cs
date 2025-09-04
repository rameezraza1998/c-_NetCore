public delegate string MyNotify(string message);

public delegate void WeatherAlert(string message);

class WeatherCheck
{
    public event WeatherAlert WeatherAlertevent;


    public void checkTemp(double temp)
    {
        Console.WriteLine($"The temperature is: {temp}");

        if (temp > 30)
        {
            WeatherAlertevent?.Invoke("It's too hot! Sending alert...");
        }
        else 
        {
            WeatherAlertevent?.Invoke("Temperature is Normal... sending Alert!!");
        }
    }


}

class Program
{

    event MyNotify MyNotifyevent;
    //public string Display(string message)
    //{
    //    return "Message: " + message;
    //}

    static void DisplayDevice(string message)
    {
         Console.WriteLine("Display Device: " + message);
    }
    static void CoolingSystem(string message)
    {
        Console.WriteLine("Cooling System Activated!" + message);
    }


    private static void Main(string[] args)
    {
        //Program p = new Program();


        //p.MyNotifyevent = new MyNotify(p.Display);
        //string str = p.MyNotifyevent("Hello World");
        //System.Console.WriteLine(str);

        WeatherCheck weatherCheck = new WeatherCheck();

        weatherCheck.WeatherAlertevent += DisplayDevice;
        weatherCheck.WeatherAlertevent += CoolingSystem;
        weatherCheck.checkTemp(25);






        //Console.WriteLine("Hello, World!");
    }
}