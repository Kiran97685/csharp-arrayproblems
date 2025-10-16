using System;

namespace csharp.arrays
{
    internal class DynamicArray
    {
        public void InsertAtFirstPosition()
        {
            // Step 1: Create a static array with fixed size
            int[] arr = new int[5];
            int count = 0; // number of elements currently in the array

            Console.Write("Enter number of elements (max 5): ");
            count = Convert.ToInt32(Console.ReadLine());

            // Step 2: Take elements from user
            Console.WriteLine("Enter elements:");
            for (int i = 0; i < count; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Step 3: Take new element to insert at first position
            Console.Write("Enter the element to insert at first position: ");
            int newElement = Convert.ToInt32(Console.ReadLine());

            // Step 4: Check if array is full
            if (count == arr.Length)
            {
                // Create a new array with double size
                int newSize = arr.Length * 2;
                int[] newArr = new int[newSize];

                // Copy old elements into new array (shifted by 1)
                newArr[0] = newElement;
                for (int i = 0; i < count; i++)
                {
                    newArr[i + 1] = arr[i];
                }

                arr = newArr; // point old reference to new array
                count++;
            }
            else
            {
                // Shift elements right to make space at first position
                for (int i = count; i > 0; i--)
                {
                    arr[i] = arr[i - 1];
                }

                arr[0] = newElement; // insert new element
                count++;
            }

            // Step 5: Print final array
            Console.WriteLine("\nArray after insertion:");
            for (int i = 0; i < count; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
