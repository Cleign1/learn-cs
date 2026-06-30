namespace udemy_3;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Customer
{
    private static int nextId = 0;
    private readonly int _id;
    private string _password;

    public int ID
    {
        get { return _id; }
    }
    public string Password
    {
        set { _password = value; }
    }
    public string Name  { get; set; }
    public string Address { get; set; }
    public string ContactNumber { get; set; }

    public Customer()
    {
        _id = nextId++;
        Name = "Default Name";
        Address = "No Address";
        ContactNumber = "No Number";
    }
    
    // Custom Constructor
    public Customer(string name, string address = "N/A", string contactNumber = "N/A")
    {
        _id = nextId++;
        Name = name;
        Address = address;
        ContactNumber = contactNumber;
    }

    public void SetDetails(string name, string address = "N/A", string contactNumber = "N/A")
    {
        Name = name;
        Address = address;
        ContactNumber = contactNumber;
    }

    public void GetDetails()
    {
        Console.WriteLine($"This customer details is: {Name} and my id is {_id}");
    }
}