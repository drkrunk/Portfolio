using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class ConcreteClass : BaseClass
    {
        public ConcreteClass()
        {
            ClassFunctionality = new ConcreteFunctionality();
        }
    }
}
