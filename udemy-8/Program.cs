namespace udemy_8;

class Program
{
    static void Main(string[] args)
    {
        Employee alice = new Employee("Alice", 25);
        alice.DisplayPersonInfo();
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
        Console.WriteLine("Person Constructor Called");
    }
    
    public void DisplayPersonInfo()
    {
        Console.WriteLine($"This Person Name is {Name} and Age {Age}");
    }
}

public class Employee : Person
{
    public Employee(string name, int age) : base(age, name)
    {
        Console.WriteLine("Employee Constructor Called");
    }
}