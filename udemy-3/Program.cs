namespace udemy_3;

class Program
{
    static void Main(string[] args)
    {
        Car audi = new Car("A3", "Audi", false);
        Car bmw = new Car("M5", "BMW", true);
        
        Console.WriteLine($"Brand is {audi.Brand}");
        Console.WriteLine($"Brand is {bmw.Brand}");
        
    }
}
