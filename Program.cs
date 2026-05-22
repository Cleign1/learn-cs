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

int[] inventory = { 200, 400, 700, 175, 250 };
int sum = 0;
foreach (int nums in inventory)
{
  sum += nums;
  Console.WriteLine(sum);
}

Console.WriteLine($"We Have {sum} items in inventory");