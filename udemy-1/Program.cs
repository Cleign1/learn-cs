// See https://aka.ms/new-console-template for more information
int numberOne;
int numberTwo;

Console.WriteLine("Enter a Number");
string? inputOne = Console.ReadLine();

Console.WriteLine("Enter a Second Number");
string? inputTwo = Console.ReadLine();

numberOne = int.Parse(inputOne ?? "0");
numberTwo = int.Parse(inputTwo ?? "0");

int total = numberOne + numberTwo;

Console.WriteLine($"The total number is {total}");