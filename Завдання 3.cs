using System;
namespace Pr1
{
    class ArrayMinMax
    {
        static void Main()
        {
            int number = 5; 
            int length = 10 + number;
            int[] array = new int[length];
            Random rand = new Random();
            for (int i = 0; i < length; i++)
            {
                array[i] = rand.Next(-100, 101); 
            }
            int min = array[0];
            int max = array[0];
            Console.WriteLine("Масив:");
            foreach (int num in array)
            {
                Console.Write(num + " ");
                if (num < min)
                {
                    min = num;
                }
                if (num > max)
                {
                    max = num;
                }
            }
            Console.WriteLine("\nМінімальне значення: " + min);
            Console.WriteLine("Максимальне значення: " + max);
        }
    }
}
