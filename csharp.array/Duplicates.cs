using System;

namespace csharp.arrays
{
    internal class DuplicateFinder
    {
        public void FindDuplicates()
        {
            Console.Write("Enter the number of elements: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[n];

            Console.WriteLine("Enter the elements:");
            for (int i = 0; i < n; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nDuplicate elements are:");

            bool foundDuplicate = false;

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        Console.WriteLine(numbers[i]);
                        foundDuplicate = true;
                        break; // avoid printing the same duplicate multiple times
                    }
                }
            }

            if (!foundDuplicate)
            {
                Console.WriteLine("No duplicate elements found.");
            }
        }
    }
}
