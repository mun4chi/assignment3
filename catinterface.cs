public class CatInterface : IAnimal
{
    public string Name { get; set; }
    public string Colour { get; set; }
    public int Age { get; set; }
    public double Height { get; set; }

    public void Eat()
    {
        Console.WriteLine("Cats eat mice.");
    }

    public string Cry()
    {
        return "Meow!";
    }
}

