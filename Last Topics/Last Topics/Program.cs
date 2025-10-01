public class CheckAge
{

    public int Age;
    public CheckAge(int age)
    {
        Age = age;
    }

    public void getAge()
    {

        if(Age < 18)
        {
            throw new ArgumentException("Age is not valid");
        }
    }
    

  
}

class Program
{
    private static void Main(string[] args)
    {
        try
        {
            CheckAge C1 = new CheckAge(19);

            Console.WriteLine(C1.Age);
            C1.getAge();
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("Your code is executed");
        }

       

        //try
        //{
        //    int x = 10; int y = 2;
        //    int result = x / y;
        //    Console.WriteLine($"Result: {result}");
        //}
        //catch (Exception e)
        //{
        //    Console.WriteLine($"Cannot divide by Zero {e.Message}");
        //}
        //finally
        //{
        //    Console.WriteLine("The code is terminated");
        //}


    }
}