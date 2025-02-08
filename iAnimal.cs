public interface IAnimal
{
    string Name { get; set; }
    string Colour { get; set; }
    int Age { get; set; }
    double Height { get; set; }

    void Eat();
    string Cry();
}

