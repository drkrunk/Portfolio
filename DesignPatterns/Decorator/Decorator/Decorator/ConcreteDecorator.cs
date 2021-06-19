using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class ConcreteDecorator : AbstractDecorator
    {
        public ConcreteDecorator(IComponent objToBeDecorated) : base(objToBeDecorated) { }

        public override string Print()
        {

            return base.Print() + " | ConcreteDecorator";
        }

    }
}
