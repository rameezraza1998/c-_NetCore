
interface IAnimal 
{
    // Property
    string Name { get; set; }


    // Method
     void Speak();
     void Eat();

    // fields are not allowed in interfaces means variables are not allowed

}


class Dog : IAnimal

{ 
    public string Name { get; set; }


    public Dog(string name) 
    {
        this.Name = name;
       
    }

    public void Speak()
    {
        Console.WriteLine($"Woof Woof speaks {Name}");
    }

    public void Eat()
    {
        Console.WriteLine("Dog is eating");
    }
}

class Program
{
    private static void Main(string[] args)
    {


        Dog dog = new Dog("Bella");
        dog.Speak();
        dog.Eat();
        Console.WriteLine("Hello, Interface!");
    }
}