namespace udemy_3;

class Program
{
    static void Main(string[] args)
    {
        Customer myCustomer = new Customer();
        myCustomer.SetDetails("John Doe");
        // Console.WriteLine($"Name: {myCustomer.Name}, Address: {myCustomer.Address}, Contact: {myCustomer.ContactNumber}");

        Customer customer1 = new Customer("Frank");
        Console.WriteLine("Enter Frank Phone Number");
        customer1.ContactNumber = Console.ReadLine() ?? "N/A";
        Console.WriteLine($"Name: {customer1.Name}, Address: {customer1.ContactNumber}");
    }
}
