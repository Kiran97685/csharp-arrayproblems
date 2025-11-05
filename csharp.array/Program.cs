using ConsoleApp;
using csharp.arrays;
using CSharpCodingChallenge;

class Program
{
    static void Main(string[] args)
    {
        //SumOfNum.CalculateSum();
        //ArrayCalculator.CalculateSumAndAverage();
        //ArrayReverse.PrintReverse();
        //EvenOddNumbers evenOdd = new EvenOddNumbers();
        //evenOdd.CountEvenOdd();
        //DuplicateFinder finder = new DuplicateFinder();
        //finder.FindDuplicates();
        //ArrayOperations ops = new ArrayOperations();
        //ops.ManageArray();
        /*DynamicArray dynamicArray = new DynamicArray();
        dynamicArray.InsertAtFirstPosition();
        MergeArrays obj = new MergeArrays();
        obj.MergeTwoArrays();*/
        //MissingNumber obj = new MissingNumber();
        //obj.FindMissingNumber();
        //ArrayOperations arrayOps = new ArrayOperations();
        //arrayOps.DeleteNumberAndPrint();
        //ReverseArray obj = new ReverseArray();
        //obj.Reverse();
        //obj.Reverse2();
        //Console.ReadLine();
        //DuplicateCharacters obj = new DuplicateCharacters();
        //obj.FindDuplicateCharacters();

        /*Read Text File and Display Employee Records*/

        string filePath = "C:\\Users\\Kurella Kiran\\OneDrive\\Desktop\\StudentData.txt";   // Update path if needed
        //EmployeeReader reader = new EmployeeReader();

        EmployeeReader.ReadFile(filePath);

        Console.ReadLine();
    }
}