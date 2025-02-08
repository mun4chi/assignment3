using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        
        Console.Write("Enter a dog's name: ");
        string dogName = Console.ReadLine();
        Dog myDog = new Dog { Name = dogName, Colour = "Brown", Age = 5 };
        Console.WriteLine($"Dog's Name: {myDog.Name}, Colour: {myDog.Colour}, Age: {myDog.Age}");
        myDog.Eat();

        Console.Write("Enter a cat's name: ");
        string catName = Console.ReadLine();
        Cat myCat = new Cat { Name = catName, Colour = "Black", Age = 3 };
        Console.WriteLine($"Cat's Name: {myCat.Name}, Colour: {myCat.Colour}, Age: {myCat.Age}");
        myCat.Eat();

        
        Console.Write("Enter a dog's name for the (Interface): ");
        string dogInterfaceName = Console.ReadLine();
        DogInterface myDogInterface = new DogInterface();
        
        
        Console.Write("Enter dog's height: ");
        myDogInterface.Height = Convert.ToDouble(Console.ReadLine());
        
        
        Console.Write("Enter dog's colour: ");
        myDogInterface.Colour = Console.ReadLine();
        
        
        Console.Write("Enter dog's age: ");
        myDogInterface.Age = Convert.ToInt32(Console.ReadLine());
        myDogInterface.Name = dogInterfaceName;
        
        
        Console.WriteLine($"Dog's Name: {myDogInterface.Name}, Height: {myDogInterface.Height}, Colour: {myDogInterface.Colour}, Age: {myDogInterface.Age}");
        myDogInterface.Eat();
        Console.WriteLine(myDogInterface.Cry());

        Console.Write("Enter a cat's name for the (Interface): ");
        string catInterfaceName = Console.ReadLine();
        CatInterface myCatInterface = new CatInterface();
        
        
        Console.Write("Enter cat's height: ");
        myCatInterface.Height = Convert.ToDouble(Console.ReadLine());
        
        
        Console.Write("Enter cat's colour: ");
        myCatInterface.Colour = Console.ReadLine();
        
        
        Console.Write("Enter cat's age: ");
        myCatInterface.Age = Convert.ToInt32(Console.ReadLine());
        myCatInterface.Name = catInterfaceName;
        
        
        Console.WriteLine($"Cat's Name: {myCatInterface.Name}, Height: {myCatInterface.Height}, Colour: {myCatInterface.Colour}, Age: {myCatInterface.Age}");
        myCatInterface.Eat();
        Console.WriteLine(myCatInterface.Cry());

        
        List<IAnimal> animals = new List<IAnimal> { myDogInterface, myCatInterface };
        Console.WriteLine("\nList of Animals:");
        foreach (var animal in animals)
        {
            Console.WriteLine(animal.Name);
        }
    }
}




