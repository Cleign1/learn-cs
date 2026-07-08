namespace udemy_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Dog myDog = new Dog();
            Console.WriteLine("Dog. Eat!");
            myDog.Eat();
            myDog.Bark();
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
}
