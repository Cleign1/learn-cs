namespace udemy_3;

class Program
{
    static void Main(string[] args)
    {
        Customer earl = new Customer("Earl");
        Customer frankTheTank = new Customer("FrankTheTank", "Mainstreet 1", "123");
        // Console.WriteLine($"Name of customer: {earl.Name}");
        // Console.WriteLine($"Name of customer: {frankTheTank.Name}");
        // Console.WriteLine($"{frankTheTank.Name} address is {frankTheTank.Address}");

        Customer myCustomer = new Customer();
        Console.WriteLine($"Name of customer: {myCustomer.Name}");
        myCustomer.Name =  Console.ReadLine();
        Console.WriteLine($"Name of customer: {myCustomer.Name}");
    }
}
