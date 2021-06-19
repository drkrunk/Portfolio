using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            ITarget concreteTarget = new ConcreteTarget();
            Adaptee adaptee = new Adaptee();

            ITarget adapter = new Adapter(adaptee);

            concreteTarget.Action1();
            concreteTarget.Action2();
            concreteTarget.Action3();

            Console.WriteLine();

            adapter.Action1();
            adapter.Action2();
            adapter.Action3();

        }
    }
}
