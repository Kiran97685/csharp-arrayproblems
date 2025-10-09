using System;

namespace csharp.arrays
{
    internal class ArrayCalculator
    {
        public static void CalculateSumAndAverage()
        {
            Console.Write("Enter the number of elements in the array: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[n];

            // Input elements
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Calculate sum
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += numbers[i];
            }

            // Calculate average
            double average = (double)sum / n;

            Console.WriteLine($"\nSum of array elements: {sum}");
            Console.WriteLine($"Average of array elements: {average:F2}");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
