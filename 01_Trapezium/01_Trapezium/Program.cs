using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Trapezium
{
    class Program
    {
        static Trapezium[] trapezia = new Trapezium[2];
        static void Main(string[] args)
        {

            InitializeData();
            int TrapeziaWhooseSquareAboveAverage = CalculateTrapeziaWhooseSquareAboveAverage(trapezia, CalculateAverageSquare(trapezia));
            DisplayTrapezia(trapezia);
            Console.WriteLine();
            Console.WriteLine("Average square = " + CalculateAverageSquare(trapezia));
            Console.WriteLine("Number of trapezia above average equals " + TrapeziaWhooseSquareAboveAverage);

            Console.ReadLine();
        }
        private static double CalculateAverageSquare(Trapezium[] trapezia)
        {
            double sum = 0;
            for (int i = 0; i < trapezia.Length; i++)
            {
                sum += trapezia[i].CalculateSquare();
            }
            return sum / trapezia.Length;
        }

        private static int CalculateTrapeziaWhooseSquareAboveAverage(Trapezium[] trapezia, double averageSquare)
        {
            int count = 0;
            for (int i = 0; i < trapezia.Length; i++)
            {
                if (trapezia[i].CalculateSquare() > averageSquare)
                    count++;
            }
            return count;
        }
        private static void DisplayTrapezia(Trapezium[] trapezia)
        {
            for (int i = 0; i < trapezia.Length; i++)
            {
                Console.WriteLine(" ===== Trapezia " + (i + 1).ToString() + " ===== ");
                Console.WriteLine(trapezia[i].ToString());
                trapezia[i].DisplaySideLengths();
                Console.WriteLine();
                trapezia[i].DisplayPerimeter();
                trapezia[i].DisplaySquare();
                Console.WriteLine();
            }
        }
        private static void InitializeData()
        {
            Point p1 = new Point(0, 0);
            Point p2 = new Point(1, 3);
            Point p3 = new Point(4, 3);
            Point p4 = new Point(5, 0);
            Trapezium t1 = new Trapezium(p1, p2, p3, p4);

            Point p5 = new Point(0, 0);
            Point p6 = new Point(1, 5);
            Point p7 = new Point(4, 5);
            Point p8 = new Point(5, 0);
            Trapezium t2 = new Trapezium(p5, p6, p7, p8);

            trapezia[0] = t1;
            trapezia[1] = t2;
        }

    }
}
