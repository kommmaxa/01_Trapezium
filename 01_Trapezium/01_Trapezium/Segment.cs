using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Trapezium
{
    public class Segment
    {
        public Point Point1 { get; set; }
        public Point Point2 { get; set; }

        public double Length
        {
            get { return Math.Sqrt(Math.Pow(Point1.xCoordinate - Point2.xCoordinate, 2) + Math.Pow(Point1.yCoordinate - Point2.yCoordinate, 2));; }
        }


        //public static double Length(Point point1, Point point2)
        //{
        //    return Math.Sqrt(Math.Pow(point1.xCoordinate - point2.xCoordinate, 2) + Math.Pow(point1.yCoordinate - point2.yCoordinate, 2));
        //}
        public Segment(Point point1, Point point2)
        {
            Point1 = point1;
            Point2 = point2;
        }
        public override string ToString()
        {
            return Length.ToString();
        }
    }
}
