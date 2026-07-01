namespace udemy_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<String> nomor = new List<String>();

            nomor.Add("1");
            nomor.Add("2");
            nomor.Add("3");
            Console.WriteLine("Nomor di dalam list ada:");
            foreach (var item in nomor)
            {
                Console.WriteLine(item);
            }
            nomor.Remove("1");
            Console.WriteLine("Nomor di dalam list ada:");
            foreach (var item in nomor)
            {
                Console.WriteLine(item);
            }
        }
    }
}
