using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class ConcreteFunctionality : ICommonFunctionality
    {
        public void DoSomething()
        {
            Console.WriteLine("ConcreteFunctionality did some work!");
        }
    }
}
