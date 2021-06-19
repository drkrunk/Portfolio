using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory f = new Factory();

            AbstractClass ac1 = f.CreateConcreteClass("1");
            AbstractClass ac2 = f.CreateConcreteClass("2");

            ac1.Print();
            ac2.Print();

        }
    }
}
