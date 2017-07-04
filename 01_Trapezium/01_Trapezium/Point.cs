using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Trapezium
{
    public class Point
    {
        public double xCoordinate { get; set; }
        public double yCoordinate { get; set; }
        public string pointName { get; set; }


        public Point(double x, double y)
        : this(x, y, "") { }

        public Point(double x, double y, string name)
        {
            xCoordinate = x;
            yCoordinate = y;
            pointName = name;
        }
        public override string ToString()
        {
            return pointName + " (" + xCoordinate + "; " + yCoordinate + ")";
        }
    }
}
