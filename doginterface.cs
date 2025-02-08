public class DogInterface : IAnimal
{
    public string Name { get; set; }
    public string Colour { get; set; }
    public int Age { get; set; }
    public double Height { get; set; }

    public void Eat()
    {
        Console.WriteLine("Dogs eat meat.");
    }

    public string Cry()
    {
        return "Woof!";
    }
}
