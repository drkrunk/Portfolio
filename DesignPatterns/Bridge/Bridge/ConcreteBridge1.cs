using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    //Example of class with functionality 
    class ConcreteBridge1 : IBridge
    {
        public void Action1()
        {
            Console.WriteLine("Bridge1 did an action1 to fullest extent of the law!");
        }

        public void Action2()
        {
            Console.WriteLine("Bridge1 Action2 very poorly I might add.");
        }
    }
}
