using System;
using System.Diagnostics;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generating numbers...");
            int[] nums = RandomNumberGenerator.GenerateNumbers(10000);
            BubbleSort b = new BubbleSort();

            Console.WriteLine("Sorting numbers...");
            Stopwatch watch = System.Diagnostics.Stopwatch.StartNew();
            b.Sort(ref nums);
            watch.Stop();

            Console.WriteLine("Time taken to sort: " + watch.ElapsedMilliseconds);

        }
    }
}
