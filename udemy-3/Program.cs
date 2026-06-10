namespace udemy_3;

class Program
{
    static void Main(string[] args)
    {
        Customer myCustomer = new Customer();
        Console.WriteLine($"My Customer: {myCustomer.Name}");
        myCustomer.SetDetails("John Doe", "Side Street 1", "999");
        Console.WriteLine($"My Customer: {myCustomer.Name}");
        Console.WriteLine($"My Customer: {myCustomer.Address}");
        Console.WriteLine($"My Customer: {myCustomer.ContactNumber}");
    }
}
