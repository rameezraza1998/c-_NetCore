
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


class Cat : IAnimal
{
    public string Name { get; set; }


    public Cat(string name)
    {
        this.Name = name;
    }

    public void Speak()
    {
        Console.WriteLine($"Meow Meow speaks {Name}");
    }

    public void Eat()
    {
        Console.WriteLine("Cat is eating");


    }

    class Program
    {
        private static void Main(string[] args)
        {


            Dog dog = new Dog("Ciao");
            dog.Speak();
            dog.Eat();


           

            Console.WriteLine();


            Cat cat = new Cat("Bella");
            cat.Speak();
            cat.Eat();
        }
    }
}