

// Abstraction



abstract class Animal
{
    public abstract void AnimalSound();

    public void Eat()
    {
        Console.WriteLine("Eating...");
    }

}

class Cat : Animal
{
    public override void AnimalSound()
    {
        Console.WriteLine("Meow");
    }
    public void Walk()
    {
        Console.WriteLine("Cat is walking");
    }
}

abstract class Shape 
{
    public string Name { get; set; }

    public Shape(string name) 
    {

        Name = name ;
    
    }

    public void Display()
    {
        Console.WriteLine($"Shape Name: {Name}");
    }


    public abstract decimal GetArea();
    
}


class Reactangle  : Shape
{
    public decimal Width { get; set; }
    public decimal Height { get; set; }

    public Reactangle(string name, decimal width, decimal height) : base(name)
    {
        Width = width;
        Height = height;
    }

    public override decimal GetArea()
    {
        return Width * Height;
    }

}

class Circle : Shape
{
    public decimal Radius { get; set; } 
    public Circle(string name, decimal radius) : base(name)
    {
        Radius = radius;
    }

    public override decimal GetArea()
    {
        return  Convert.ToDecimal(Math.PI)* Radius;
    }


}
    class Program
{
    private static void Main(string[] args)
    {
        //Cat myCat = new Cat();
        //myCat.AnimalSound();
        //myCat.Eat();
        //myCat.Walk();

        Reactangle reactangle = new Reactangle("Reactangle", 10, 20);
        decimal AreaofReactangle = reactangle.GetArea();
        reactangle.Display();
        Console.WriteLine($"Area of Reactangle: {AreaofReactangle}");

        Circle circle = new Circle("Circle", 5);
        decimal AreaofCircle = circle.GetArea();
        circle.Display();
        Console.WriteLine($"Area of Circle: {AreaofCircle}");

    }
}