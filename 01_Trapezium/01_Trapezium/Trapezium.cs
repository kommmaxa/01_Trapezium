using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Trapezium
{
    class Trapezium : Rectangle
    {
        public bool IsEqualSided
        {
            get { return LeftSide.Length == RightSide.Length; }
        }

        public Trapezium(Point point1, Point point2, Point point3, Point point4): base(point1, point2, point3, point4) { }
        public override double CalculatePerimeter()
        {
            return LeftSide.Length * 2 + BottomSide.Length + UpperSide.Length;
        }

        public override double CalculateSquare()
        {
            double firstPart = (BottomSide.Length + UpperSide.Length) / 2;

            double up = Math.Pow(BottomSide.Length - UpperSide.Length, 2) + LeftSide.Length * LeftSide.Length - RightSide.Length * RightSide.Length;
            double down = 2 * (BottomSide.Length - UpperSide.Length);
            double brackets = Math.Pow(up / down, 2);
            double secondPart = LeftSide.Length * LeftSide.Length - brackets;

            return firstPart * Math.Sqrt(secondPart);
        }

        private bool LeftAndRightSidesAreEqual()
        {
            return LeftSide.Length == RightSide.Length;
        }
    }
}
