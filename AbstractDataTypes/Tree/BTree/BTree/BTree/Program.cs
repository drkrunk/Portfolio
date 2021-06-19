using System;

namespace BTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BTree bt = new BTree(3);

            for (int i = 1; i < 99; i++)
            {
                bt.Insert(i);
                
            }

            

            Console.WriteLine("Hello World!");
        }
    }
}
