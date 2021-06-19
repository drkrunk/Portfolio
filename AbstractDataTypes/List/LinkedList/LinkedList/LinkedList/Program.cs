using System;
using System.Buffers;
using System.Collections.Generic;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> list = new LinkedList<string>();
            List<string> clist = new List<string>();

            list.Add("t0");
            list.Add("t1");
            list.Add("t2");
            list.Add("t3");
            list.Add("t4");
            list.Add("t5");

            while(!list.Empty) Console.WriteLine(list.Pop());
        }
    }
}
