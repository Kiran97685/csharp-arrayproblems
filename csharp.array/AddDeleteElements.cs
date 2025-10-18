using System;

namespace csharp.arrays
{
    internal class ArrayOperations
    {
        public void ManageArray()
        {
            int[] numbers = new int[100];
            Console.Write("Enter number of elements: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter elements:");
            for (int i = 0; i < n; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nArray elements:");
            for (int i = 0; i < n; i++)
                Console.Write(numbers[i] + " ");

            // Insert
            Console.Write("\n\nEnter position to insert: ");
            int pos = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter new element: ");
            int newElement = Convert.ToInt32(Console.ReadLine());

            for (int i = n; i > pos; i--)
            numbers[i] = numbers[i - 1];
            numbers[pos] = newElement;
            n++;

            // Delete
            Console.Write("\nEnter position to delete: ");
            int delPos = Convert.ToInt32(Console.ReadLine());
            for (int i = delPos; i < n - 1; i++)
                numbers[i] = numbers[i + 1];
            n--;

            // Update
            Console.Write("\nEnter position to update: ");
            int updatePos = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter new value: ");
            numbers[updatePos] = Convert.ToInt32(Console.ReadLine());

            // Final output
            Console.WriteLine("\nFinal Array:");
            for (int i = 0; i < n; i++)
                Console.Write(numbers[i] + " ");
        }
    }
}
