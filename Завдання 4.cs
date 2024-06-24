using System;
using System.Collections.Generic;
namespace Pr1
{
    class ArrayFilter
    {
        static void Main()
        {
            int number = 5; 
            int length = 10 + number;
            int[] X = new int[length];
            Random rand = new Random();
            for (int i = 0; i < length; i++)
            {
                X[i] = rand.Next(-100, 101); 
            }
            int M = 10; 
            List<int> Y = new List<int>();
            foreach (int num in X)
            {
                if (Math.Abs(num) > M)
                {
                    Y.Add(num);
                }
            }
            Console.WriteLine("Число M: " + M);
            Console.WriteLine("Масив X:");
            foreach (int num in X)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("\nМасив Y:");
            foreach (int num in Y)
            {
                Console.Write(num + " ");
            }
        }
    }
}
