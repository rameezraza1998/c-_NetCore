
class Animal
{


    public Animal(string name, int eyes)
    {
        Console.WriteLine($"Animal named : {name} and has {eyes} odd color eyes.");
    }

    protected int eyes = 2; 
    public virtual void Eat()
    {
        Console.WriteLine("Animal eat food.");
    }

    
}

class Dog : Animal
{ 
    public Dog(string name, int eye) : base(name, eye)
    {
        Console.WriteLine("Dog created.");
    }

    public void Bark()
    {
        Console.WriteLine("Dog barks.");
    }
    public void ShowEyes()
    {
        Console.WriteLine($"Dog has {eyes} eyes.");
    }

    public override void Eat()
    {
        Console.WriteLine("Dog eat dog food.");
    }


}

class Cat : Animal {     
    public Cat(string name, int eye) : base(name, eye)
    {
        Console.WriteLine("Cat created.");
    }
    public void Meow()
    {
        Console.WriteLine("Cat meows.");
    }
    public override void Eat()
    {
        Console.WriteLine("Cat eat cat food.");
    }
}   



class Program
{
    private static void Main(string[] args)
    {   

        Dog rotwiller = new Dog("Rottweiler", 2);

        rotwiller.Eat();
        //rotwiller.Bark();
        //rotwiller.ShowEyes();

        Cat persian = new Cat("Persian", 2);
        persian.Eat();

        //Console.WriteLine("Hello, World!");
    }
}