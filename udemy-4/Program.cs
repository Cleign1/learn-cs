namespace udemy_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nomor = new List<int>() { 10, 15, 5, 19, 3, 11,1, 99, 25, 9, 2, 3, 6};

            Console.WriteLine("Unsorted List");
            foreach (int item in nomor)
            {
                Console.Write($"{item}, ");
            }

            Console.WriteLine(" ");
            Console.WriteLine("semua nomor lebih tinggi dari 25");
            List<int> nomorLebihDariSepuluh = nomor.FindAll(x => x >= 25);
            foreach (int item in nomorLebihDariSepuluh)
            {
                Console.Write($"{item}, ");
            }

            Console.WriteLine(" ");
            nomor.Sort();
            Console.WriteLine("Sorted List");
            foreach (int item in nomor)
            {
                Console.Write($"{item}, ");
            }
        }
    }
}
