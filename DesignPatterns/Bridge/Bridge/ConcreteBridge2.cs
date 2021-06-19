using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    //Example of class with functionality 
    class ConcreteBridge2 : IBridge
    {
        public void Action1()
        {
            Console.WriteLine("Bridge2 did an action1!");
        }

        public void Action2()
        {
            Console.WriteLine("Bridge2 did a cool action2!");
        }
    }
}
