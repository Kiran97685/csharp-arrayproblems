using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.arrays
{
    public class SumOfNum
    {
        public static void CalculateSum()
        {
            Console.Write("Enter a number (N): ");
            int n = Convert.ToInt32(Console.ReadLine());

            int sum = n * (n + 1) / 2;

            Console.WriteLine($"\nThe sum of first {n} natural numbers is: {sum}");
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
