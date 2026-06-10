namespace udemy_2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Welcome to my Calculator App!");
        Console.Write("Enter the first number: ");
        int num1 = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("Enter the second number: ");
        int num2 = int.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("Select an operation: +, -, *, /");
        string? operation = Console.ReadLine();
        int result = 0;
        if (operation == "+")
        {
            result = Add(num1, num2);
        }
        else if (operation == "-")
        {
            result = Subtract(num1, num2);
        }
        else if (operation == "*")
        {
            result = Multiply(num1, num2);
        }
        else if (operation == "/")
        {
            try
            {
                result = Divide(num1, num2);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
        }
        else
        {
            Console.WriteLine("Invalid operation selected.");
            return;
        }
        Console.WriteLine($"The result of {num1} {operation} {num2} is: {result}");
    }
    static int Add(int a, int b)
    {
        return a + b;
    }

    static int Subtract(int a, int b)
    {
        return a - b;
    }

    static int Multiply(int a, int b)
    {
        return a * b;
    }

    static int Divide(int a, int b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }
        return a / b;
    }
}
