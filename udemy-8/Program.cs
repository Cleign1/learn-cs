namespace udemy_8;

class Program
{
    static void Main(string[] args)
    {
        //Employee alice = new Employee("Alice", 25, "Sales Rep", "003001");
        //alice.DisplayEmployeeInfo();

        Manager carl = new Manager("Carl", 45, "Regional Manager", "005001", 10);
        carl.DisplayManagerInfo();
    }
}

public class Person
{
    public int Age { get; private set; }
    public string Name { get; private set; }
    
    public Person(int age, string name)
    {
        Age = age;
        Name = name;
        //Console.WriteLine("Person Constructor Called");
    }
    
    public void DisplayPersonInfo()
    {
        Console.WriteLine($"This Person Name is {Name} and Age {Age}");
    }
}

public class Employee : Person
{
    public string JobTitle { get; private set; }
    public string EmployeeID { get; private set; }
    public Employee(string name, int age, string jobTitle, string employeeID) : base(age, name)
    {
        JobTitle = jobTitle;
        EmployeeID = employeeID;
        //Console.WriteLine("Employee Constructor Called");
    }

    public void DisplayEmployeeInfo()
    {
        DisplayPersonInfo();
        Console.WriteLine($"Job title: {JobTitle}, Employee ID: {EmployeeID}");
    }
}

public class Manager : Employee
{
    public int TeamSize { get; private set; }
    public Manager(string name, int age, string jobTitle, string employeeID, int teamSize) : base(name, age, jobTitle, employeeID)
    {
        TeamSize = teamSize;
        
    }

    public void DisplayManagerInfo()
    {
        DisplayEmployeeInfo();
        Console.WriteLine($"Team Size: {TeamSize}");
    }
}