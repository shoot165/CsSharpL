using System;
using FigureLibrary;
namespace Pr3
{
    class FigureProgram
    {
        static void Main(string[] args)
        {
            Point A = new Point(0, 0, "A");
            Point B = new Point(4, 0, "B");
            Point C = new Point(4, 3, "C");
            Figure triangle = new Figure(A, B, C);
            triangle.PerimeterCalculator();
            Point D = new Point(0, 3, "D");
            Figure quadrilateral = new Figure(A, B, C, D);
            quadrilateral.PerimeterCalculator();
        }
    }
}
