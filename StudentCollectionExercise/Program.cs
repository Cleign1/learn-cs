namespace StudentCollectionExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Student> students = new Dictionary<string, Student>()
            {
                {"John", new Student(1, "John", 85)},
                {"Alice", new Student(2, "Alice", 90)},
                {"Bob", new Student(3,"Bob", 78)}
            };

            foreach (var item in students)
            {
                Console.WriteLine($"Name: {item.Key}, Id: {item.Value.ID}, Grade: {item.Value.Grade}");
            }
        }
    }

    class Student
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public int Grade { get; set; }
        public Student(int id, string name, int grade)
        {
            ID = id;
            Name = name;
            Grade = grade;
        }
    }
}
