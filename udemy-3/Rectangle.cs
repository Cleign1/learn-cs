using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace udemy_3
{
    internal class Rectangle
    {
        public const int NumberOfCorners = 4;
        public readonly string Color;

        public double Width { get; set; }
        public double Length { get; set; }

        public Rectangle(string color)
        {
            Color = color;
        }

        public void GetDetails()
        {
            Console.WriteLine($"This Rectangle color is {Color}, Width: {Width}, Length :{Length}, Number of corners: {NumberOfCorners}");
        }
    }
}
