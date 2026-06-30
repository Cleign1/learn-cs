using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace udemy_3;

class Program
{
    static void Main(string[] args)
    {
        Customer myCustomer = new Customer();
        Customer myCustomer2 = new Customer("Jane Doe");

        myCustomer.GetDetails();
        myCustomer2.GetDetails();

        Console.WriteLine($"My first customer id is {myCustomer.ID}");

    }
}
