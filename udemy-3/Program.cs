namespace udemy_3;

class Program
{
    static void Main(string[] args)
    {
        Car myAudi = new Car("A4", "Audi", true);
        myAudi.Drive();
        Console.WriteLine($"My new Car is {myAudi.Brand}, {myAudi.Model}!");
        
        Car myBMW = new Car("7-Series", "BMW", true);
        myBMW.Drive();
    }
}
