using System;
namespace Pr1
{
    class TriangleCalculation
    {
        static void Main()
        {
            double a = 3, b = 4, c = 5; 
            if (IsValidTriangle(a, b, c))
            {
                double perimeter = a + b + c;
                double s = perimeter / 2;
                double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

                Console.WriteLine("Периметр трикутника: " + perimeter);
                Console.WriteLine("Площа трикутника: " + area);
                Console.WriteLine("Вид трикутника: " + GetTriangleType(a, b, c));
            }
            else
            {
                Console.WriteLine("Трикутник з такими сторонами не існує.");
            }
        }
        static bool IsValidTriangle(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a;
        }
        static string GetTriangleType(double a, double b, double c)
        {
            if (a == b && b == c)
            {
                return "Рівносторонній";
            }
            else if (a == b || b == c || a == c)
            {
                return "Рівнобедрений";
            }
            else
            {
                return "Різносторонній";
            }
        }
    }
}
