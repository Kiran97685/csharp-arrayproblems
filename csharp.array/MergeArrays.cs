using System;

namespace csharp.arrays
{
    internal class MergeArrays
    {
        public void MergeTwoArrays()
        {
            // Step 1: Take first array input
            Console.Write("Enter size of first array: ");
            int size1 = Convert.ToInt32(Console.ReadLine());
            int[] arr1 = new int[size1];

            Console.WriteLine("Enter elements of first array:");
            for (int i = 0; i < size1; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Step 2: Take second array input
            Console.Write("\nEnter size of second array: ");
            int size2 = Convert.ToInt32(Console.ReadLine());
            int[] arr2 = new int[size2];

            Console.WriteLine("Enter elements of second array:");
            for (int i = 0; i < size2; i++)
            {
                arr2[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Step 3: Create merged array
            int[] mergedArray = new int[size1 + size2];

            // Step 4: Copy elements from first array
            for (int i = 0; i < size1; i++)
            {
                mergedArray[i] = arr1[i];
            }

            // Step 5: Copy elements from second array
            for (int i = 0; i < size2; i++)
            {
                mergedArray[size1 + i] = arr2[i];
            }

            // Step 6: Print merged array
            Console.WriteLine("\nMerged Array:");
            for (int i = 0; i < mergedArray.Length; i++)
            {
                Console.Write(mergedArray[i] + " ");
            }
        }
    }
}
