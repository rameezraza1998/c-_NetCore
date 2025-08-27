
class OnlinePayment
{
    //public OnlinePayment(string name)
    //{
    //    Console.WriteLine($"Processing online payment via: {name}");
    //}

    public virtual void ProcessPayment()
    { 
        Console.WriteLine("Payment is being processed.");
    }
  
}

class CreditCardPayment : OnlinePayment
{
    //public CreditCardPayment(string name) : base(name)
    //{
    //    Console.WriteLine("Credit Card payment completed.");
    //}

    public override void ProcessPayment()
    {
        Console.WriteLine("Payment is being processed by CreditCard.");
    }


}

class PaypalPayment : OnlinePayment
{
    //public PaypalPayment(string name) : base(name)
    //{ 
    //    Console.WriteLine("Paypal payment completed.");
    //}


    public override void ProcessPayment()
    {
        Console.WriteLine("Payment is being processed by Paypal.");
    }



}

class BankTransferPayment : OnlinePayment
{

    //public BankTransferPayment(string name) : base(name)
    //{ 
    //    Console.WriteLine("Bank Transfer payment completed.");

    //}


    public override void ProcessPayment()
    {
        Console.WriteLine("Payment is being processed by Bank transfer.");
    }


}



class Program
{
    private static void Main(string[] args)
    {

        CreditCardPayment creditCardPayment = new CreditCardPayment();
        //creditCardPayment.ProcessPayment();

        PaypalPayment paypalPayment = new PaypalPayment();
        //paypalPayment.ProcessPayment();

        BankTransferPayment bankTransferPayment = new BankTransferPayment();
        bankTransferPayment.ProcessPayment();

        //Console.WriteLine("Hello, World!");
    }
}