using System;
using System.Diagnostics;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int amount = 100000000;
            int[] array = new int[amount];

            Console.WriteLine("Generating numbers: " + amount / 10);

            for (int i = 0; i < amount; i++)
                array[i] = rand.Next(amount / 10);

            Console.WriteLine("Numbers generated!");
            Console.WriteLine("Sorting Array...");

                Array.Sort(array);

            Console.WriteLine("Array Sorted!");
            Console.WriteLine("-------------------------------------");

            Console.WriteLine("Size of array: " + amount);
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();

                BinarySearch bs = new BinarySearch(array);
            
            Console.WriteLine("Item Found: "+bs.Search(100));

                stopWatch.Stop();
            Console.WriteLine("Number of array access calls: " + bs.Checks);
            Console.WriteLine("Time Elapsed since search start(ms): " + stopWatch.Elapsed.TotalMilliseconds);
        }
    }
}
