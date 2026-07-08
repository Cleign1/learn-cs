namespace udemy_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, my dog is a German Shepherd");

            GermanSheperd dog = new GermanSheperd();
            dog.Bark();
            dog.Sniff();
            dog.Eat();

            Console.WriteLine("I also have a cat");
            Cat cat = new Cat();
            cat.Eat();
            cat.Meow();
        }
    }

    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eeating...");
        }
    }

    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Barking....");
        }
    }
    class GermanSheperd : Dog
    {
        public void Sniff()
        {
            Console.WriteLine("This German Sheperd is sniffing drugs!!.....");
        }
    }

    class Cat : Animal
    {
        public void Meow()
        {
            Console.WriteLine("This cat is meowing!...");
        }
    }
}
