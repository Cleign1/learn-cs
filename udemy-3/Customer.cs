namespace udemy_3;

public class Customer
{
    public string Name  { get; set; }
    public string Address { get; set; }
    public string ContactNumber { get; set; }

    public Customer()
    {
        Name = "Default Name";
        Address = "No Address";
        ContactNumber = "No Number";
    }
    
    // Custom Constructor
    public Customer(string name, string address, string contactNumber)
    {
        Name = name;
        Address = address;
        ContactNumber = contactNumber;
    }

    public Customer(string name)
    {
        Name = name;
    }
}