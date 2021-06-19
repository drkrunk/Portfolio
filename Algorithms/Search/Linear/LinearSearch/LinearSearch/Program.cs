using System;
using System.Diagnostics;

namespace LinearSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int amount = 100000000;
            int[] array = new int[amount];

            Console.WriteLine("Generating numbers: " + amount/10);
            
            for (int i = 0; i < amount; i++)
                array[i] = rand.Next(amount/10);

            Console.WriteLine("Numbers generated!");
            Console.WriteLine("-------------------------------------");

            Console.WriteLine("Size of array: " + amount);
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();


            int accessCount = 0;

            //Example of Linear Search Worst case O(n)
            for (accessCount = 0; accessCount < array.Length; accessCount++)
                if (array[accessCount] == 100) break;   
            //End Example

            stopWatch.Stop();
            Console.WriteLine("Number of array access calls: " + accessCount);
            Console.WriteLine("Time Elapsed since search start(ms): "+stopWatch.Elapsed.TotalMilliseconds);

        }
    }
}
