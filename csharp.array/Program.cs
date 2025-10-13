using csharp.arrays;

class Program
{
    static void Main(string[] args)
    {
        SumOfNum.CalculateSum();
        ArrayCalculator.CalculateSumAndAverage();
        ArrayReverse.PrintReverse();
        EvenOddNumbers evenOdd = new EvenOddNumbers();
        evenOdd.CountEvenOdd();
    }
}