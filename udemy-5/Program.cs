namespace udemy_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // key - value, key gk boleh sama
            Dictionary<int, Employee> employees = new Dictionary<int, Employee>();

            employees.Add(1, new Employee("John Doe", 35, 80000));
            employees.Add(2, new Employee("John Smith", 33, 77000));
            employees.Add(3, new Employee("Jane Doe", 28, 78000));
            employees.Add(4, new Employee("Jane Smith", 25, 88000));
            employees.Add(5, new Employee("Kevin Doe", 23, 250000));

            foreach (var item in employees)
            {
                Console.WriteLine($"Employee ID: {item.Key}, Name: {item.Value.Name}, Age: {item.Value.Age}, Salary : ${item.Value.Salary}");
            }
        }
    }
}
