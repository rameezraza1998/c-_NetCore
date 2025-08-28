
// Static class and Partial class example in C#

using System;
using System.ComponentModel.DataAnnotations;


//partial class Employee
//{ 

//    public void DoWork()
//    {
//        Console.WriteLine("Doing Work");
//    }

//}

//partial class Employee
//{
//    public void TakeBreak()
//    {
//        Console.WriteLine("Taking a Break");
//    }
//}

//public class Person
//{
//    public static string name = "Rameez Raza";
//    public static int age = 26;

//    public Person()
//    {
//        Console.WriteLine($"Name: {name}, Age: {age}");
//    }
//}
public class Student
{
    public string Name { get; set; }
    public Address HomeAddress { get; set; }

    public Student(string name, Address address)
    {
        Name = name;
        HomeAddress = address;
    }

    public void DisplayStudentInfo()
    {
        Console.WriteLine($"Name: {Name}");
        HomeAddress.DisplayAddress();
    }
}
public class Address
{
    public string City { get; set; }
    public string Country { get; set; }

    public Address(string city, string country)
    {
        City = city;
        Country = country;
    }

    public void DisplayAddress()
    {
        Console.WriteLine($"City: {City}, Country: {Country}");
    }
}

public class Animal
{ 
    public string Name { get; set; }
    public Dog doggesh { get; set; }

    public Animal(string name, Dog dog)
    {
        Name = name;
        doggesh = dog;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Animal Name: {Name}, Dog Color: {doggesh.Color}, Dog Age: {doggesh.Age}");
         doggesh.DisplayDogInfo();
    }
}

public class Dog
{ 
    public string Color { get; set; }
    public int Age { get; set; }
    public Dog(string color, int age)
    {
        Color = color;
        Age = age;
    }

    public void DisplayDogInfo()
    {
        Console.WriteLine($"Dog Color: {Color}, Dog Age: {Age}");
    }

}


internal static class Program
{
    //    private static int IdCard = 4333;

    //    public static void DisplayIdCard()
    //    {
    //        Console.WriteLine($"ID Card: {IdCard}");
    //}

    //public static int Square(int Number)
    //{
    //    return Number * Number;
    //}

    private static void Main(string[] args)
    {
        //Program.DisplayIdCard();
        //decimal Square = Program.Square(5);
        //Console.WriteLine($"Square: {Square}");
        //Console.WriteLine("Static & Partial");

        //new Person();
        //Console.WriteLine(Person.name);
        //Console.WriteLine(Person.age);

        //Console.WriteLine();
        //Console.WriteLine("Partial Class Example:");

        //Employee emp = new Employee();
        //emp.DoWork();
        //emp.TakeBreak();

        //Console.WriteLine();

        Student student = new Student(
     "Rameez Raza",
     new Address("Karachi", "Pakistan")
 );
        student.DisplayStudentInfo();



        Animal animal = new Animal(
               "Ciao",
        new Dog("Brown", 3)
               );
        animal.DisplayInfo();

    }
    


}