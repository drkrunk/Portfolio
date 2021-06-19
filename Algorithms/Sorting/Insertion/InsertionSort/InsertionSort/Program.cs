using System;
using System.Diagnostics;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generating numbers...");
            int[] nums = RandomNumberGenerator.GenerateNumbers(100000);
            InsertionSort isort = new InsertionSort();

            Console.WriteLine("Sorting numbers...");
            Stopwatch watch = System.Diagnostics.Stopwatch.StartNew();
            isort.Sort(ref nums);
            watch.Stop();

            Console.WriteLine("Time taken to sort: " + watch.ElapsedMilliseconds);
        }
    }
}
