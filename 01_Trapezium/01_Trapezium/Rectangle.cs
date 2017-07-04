using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Trapezium
{
    class Rectangle : Figure
    {

        public override string Perimeter
        {
            get { return CalculatePerimeter().ToString(); }
        }
        public override string Square
        {
            get { return CalculateSquare().ToString(); }
        }

        public Rectangle(Point point1, Point point2, Point point3, Point point4): base(point1, point2, point3, point4) { }

        public override double CalculatePerimeter()
        {
            return (BottomSide.Length + RightSide.Length) * 2;
        }

        public override double CalculateSquare()
        {
            return BottomSide.Length * RightSide.Length;
        }
    }
}
