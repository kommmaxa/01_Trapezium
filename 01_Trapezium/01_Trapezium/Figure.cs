using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Trapezium
{
    public abstract class Figure
    {
        protected Point Point1 { get; set; }
        protected Point Point2 { get; set; }
        protected Point Point3 { get; set; }
        protected Point Point4 { get; set; }
        protected Segment LeftSide { get; set; }
        protected Segment UpperSide { get; set; }
        protected Segment RightSide { get; set; }
        protected Segment BottomSide { get; set; }
        public virtual string Perimeter { get; set; }
        public virtual string Square { get; set; }
        public abstract double CalculateSquare();
        public abstract double CalculatePerimeter();
        public Figure(Point point1, Point point2, Point point3, Point point4)
        {
            Point1 = point1;
            Point2 = point2;
            Point3 = point3;
            Point4 = point4;
            LeftSide = new Segment(point1, point2);
            UpperSide = new Segment(point2, point3);
            RightSide = new Segment(point3, point4);
            BottomSide = new Segment(point4, point1);
        }

        public override string ToString()
        {
            return "Points: " + Point1.ToString() + " " + Point2.ToString() + " " + Point3.ToString() + " " + Point4.ToString();
        }
        public void DisplaySideLengths()
        {
            Console.WriteLine("Left side has length of " + LeftSide);
            Console.WriteLine("Upper side has length of " + UpperSide);
            Console.WriteLine("Right side has length of " + RightSide);
            Console.WriteLine("Bottom side has length of " + BottomSide);
        }

        public void DisplayPerimeter()
        {
            Console.WriteLine("Figure's perimeter = " + Perimeter);
        }
        public void DisplaySquare()
        {
            Console.WriteLine("Figure's square = " + Square);
        }
    }
}
