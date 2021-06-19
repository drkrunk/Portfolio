using System;
using System.Diagnostics;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generating numbers...");
            int[] nums = RandomNumberGenerator.GenerateNumbers(1000000);
            QuickSort qs = new QuickSort();
            Console.WriteLine("Sorting numbers...");

            Stopwatch watch = System.Diagnostics.Stopwatch.StartNew();
            qs.Sort(ref nums, 0, nums.Length - 1);
            watch.Stop();

            Console.WriteLine("Time taken to sort in ms: " + watch.ElapsedMilliseconds);
        }
    }
}
