namespace udemy_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // key - value, key gk boleh sama
            Dictionary<int, string> employees = new Dictionary<int, string>();

            employees.Add(101, "Jane Doe");
            employees.Add(102, "Bob Smith");

            Console.WriteLine("Employees:\n");
            foreach (KeyValuePair<int, string>  item in employees)
            {
                Console.WriteLine($"Employee ID: {item.Key}, Name: {item.Value}");
            }
        }
    }
}
