// Get started on array basics

// string[] fraudulentOrderIDs = new string[3];

// fraudulentOrderIDs[0] = "A123";
// fraudulentOrderIDs[1] = "B456";
// fraudulentOrderIDs[2] = "C789";
// // fraudulentOrderIDs[3] = "D000";

// Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
// Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
// Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

// fraudulentOrderIDs[0] = "F000";

// Console.WriteLine($"New First : {fraudulentOrderIDs[0]}");

// string[] fraudulentOrderIDs = [ "A123", "B456", "C789"];

// Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
// Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
// Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

// fraudulentOrderIDs[0] = "F000";

// Console.WriteLine($"New First : {fraudulentOrderIDs[0]}");

// Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process");

// Implement For Each statement

// string[] names = { "Ibnu", "Yudha", "Bao"};

// foreach (string name in names)
// {
//   Console.WriteLine(name);
// }

// int[] inventory = { 200, 400, 700, 175, 250 };
// int sum = 0;
// int bin = 0;
// foreach (int nums in inventory)
// {
//   sum += nums;
//   bin++;
//   Console.WriteLine($"Bin {bin} = {nums} items (Running Total: {sum})");
// }

// Console.WriteLine($"We Have {sum} items in inventory");

// Unit 4

// string[] codes = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];
// foreach (string code in codes)
// {
//   if (code.StartsWith("B"))
//   {
//     Console.WriteLine(code);
//   }
// }

// Perform Basic string formatting in C#

// Console.WriteLine("Hello \"Brother\"");
// Console.WriteLine("c:\\users\\ibnuk");

// Console.WriteLine("Generating Output for \"User\" ... \n");
// Console.WriteLine("Answer: Generating\t...");
// Console.WriteLine("Answer:Found...\t\tComplete!");
// Console.Write("\nOutput Directory\n");
// Console.WriteLine("C:\\users\\ibnuk\\answers.txt");

// Combine Strings Unit 3

string firstName = "Bob";
string lastName = "Shmurda";
string message = $"Hello {firstName} {lastName}";
Console.WriteLine(message);