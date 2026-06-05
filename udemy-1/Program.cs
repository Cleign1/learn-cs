// See https://aka.ms/new-console-template for more information
using System.Globalization;

double numberOne;
double numberTwo;

Console.WriteLine("Enter a Number");
string inputOne = (Console.ReadLine() ?? "0").Replace(',','.');
// inputOne = inputOne.Replace(',','.');

Console.WriteLine("Enter a Second Number");
string inputTwo = (Console.ReadLine() ?? "0").Replace(',','.');
// inputTwo = inputTwo.Replace(',','.');

numberOne = double.Parse(inputOne, CultureInfo.InvariantCulture);
numberTwo = double.Parse(inputTwo, CultureInfo.InvariantCulture);

double total = numberOne + numberTwo;
total = Math.Round(total, 2);

Console.WriteLine($"The total number is {total.ToString(CultureInfo.InvariantCulture)}");
Console.WriteLine($"Current culture is {CultureInfo.CurrentCulture.Name}");