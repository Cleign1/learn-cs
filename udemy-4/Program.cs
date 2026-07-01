namespace udemy_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
            {
                new Product { Name="Pisang", Price = 10},
                new Product { Name="Blueberry", Price = 8},
                new Product { Name="Mangga", Price = 12},
            };

            products.Add(new Product { Name = "Apel", Price = 5 });

            Console.WriteLine("Produk yang tersedia: ");
            foreach (Product item in products)
            {
                Console.WriteLine($"Product Name: {item.Name}, Harganya: Rp{item.Price}K");
            }

            List<Product> produkMurah = products.Where(p => p.Price < 10).ToList();
            Console.WriteLine("\nProduk Murah");
            foreach (Product item in produkMurah)
            {
                Console.WriteLine($"Product Name: {item.Name}, Harganya: Rp{item.Price}K");
            }
        }
    }
}
