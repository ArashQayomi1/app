using System;

// Basklass
public class Animal
{
    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public Animal(string name)
    {
        Name = name;
    }

    public void Eat()
    {
        Console.WriteLine($"{Name} is eating.");
    }
}

// Underklass som ärver från Animal
public class Mammal : Animal
{
    private int age;

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public Mammal(string name, int age) : base(name)
    {
        Age = age;
    }

    public void Sleep()
    {
        Console.WriteLine($"{Name} is sleeping.");
    }
}

// Underklass som ärver från Mammal
public class Dog : Mammal
{
    private string breed;

    public string Breed
    {
        get { return breed; }
        set { breed = value; }
    }

    public Dog(string name, int age, string breed) : base(name, age)
    {
        Breed = breed;
    }

    public void Bark()
    {
        Console.WriteLine($"{Name} is barking.");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Dog myDog = new Dog("Buddy", 5, "Golden Retriever");
        Console.WriteLine($"Name: {myDog.Name}, Age: {myDog.Age}, Breed: {myDog.Breed}");

        myDog.Eat();
        myDog.Sleep();
        myDog.Bark();
    }
}
