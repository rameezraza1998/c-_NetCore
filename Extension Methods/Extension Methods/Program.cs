
public static class StringExtensions {

    public static bool IsCapitalized(this string str)
    {
        if (string.IsNullOrEmpty(str))
        { 
            Console.WriteLine("String is null or empty.");
            return false;

        }
        return char.IsUpper(str[0]);
    }
}

public static class StringConcatenation
{ 

    public static string concatenationWithSpace(this string str1 ,string str2)
    {
        if(string.IsNullOrEmpty(str1) || string.IsNullOrEmpty(str2))
        {
            Console.WriteLine("One or both strings are null or empty.");
            return string.Empty;
        }
        return string.Concat(str1,str2);
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        //string emptyString = "";
        //string testString1 = "Hello";
        //string testString2 = "world";

        //Console.WriteLine($"{testString1} is capitalized: {testString1.IsCapitalized()}");
        //Console.WriteLine($"{testString2} is capitalized: {testString2.IsCapitalized()}");
        //Console.WriteLine($"Empty string is capitalized: {emptyString.IsCapitalized()}");




        string string1 = " Hello";
        string string2 = " Rameez";

        Console.WriteLine(string2.concatenationWithSpace(string1));
    }
}