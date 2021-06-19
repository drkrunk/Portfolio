using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class AnotherConcreteClass : BaseClass
    {
        public AnotherConcreteClass()
        {
            ClassFunctionality = new AnotherConcreteFunctionality();
        }
    }
}
