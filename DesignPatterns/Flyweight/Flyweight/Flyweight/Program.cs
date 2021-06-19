using System;
using System.Collections.Generic;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Flyweight> flyweightList = new List<Flyweight>();
            FlyweightFactory flyweightFactory = new FlyweightFactory();

            Console.WriteLine(GC.GetTotalMemory(true));

            //Non flyweight memory usage
            //for (int i = 0; i < 1000000; i++) fls.Add(new Flyweight(i % 10 + ""));

            //Flyweight memory usage
            for (int i = 0; i < 1000000; i++) flyweightList.Add( flyweightFactory.GetFlyweight(i % 10 + ""));
            
            Console.WriteLine(GC.GetTotalMemory(true));
        }




    }
}
