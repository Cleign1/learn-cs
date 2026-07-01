namespace udemy_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nomor = new List<int>() { 10, 15, 5, 19, 3, 11,1};

            Console.WriteLine("Unsorted List");
            foreach (int item in nomor)
            {
                Console.Write($"{item}, ");
            }

            nomor.Sort();
            Console.WriteLine("Sorted List");
            foreach (int item in nomor)
            {
                Console.Write($"{item}, ");
            }
        }
    }
}
