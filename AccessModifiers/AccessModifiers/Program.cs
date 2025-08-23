// Access Modifiers in C#

/*
 
Public: The member is accessible from any other code.
private: The member is accessible only within its own class.
protected: The member is accessible within its own class and by derived class instances.
internal: The member is accessible only within files in the same assembly.
protected internal: The member is accessible within its own assembly or from derived classes.
private protected: The member is accessible within its own class or derived classes that are in the same assembly.

*/



// Public modifier example
class myPublicClass
{
    public string PublicName; // Accessible from anywhere
    private int PrivateAge; // Accessible only within this class

    public myPublicClass()
    {
        PublicName = "Public Name";
        PrivateAge = 27;
    }
}


// Private modifier example

internal class Program
{
    private string PrivateName; // Accessible only within this class
    public Program()
    {
        PrivateName = "Private Name";
    }

    private static void Main(string[] args)
    {

        // Public modifier example
        myPublicClass publicObj = new myPublicClass();
        Console.WriteLine(publicObj.PublicName); // Accessible from anywhere
        // private variable is not accessible here
        //Console.WriteLine(publicObj.PrivateAge);

        Console.WriteLine();


        // Private modifier example
        Program privateObj = new Program();
        Console.WriteLine(privateObj.PrivateName); // Accessible only within this class
    }
}