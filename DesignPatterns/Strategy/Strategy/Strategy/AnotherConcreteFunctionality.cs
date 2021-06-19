using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class AnotherConcreteFunctionality : ICommonFunctionality
    {
        public void DoSomething()
        {
            Console.WriteLine("AnotherConcreteFunctionality did a thing!");
        }
    }
}
