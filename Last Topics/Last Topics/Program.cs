//📝 Summary

//File.WriteAllText(path, text) → Overwrites file with text

//File.ReadAllText(path) → Reads entire file as string

//File.ReadAllLines(path) → Reads file into string array (line by line)

//File.WriteAllLines(path, lines) → Writes an array of strings to file

//StreamWriter with using → Best for appending logs & ensuring cleanup

//public class CheckAge
//{

//    public int Age;
//    public CheckAge(int age)
//    {
//        Age = age;
//    }

//    public void getAge()
//    {

//        if(Age < 18)
//        {
//            throw new ArgumentException("Age is not valid");
//        }
//    }



//}
using System.IO;
class Program
{
    private static void Main(string[] args)
    {
        //try
        //{
        //    CheckAge C1 = new CheckAge(19);

        //    Console.WriteLine(C1.Age);
        //    C1.getAge();
        //}
        //catch (ArgumentException ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}
        //finally
        //{
        //    Console.WriteLine("Your code is executed");
        //}

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


        File.WriteAllText("log.txt","This is a log entry."+ DateTime.Now);
        Console.WriteLine("File written Successfully");


        string getText = File.ReadAllText("log.txt");
        Console.WriteLine("Text Before Append");
        Console.WriteLine($"the file text: {getText}");

      
        using (StreamWriter writer = new StreamWriter("log.txt", append: true))
        {
            writer.WriteLine($" Another log entry at: {DateTime.Now}");
        }
           Console.WriteLine("Log appened successfully");

        Console.WriteLine("Text AFter Append");
        string updatedText = File.ReadAllText("log.txt");
        Console.WriteLine($"the updated file text: {updatedText}");
    }
}