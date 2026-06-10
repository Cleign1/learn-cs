namespace udemy_3;

class Program
{
    static void Main(string[] args)
    {
        Car audi = new Car("Audi", "A3");
        Car bmw = new Car("BMW", "M5");
        Console.WriteLine(audi);
        Console.WriteLine(bmw);
    }
}
