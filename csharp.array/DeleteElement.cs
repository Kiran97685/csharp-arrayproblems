using System;

public class ArrayOperations
{
    private int[] arr = { 1, 2, 3, 4, 5 }; // Array inside the class

    public void DeleteNumberAndPrint()
    {
        Console.WriteLine("Current array:");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();

        Console.WriteLine("Enter number to delete:");
        int num = int.Parse(Console.ReadLine()); // simplified input

        // Find index of number using for loop
        int index = -1;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == num)
            {
                index = i;
                break;
            }
        }

        if (index == -1)
        {
            Console.WriteLine($"{num} is not present in the array.");
            return;
        }

        // Create new array excluding the number
        int[] newArr = new int[arr.Length - 1];
        int j = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (i != index)
            {
                newArr[j++] = arr[i];
            }
        }

        arr = newArr; // update class array

        Console.WriteLine("Array after deletion:");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
}
