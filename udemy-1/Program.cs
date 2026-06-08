// See https://aka.ms/new-console-template for more information
// conditional based calculator

Console.WriteLine("Enter the first number: ");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the second number: ");
double num2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Choose an operation: +, -, *, /");
string op = Console.ReadLine();
double result = 0;
if (op == "+")
{
    result = num1 + num2;
}
else if (op == "-")
{
    result = num1 - num2;
}
else if (op == "*")
{
    result = num1 * num2;
}
else if (op == "/")
{
    if (num2 != 0)
    {
        result = num1 / num2;
    }
    else
    {
        Console.WriteLine("Cannot divide by zero.");
        return;
    }
}
else
{
    Console.WriteLine("Invalid operator.");
    return;
}
Console.WriteLine($"Result: {result}");