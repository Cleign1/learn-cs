namespace ErrorHandlingExercise;

class Program
{
    static void Main(string[] args)
    {
        HandleMultipleExceptions("5", 10);
    }

    public static void HandleMultipleExceptions(string numberString, int index) // Method to handle multiple exceptions
    {
        int[] numbers = { 1, 2, 3 }; // Array for accessing elements
 
        try
        {
            // Attempt to parse an integer from the input string
            int number = int.Parse(numberString);
            // Attempt to access an element in the array by index
            Console.WriteLine(numbers[index]);
        }
        catch (FormatException) // Catch block to handle FormatException
        {
            // Print an error message for invalid format
            Console.WriteLine("Invalid format.");
        }
        catch (IndexOutOfRangeException) // Catch block to handle IndexOutOfRangeException
        {
            // Print an error message for index out of range
            Console.WriteLine("Index out of range.");
        }
    }
}