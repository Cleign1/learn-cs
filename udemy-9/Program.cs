namespace udemy_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            Dog dog = new Dog();
            Cat cat = new Cat();
            animal.MakeSound();
            dog.MakeSound();
            cat.MakeSound();
        }
    }
    public class Animal
    {
        public virtual void MakeSound()
        {
            Console.Write("Animal makes a sound");
        }
    }
    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.Write("Dog Barks");
        }
    }
    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.Write("Cat meows");
        }
    }
}
