using System;

namespace csharp.arrays
{
    internal class ArrayReverse
    {
        public static void PrintReverse()
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

            Console.WriteLine("\nArray elements in reverse order:");
            for (int i = n - 1; i >= 0; i--)
            {
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine("\n\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
