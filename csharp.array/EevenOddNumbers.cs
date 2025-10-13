using System;

namespace csharp.arrays
{
    internal class EvenOddNumbers
    {
        public void CountEvenOdd()
        {
            Console.Write("Enter the number of elements: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[n];

            Console.WriteLine("Enter the elements:");
            for (int i = 0; i < n; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            int evenCount = 0, oddCount = 0;

            for (int i = 0; i < n; i++)
            {
                if (numbers[i] % 2 == 0)
                    evenCount++;
                else
                    oddCount++;
            }

            Console.WriteLine("\nEven numbers count: " + evenCount);
            Console.WriteLine("Odd numbers count: " + oddCount);
        }
    }
}
