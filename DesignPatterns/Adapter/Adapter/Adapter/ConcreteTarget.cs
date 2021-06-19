using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    class ConcreteTarget : ITarget
    {
        public void Action1()
        {
            Console.WriteLine("Target Action1: It did a thing.");
        }

        public void Action2()
        {
            Console.WriteLine("Target Action2: It did a diffrent thing.");
        }

        public void Action3()
        {
            Console.WriteLine("Target Action3: It did a unexpected thing.");
        }
    }
}
