namespace udemy11;

class Program
{
    public struct Point
    {
        // public int X { get; set; }
        // public int Y { get; set; }

        public int X;
        public int Y;

        public Point(int x,int y)
        {
            X = x;
            Y = y;
        }

        public void Display()
        {
            System.Console.WriteLine($"Point: ({X},{Y})");
        }
    }

    static void Main(string[] args)
    {
        Point p1 = new Point(1,2);
        p1.Display();

        Point p2;
        p2.X = 12;
        p2.Y = 10;
        p2.Display();

        Point p3;
        p3 = p1;
        p3.X = 22;
        p3.Y = 21;
        p3.Display();
    }   
}
