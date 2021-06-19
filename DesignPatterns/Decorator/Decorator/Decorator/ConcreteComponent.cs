using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    //Holds the root ref
    class ConcreteComponent : IComponent
    {
        public string Print()
        {
            return "ConcreteComponent";
        }
    }
}
