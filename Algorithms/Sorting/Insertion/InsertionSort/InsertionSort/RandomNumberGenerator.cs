using System;
using System.Collections.Generic;
using System.Text;

namespace InsertionSort
{
    class RandomNumberGenerator
    {
        public static int[] GenerateNumbers(int amount){
            int[] result = new int[amount];
            Random rand = new Random();

            for (int i = 0; i < amount; i++)
                result[i] = rand.Next(10000);

            return result;
        }

    }
}
