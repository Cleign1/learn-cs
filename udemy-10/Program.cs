namespace udemy_10
{
    public interface IShape
    {
        double GetArea();
    }
    public class Circle : IShape
    {
        private readonly double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * _radius * _radius;
        }
    }

    public class Rectangle : IShape
    {
        private readonly double _width;
        private readonly double _height;

        public Rectangle(double height, double width)
        {
            _height = height;
            _width = width;
        }

        public double GetArea()
        {
            return _height * _width;
        }

        public class Program
        {
            public static void Main(string[] args)
            {
                IShape[] shapes = { new Circle(5), new Rectangle(4, 6) };

                foreach (IShape shape in shapes)
                {
                    Console.WriteLine($"Area: {shape.GetArea()}");
                }
            }
        }
    } 
}
