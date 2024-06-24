using System;
namespace Pr1
{
    class IntervalSelection
    {
        static void Main()
        {
            int number = 5; 
            int[] numbers = { 5, 15, 8 }; 
            int min = 1;
            int max = 10 + number;
            Console.WriteLine("Числа, які належать інтервалу [" + min + "," + max + "]:");
            foreach (int num in numbers)
            {
                if (num >= min && num <= max)
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}
