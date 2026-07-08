namespace udemy_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result;
            try
            {
                Console.WriteLine("Please input a number");
                int num1 = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
                int num2 = 2;
                result = num2 / num1;
                Console.WriteLine($"The Result is : {result}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Only input an Int, Error : {ex.Message}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Don't Divide by ZEROO!!!! {ex.Message}");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine($"Number TOO big/high, Error : {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error : {ex.Message}");
                throw;
            }
            finally
            {
                
            }
        }
    }
}
